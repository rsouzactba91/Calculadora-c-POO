using System;

namespace WinFormsApp1
{
    public partial class Calculadora
    {
        public string Resultado { get; set; }

        public void Somar(string a, string b)
        {
            Resultado = Convert.ToString(Convert.ToDouble(a) + Convert.ToDouble(b));
        }

        public void Subtrair(string a, string b)
        {
            Resultado = Convert.ToString(Convert.ToDouble(a) - Convert.ToDouble(b));
        }

        public void Multiplicar(string a, string b)
        {
            Resultado = Convert.ToString(Convert.ToDouble(a) * Convert.ToDouble(b));
        }

        public void Dividir(string a, string b)
        {
            double divisor = Convert.ToDouble(b);
            if (divisor == 0)
                throw new DivideByZeroException("Divisão por zero não é permitida.");

            Resultado = Convert.ToString(Convert.ToDouble(a) / divisor);
        }

        public void Operar(string a, string b, string operacao)
        {
            switch (operacao)
            {
                case "somar":
                    Somar(a, b);
                    break;
                case "subtrair":
                    Subtrair(a, b);
                    break;
                case "multiplicar":
                    Multiplicar(a, b);
                    break;
                case "dividir":
                    Dividir(a, b);
                    break;
                default:
                    throw new InvalidOperationException("Operação inválida.");
            }
        }
    }
}
