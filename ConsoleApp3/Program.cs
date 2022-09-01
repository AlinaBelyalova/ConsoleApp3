using ConsoleApp3;
using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Square
{
    class Class1
    {
        static void Main(string[] args)
        {
            
            Cmplx a = new Cmplx(2.0, 3.0);
            Cmplx b = new Cmplx(1.0, 2.0);


            //Cmplx c = Cmplx.Summ(a, b);
            //Cmplx d = Cmplx.Diff(a, b);
            //Cmplx e = Cmplx.Mult(a, b);
            //Cmplx g = a.Sqr();
            //Cmplx t = a.Sqrt();


            Console.WriteLine(a+b);
            Console.WriteLine(a-b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
        }
    }
}


