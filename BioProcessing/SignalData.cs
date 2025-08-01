using System.Numerics;


namespace BioProcessing
{
    // Composición de señales
    public class SignalData
    {
        public Signal? ECG { get; set; }
        public Signal? PCG { get; set; }
        public Signal? RW { get; set; }
        public Signal? RS { get; set; }
    }

    // Señales de tiempo, con data y frecuencia de muestreo
    public class Signal
    {
        public double[]? data { get; set; }
        public double[]? fft { get; set; }
        public double fs { get; set; }

        public double[]? freq { get; set; }

        // Método para calcular la fft
        public static void FftIter(Signal signal)
        {
            int newN = NextPowerOfTwo(signal.data.Length);
            Complex[] X = new Complex[newN];

            Complex[] converted = signal.data.Select(d => new Complex(d, 0)).ToArray();
            Array.Copy(converted, 0, X, 0, converted.Length);

            int N = newN;
            int nu = (int)Math.Log2(N);

            X = BitReversalComplex(X);

            for (int m = 1; m <= nu; m++)
            {
                int L = 1 << m;
                int L2 = L >> 1;

                for (int ir = 0; ir < L2; ir++)
                {
                    Complex W = Complex.Exp(-2 * Math.PI * Complex.ImaginaryOne * ir / L);

                    for (int it = ir; it < N; it += L)
                    {
                        int ib = it + L2;

                        Complex t1 = X[it];
                        Complex t2 = X[ib] * W;

                        X[it] = t1 + t2;
                        X[ib] = t1 - t2;
                    }
                }
            }
            int N2 = X.Length / 2; // Mitad del número de muestras

            if (signal.fft != null)
            {
                double max = signal.fft.Max();
                signal.fft = X.Take(N2).Select(c => c.Magnitude / max).ToArray();
            }
            else
                signal.fft = X.Take(N2).Select(c => c.Magnitude).ToArray(); // sin normalizar

            signal.freq = Enumerable.Range(0, N2)
                           .Select(j => (j * (signal.fs / 2) / (double)N2))
                           .ToArray();
        }

        // Método para calcular la sguiente potencia de 2
        public static int NextPowerOfTwo(int N)
        {
            int power = 1;
            while (power < N)
                power <<= 1;
            return power;
        }

        // Función para bit reversal de arreglos complejos
        private static Complex[] BitReversalComplex(Complex[] x)
        {
            int N = x.Length;
            int r = 0;
            for (int n = 0; n < N - 1; n++)
            {
                if (n < r)
                {
                    (x[n], x[r]) = (x[r], x[n]);
                }

                int k = N / 2;
                while (k <= r)
                {
                    r -= k;
                    k /= 2;
                }
                r += k;
            }
            return x;
        }

    }
}
