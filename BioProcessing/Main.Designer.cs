namespace BioProcessing
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panel1 = new Panel();
            btnClear = new Button();
            btnSave = new Button();
            btnLoad = new Button();
            panel3 = new Panel();
            label1 = new Label();
            btnX = new Button();
            btnMaximize = new Button();
            btnWindow = new Button();
            btnMinimizee = new Button();
            panel4 = new Panel();
            panel5 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            fftGraph = new ScottPlot.WinForms.FormsPlot();
            fftOptions = new ComboBox();
            label3 = new Label();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 45, 54);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnLoad);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(115, 548);
            panel1.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Transparent;
            btnClear.BackgroundImageLayout = ImageLayout.None;
            btnClear.Cursor = Cursors.Hand;
            btnClear.Dock = DockStyle.Bottom;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Image = (Image)resources.GetObject("btnClear.Image");
            btnClear.Location = new Point(0, 516);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(115, 32);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.TextAlign = ContentAlignment.BottomCenter;
            btnClear.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.BackgroundImageLayout = ImageLayout.None;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Dock = DockStyle.Top;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.Location = new Point(0, 109);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(115, 38);
            btnSave.TabIndex = 2;
            btnSave.Text = "Export";
            btnSave.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.Transparent;
            btnLoad.BackgroundImageLayout = ImageLayout.None;
            btnLoad.Cursor = Cursors.Hand;
            btnLoad.Dock = DockStyle.Top;
            btnLoad.FlatAppearance.BorderSize = 0;
            btnLoad.FlatStyle = FlatStyle.Flat;
            btnLoad.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoad.ForeColor = Color.White;
            btnLoad.Image = (Image)resources.GetObject("btnLoad.Image");
            btnLoad.Location = new Point(0, 64);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(115, 45);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Import";
            btnLoad.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(192, 192, 0);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(115, 64);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Unispace", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 14);
            label1.Name = "label1";
            label1.Size = new Size(79, 33);
            label1.TabIndex = 0;
            label1.Text = "BioP";
            // 
            // btnX
            // 
            btnX.BackColor = Color.Transparent;
            btnX.Cursor = Cursors.Hand;
            btnX.FlatAppearance.BorderSize = 0;
            btnX.FlatStyle = FlatStyle.Flat;
            btnX.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnX.ForeColor = Color.White;
            btnX.Image = (Image)resources.GetObject("btnX.Image");
            btnX.ImageAlign = ContentAlignment.TopCenter;
            btnX.Location = new Point(94, 0);
            btnX.Name = "btnX";
            btnX.Size = new Size(23, 22);
            btnX.TabIndex = 2;
            btnX.TextAlign = ContentAlignment.BottomCenter;
            btnX.TextImageRelation = TextImageRelation.ImageAboveText;
            btnX.UseVisualStyleBackColor = false;
            btnX.Click += button2_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.BackColor = Color.Transparent;
            btnMaximize.Cursor = Cursors.Hand;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMaximize.ForeColor = Color.White;
            btnMaximize.Image = (Image)resources.GetObject("btnMaximize.Image");
            btnMaximize.ImageAlign = ContentAlignment.TopCenter;
            btnMaximize.Location = new Point(70, -3);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(20, 25);
            btnMaximize.TabIndex = 3;
            btnMaximize.TextAlign = ContentAlignment.BottomCenter;
            btnMaximize.TextImageRelation = TextImageRelation.ImageAboveText;
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnWindow
            // 
            btnWindow.BackColor = Color.Transparent;
            btnWindow.Cursor = Cursors.Hand;
            btnWindow.FlatAppearance.BorderSize = 0;
            btnWindow.FlatStyle = FlatStyle.Flat;
            btnWindow.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnWindow.ForeColor = Color.White;
            btnWindow.Image = (Image)resources.GetObject("btnWindow.Image");
            btnWindow.ImageAlign = ContentAlignment.TopCenter;
            btnWindow.Location = new Point(69, 0);
            btnWindow.Name = "btnWindow";
            btnWindow.Size = new Size(23, 22);
            btnWindow.TabIndex = 4;
            btnWindow.TextAlign = ContentAlignment.BottomCenter;
            btnWindow.TextImageRelation = TextImageRelation.ImageAboveText;
            btnWindow.UseVisualStyleBackColor = false;
            btnWindow.Click += btnWindow_Click;
            // 
            // btnMinimizee
            // 
            btnMinimizee.BackColor = Color.Transparent;
            btnMinimizee.Cursor = Cursors.Hand;
            btnMinimizee.FlatAppearance.BorderSize = 0;
            btnMinimizee.FlatStyle = FlatStyle.Flat;
            btnMinimizee.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinimizee.ForeColor = Color.White;
            btnMinimizee.Image = (Image)resources.GetObject("btnMinimizee.Image");
            btnMinimizee.ImageAlign = ContentAlignment.TopCenter;
            btnMinimizee.Location = new Point(43, 0);
            btnMinimizee.Name = "btnMinimizee";
            btnMinimizee.Size = new Size(23, 22);
            btnMinimizee.TabIndex = 5;
            btnMinimizee.TextAlign = ContentAlignment.BottomCenter;
            btnMinimizee.TextImageRelation = TextImageRelation.ImageAboveText;
            btnMinimizee.UseVisualStyleBackColor = false;
            btnMinimizee.Click += btnMinimizee_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(45, 45, 54);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(115, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(843, 26);
            panel4.TabIndex = 6;
            panel4.MouseDown += panel4_MouseDown;
            panel4.MouseMove += panel4_MouseMove;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnX);
            panel5.Controls.Add(btnMinimizee);
            panel5.Controls.Add(btnMaximize);
            panel5.Controls.Add(btnWindow);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(726, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(117, 26);
            panel5.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(55, 55, 74);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.056736F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.943264F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(115, 26);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(843, 522);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(fftGraph, 0, 2);
            tableLayoutPanel2.Controls.Add(fftOptions, 0, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(526, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 53.2945747F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.589147F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(314, 516);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // fftGraph
            // 
            fftGraph.DisplayScale = 1.25F;
            fftGraph.Location = new Point(3, 299);
            fftGraph.Name = "fftGraph";
            fftGraph.Size = new Size(308, 192);
            fftGraph.TabIndex = 0;
            // 
            // fftOptions
            // 
            fftOptions.BackColor = Color.FromArgb(46, 46, 64);
            fftOptions.Dock = DockStyle.Right;
            fftOptions.Font = new Font("Unispace", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fftOptions.ForeColor = SystemColors.Control;
            fftOptions.FormattingEnabled = true;
            fftOptions.Items.AddRange(new object[] { "ECG", "PCG", "RW", "RS" });
            fftOptions.Location = new Point(220, 267);
            fftOptions.Name = "fftOptions";
            fftOptions.Size = new Size(91, 27);
            fftOptions.TabIndex = 1;
            fftOptions.SelectedIndexChanged += fftOptions_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(308, 26);
            label3.TabIndex = 3;
            label3.Text = "BPM      RPM";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Archivos JSON (*.json) | *.json";
            // 
            // Main
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            BackColor = Color.FromArgb(45, 45, 64);
            ClientSize = new Size(958, 548);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(62, 120, 138);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            RightToLeft = RightToLeft.No;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label label1;
        private Button btnLoad;
        private Button btnX;
        private Button btnMaximize;
        private Button btnWindow;
        private Button btnMinimizee;
        private Panel panel4;
        private Panel panel5;
        private Button btnSave;
        private Button btnClear;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private OpenFileDialog openFileDialog1;
        private ScottPlot.WinForms.FormsPlot fftGraph;
        private ComboBox fftOptions;
        private Label label3;
    }
}
