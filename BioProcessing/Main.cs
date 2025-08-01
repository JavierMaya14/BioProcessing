using Newtonsoft.Json;
using ScottPlot.WinForms;

namespace BioProcessing
{
    public partial class Main : Form
    {
        // Atributos de la clase Main
        private System.Drawing.Rectangle originalBounds; // Tamaño original 
        private Point windowLocation; // Punto para locaizar la ventana
        private FormsPlot graph = new(); // Objeto de tipo ScottPlot
        private SignalData? datos; // Composición de señales 

        // Constructor
        public Main()
        {
            InitializeComponent();
        }

        // Función de carga
        private void Form1_Load(object sender, EventArgs e)
        {   // Se oculta al botón de modo ventana
            btnWindow.Hide();

            // Se llama al método para personalizar botones
            customButton(btnLoad);
            customButton(btnX);
            customButton(btnMaximize);
            customButton(btnWindow);
            customButton(btnMinimizee);
            customButton(btnSave);
            customButton(btnClear);

            // Se añade la gráfica al layout 1
            tableLayoutPanel1.Controls.Add(graph);

            // Personalización del gráfico principal
            graph.Dock = DockStyle.Fill;
            graph.Plot.FigureBackground.Color = ScottPlot.Color.FromHex("#37374A");
            graph.Plot.DataBackground.Color = ScottPlot.Color.FromHex("#37374A");
            graph.Plot.Axes.Color(ScottPlot.Colors.White);
            graph.Plot.Axes.AutoScale();
            graph.Plot.Layout.Frameless();
            graph.Plot.HideGrid();

            // Personalización del gráfico de ffts
            fftGraph.Dock = DockStyle.Fill;
            fftGraph.Plot.FigureBackground.Color = ScottPlot.Color.FromHex("#37374A");
            fftGraph.Plot.DataBackground.Color = ScottPlot.Color.FromHex("#37374A");
            fftGraph.Plot.Axes.Color(ScottPlot.Colors.White);
            fftGraph.Plot.Axes.AutoScale();
            fftGraph.Plot.Axes.Left.TickLabelStyle.IsVisible = false;
            fftGraph.Plot.Axes.Right.FrameLineStyle.Width = 0;
            fftGraph.Plot.Axes.Left.FrameLineStyle.Width = 0;
            fftGraph.Plot.Axes.Left.MajorTickStyle.Length = 0;
            fftGraph.Plot.Axes.Left.MinorTickStyle.Length = 0;
            fftGraph.Plot.Axes.Top.FrameLineStyle.Width = 0;
            fftGraph.Plot.HideGrid();
        }

        // Botón para cerrar el formulario
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        // Evento de click del botón maximize
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            originalBounds = this.Bounds; // Tamaño antes de maximizar
            this.Bounds = Screen.FromHandle(this.Handle).WorkingArea; // Para que use toda el area de trabajo
            btnMaximize.Visible = false;
            btnWindow.Visible = true;
        }

        // Botón de modo ventana
        private void btnWindow_Click(object sender, EventArgs e)
        {
            this.Bounds = originalBounds;
            btnWindow.Hide();
            btnMaximize.Show();
        }

        // Método de personalización de botones
        private void customButton(Button btn)
        {
            btn.BackColor = System.Drawing.Color.FromArgb(45, 45, 61); // mismo color que el fondo del formuario
            btn.FlatAppearance.MouseOverBackColor = btnLoad.BackColor;
            btn.FlatAppearance.MouseDownBackColor = btnLoad.BackColor;
            btn.FlatAppearance.BorderSize = 0; // Para quitar bordes
        }

        // Botón minimizar
        private void btnMinimizee_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Panel de arrastre y que contiene la barra de botones
        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            this.windowLocation = e.Location;
        }

        // Función de arrastre del formulario
        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            // Si se presiona el click izquierdo 
            if (e.Button == MouseButtons.Left)
            {
                // Refers to the Form location 
                this.Location = new Point(
                    (this.Location.X - windowLocation.X) + e.X,
                    (this.Location.Y - windowLocation.Y) + e.Y
                );

                this.Update();
            }
        }

        // Botón de carga
        private void btnLoad_Click(object sender, EventArgs e)
        {

            // Si se consigue abrir el cuadro de diálogo
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Lectura de los datos
                    string jsonContent = File.ReadAllText(openFileDialog1.FileName);
                    datos = JsonConvert.DeserializeObject<SignalData>(jsonContent);

                    if (datos != null)
                    {
                        //MessageBox.Show("Archivo cargado correctamente");
                        GraphSet(datos, graph); // Método para configurar el gráfico

                        if (datos.ECG != null && datos.PCG != null && datos.RW != null && datos.RS != null)
                        {
                            Signal.FftIter(datos.ECG);
                            Signal.FftIter(datos.PCG);
                            Signal.FftIter(datos.RW);
                            Signal.FftIter(datos.RS);
                        }
                    }
                }
                // Si hubo algún error
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al leer el archivo: {ex.Message}");
                }
            }
        }

        // Funcion para configurar el gráfico y graficar las señales 
        private void GraphSet(SignalData _data, FormsPlot plot)
        {
            try
            {
                // Carga de las señales
                // Datos de ECG
                if (_data.ECG?.data != null)
                {
                    double ecg_fs = _data.ECG.fs;
                    double[] xs = Enumerable.Range(0, _data.ECG.data.Length)
                                                .Select(i => i / ecg_fs)
                                                .ToArray();
                    var sig1 = plot.Plot.Add.SignalXY(xs, _data.ECG.data, ScottPlot.Colors.Lime);
                    sig1.Data.YOffset = 4.5;
                    sig1.LegendText = "ECG";
                    sig1.LineWidth = 2;
                }

                // Datos de PCG
                if (_data?.PCG?.data != null)
                {
                    // Carga de datos
                    double pcg_fs = _data.PCG.fs;
                    double[] xs = Enumerable.Range(0, _data.PCG.data.Length)
                            .Select(i => i / pcg_fs)
                            .ToArray();
                    // Se manda al gráfico
                    var sig2 = plot.Plot.Add.SignalXY(xs, _data.PCG.data, ScottPlot.Colors.Gold);
                    sig2.Data.YOffset = 3;
                    sig2.LegendText = "PCG";
                    sig2.LineWidth = 2;

                }

                // Datos de onda de respiracón
                if (_data?.RW?.data != null)
                {
                    double rw_fs = _data.RW.fs;
                    // Vector de tiempo
                    double[] xs = Enumerable.Range(0, _data.RW.data.Length)
                            .Select(i => i / rw_fs)
                            .ToArray();
                    // Se manda al gráfico
                    var sig3 = plot.Plot.Add.SignalXY(xs, _data.RW.data, ScottPlot.Colors.Cyan);
                    sig3.Data.YOffset = 1.5;
                    sig3.LegendText = "Respiratory Wave";
                    sig3.LineWidth = 2;
                }

                // Datos de onda de sonidos respiratorios
                if (_data?.RS?.data != null)
                {
                    double rs_fs = _data.RS.fs;
                    // Vector de tiempo
                    double[] xs = Enumerable.Range(0, _data.RS.data.Length)
                            .Select(i => i / rs_fs)
                            .ToArray();
                    // Se manda al gráfico
                    var sig4 = plot.Plot.Add.SignalXY(xs, _data.RS.data, ScottPlot.Colors.Magenta);
                    sig4.Data.YOffset = 0;
                    sig4.LegendText = "Respiratory Sounds";
                    sig4.LineWidth = 2;
                }

                // Detalles finales
                plot.Plot.Axes.AutoScale();
                plot.Plot.Legend.BackgroundColor = ScottPlot.Color.FromHex("#404040");
                plot.Plot.Legend.FontColor = ScottPlot.Color.FromHex("#d7d7d7");
                plot.Plot.Legend.OutlineColor = ScottPlot.Color.FromHex("#d7d7d7");
                plot.Plot.Title("Acquired Data", 20);

                plot.Refresh();

            }

            catch (Exception ex)
            {
                {
                    MessageBox.Show($"Error al intentar graficar los datos {ex.Message}");
                }
            }

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            graph.Plot.Clear();
            fftGraph.Plot.Clear();

            graph.Refresh();
            fftGraph.Refresh();


        }

        private void fftOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (fftOptions.SelectedItem != null && datos != null)
            {
                double[] freq = Array.Empty<double>();
                double[] magnitude = Array.Empty<double>();
                string seleccion = fftOptions.SelectedItem.ToString();
                ScottPlot.Color fftColor = ScottPlot.Colors.Orange;

                if (seleccion == "ECG" && datos.ECG?.fft != null && datos.ECG.freq != null)
                {
                    freq = datos.ECG.freq;
                    magnitude = datos.ECG.fft;
                    fftColor = ScottPlot.Colors.Lime;
                }

                else if (seleccion == "PCG" && datos.PCG?.fft != null && datos.PCG.freq != null)
                {
                    freq = datos.PCG.freq;
                    magnitude = datos.PCG.fft;
                    fftColor = ScottPlot.Colors.Gold;
                }

                else if (seleccion == "RW" && datos.RW?.fft != null && datos.RW.freq != null)
                {
                    freq = datos.RW.freq;
                    magnitude = datos.RW.fft;
                    fftColor = ScottPlot.Colors.Cyan;
                }

                else if (seleccion == "RS" && datos.RS?.fft != null && datos.RS.freq != null)
                {
                    freq = datos.RS.freq;
                    magnitude = datos.RS.fft;
                    fftColor = ScottPlot.Colors.Magenta;

                }

                fftGraph.Plot.Clear();
                var sig5 = fftGraph.Plot.Add.SignalXY(freq, magnitude, fftColor);
                fftGraph.Plot.Axes.SetLimitsX(0, 1000);
                fftGraph.Plot.Axes.AutoScaleY();
                fftGraph.Plot.Axes.AutoScaleX();
                fftGraph.Plot.Title($"{seleccion} FFT");
                sig5.LineWidth = 2;
                fftGraph.Refresh();
            }
        }

        // Botón para guardar las señales
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (datos == null)
            {
                MessageBox.Show("No hay datos cargados");
                return;
            }
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos JSON (*.json)|*.json";
            saveFileDialog.Title = "Guardar señales como JSON";
            
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string json = JsonConvert.SerializeObject(datos, Formatting.Indented);
                    File.WriteAllText(saveFileDialog.FileName, json);
                    MessageBox.Show("Archivo guardado correctamente");
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Error al guardar el archivo: {ex.Message}");
                }
            }
        }
    }
}