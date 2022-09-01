using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Manager
    {

        // конструктор
        public Manager(Calculator calc)
        {
            this.calc = calc;
        }

        // поля

        private Calculator calc;

        // свойства

        public Calculator Calc
        {
            set
            {
                this.calc = value;
            }
        }

        // методы
        public void InputCoefs()
        {
            this.calc.GetAbc();
        }

        public void Solve()
        {
            this.calc.StartSolve();
        }

        public void PushOnStartButton()
        {
            this.calc.StartX2Solve();
        }
    }
}
