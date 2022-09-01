using ConsoleApp3;

namespace ConsoleApp3
{
    public class Calculator
    {
        // конструктор
        public Calculator()
        {
            this.coefs = new double[3];
            this.x = new double[2];
            this.iscomplex = false;
        }

        public Calculator(double[] coefs)
        {
            this.coefs = coefs;
            this.x = new double[2];
            this.iscomplex = false;
        }

        // поля

        private double[] coefs;


        private double[] x;

        private bool iscomplex;

        // свойства
        public double[] Coefs
        {
            get
            {
                return coefs;
            }
            set
            {
                this.coefs = value;
            }
        }


        // методы

        public void GetAbc()
        {
            Console.WriteLine("Press a:");
            this.Coefs[0] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Press b:");
            this.Coefs[1] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Press c:");
            this.Coefs[2] = Convert.ToDouble(Console.ReadLine());
        }

        private void Solve()
        {
            double D;

            D = Coefs[1] * Coefs[1] - 4 * Coefs[0] * Coefs[2];

            if (D < 0)
            {
                this.iscomplex = true;
                x[0] = Math.Sqrt(D * (-1)) / 2 / Coefs[0];
                x[1] = -Coefs[0] / 2 / Coefs[1];

            }
            else if (D == 0)
            {
                x[0] = x[1] = -Coefs[1] / 2 / Coefs[0];

            }
            else
            {
                x[0] = -Coefs[1] + Math.Sqrt(D) / 2 / Coefs[0];
                x[1] = -Coefs[1] - Math.Sqrt(D) / 2 / Coefs[0];

            }
        }

        public void StartSolve()
        {
            this.Solve();
            this.PrintSolution();
        }

        private void PrintSolution()
        {
            if (iscomplex)
            {
                Console.WriteLine("х1 = " + x[1] + " + i*" + x[0] + "\tx2 = " + x[1] + " - i*" + x[0]);
            }
            else
            {
                if (x[0] == x[1])
                {
                    Console.WriteLine("х1 = x2 = {0}", x[0]);
                }
                else
                {
                    Console.WriteLine($"х1 = {x[0]}, x2 = {x[1]}");
                }

            }

        }

        public void StartX2Solve()
        {
            Console.WriteLine("Введите коэффициенты a, b, и c");
        }
    }
}