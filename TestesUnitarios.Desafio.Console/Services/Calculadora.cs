using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestesUnitarios.Desafio.Console.Services
{
    public class Calculadora
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public int Dividir(int a, int b)
        {
            if (b == 0)
            {
                throw new System.DivideByZeroException("Divisão por zero não permitida.");
            }
            return a / b;
        }
}

}
