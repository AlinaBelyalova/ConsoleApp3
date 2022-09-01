using Square;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Cmplx
    {
        #region Конструкторы
        public Cmplx()
        {
            this.re = 0;
            this.Im = 0;
        }
        public Cmplx(double re)
        {
            this.re = re;
            this.Im = 0;
        }
        public Cmplx(double re, double im)
        {
            this.re = re;
            this.Im = im;
        }
        #endregion

        #region Поля
        private double re;
        private double im;
        #endregion

        #region Свойства
        public double Re
        {
            get
            {
                return re;
            }
            set
            {
                this.re = value;
            }
        }

        public double Im { get => im; set => im = value; }

        public double R
        {
            get
            {
                double R = Math.Sqrt(Math.Pow(re, 2) + Math.Pow(im, 2));
                return R;
            }

        }
        public double Phi
        {
            get
            {
                double Phi;
                if (re == 0 & im != 0)
                {
                    if (im > 0)
                    {
                        Phi = Math.Atan(double.PositiveInfinity);
                    }
                    else
                    {
                        Phi = Math.Atan(double.NegativeInfinity);
                    }
                }
                else
                {
                    Phi = Math.Atan(im / re);
                }



                return Phi;
            }

        }
        #endregion

        public override string ToString() 
        {
            return $"Re = {this.Re}. Im = {this.Im}, R = {this.R}, Phi = {this.Phi}";
        }

        #region Перегрузка операторов
        public static Cmplx operator +(Cmplx a, Cmplx b)
        => new Cmplx(a.Re + b.Re, a.Im + b.Im);
        public static Cmplx operator -(Cmplx a, Cmplx b)
        => new Cmplx(a.Re + (-b.Re), a.Im + (-b.Im));
        public static Cmplx operator *(Cmplx a, Cmplx b)
        => new Cmplx(a.Re * b.Re - a.Im * b.Im, a.Re * b.Im - b.Re * a.Im);
        public static Cmplx operator /(Cmplx a, Cmplx b)
        => new Cmplx((a.Re * b.Re + a.Im * b.Im) / (Math.Pow(b.Re, 2) + Math.Pow(b.Im, 2)), (b.Re * a.Im - a.Re * b.Im) / (Math.Pow(b.Re, 2) + Math.Pow(b.Im, 2)));
        //public Cmplx Sqr()
        //{
        //    return new Cmplx(this.Re * this.Re - this.Im * this.Im, 2 * this.Re * this.Im);
        //}
        #endregion

        #region Тест
        public static Cmplx Summ(Cmplx a, Cmplx b)
        {
            return new Cmplx(a.Re + b.Re, a.Im + b.Im);
        }
        public static Cmplx Diff(Cmplx a, Cmplx b)
        {
            return new Cmplx(a.Re + (-b.Re), a.Im + (-b.Im));
        }
        public static Cmplx Mult(Cmplx a, Cmplx b)
        {
            return new Cmplx(a.Re * b.Re - a.Im * b.Im, a.Re * b.Im - b.Re * a.Im);
        }
        public static Cmplx Div(Cmplx a, Cmplx b)
        {
            return new Cmplx((a.Re * b.Re + a.Im * b.Im) / (Math.Pow(b.Re, 2) + Math.Pow(b.Im, 2)), (b.Re * a.Im - a.Re * b.Im) / (Math.Pow(b.Re, 2) + Math.Pow(b.Im, 2)));
        }
        public Cmplx Sqr()
        {
            return new Cmplx(this.Re * this.Re - this.Im * this.Im, 2 * this.Re * this.Im);
        }
        public Cmplx Sqrt()
        {
            char k = 'k';
            return new Cmplx(Math.Sqrt(this.R) * (Math.Cos((this.Phi + 2 * Math.PI * k) / 2)), Math.Sqrt(this.R) * Math.Sin((this.Phi + 2 * Math.PI * k) / 2));
        }
        #endregion 
    }
}
