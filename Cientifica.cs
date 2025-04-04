using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public partial class Calculadora
    {
        public double Raiz(double num)
        {
            return Math.Sqrt(num);
        }

        public double Quadrado(double num)
        {
            return Math.Pow(num, 2);
        }

        public double Pi()
        {
            return Math.PI;
        }
    }

}
