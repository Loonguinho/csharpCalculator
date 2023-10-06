using System;

namespace Calculator {
    internal class Calculadora {
        public int Somar(int x, int y) {
            return x + y;
        }

        public int Subtrair(int x, int y) {
            return x - y;
        }

        public float Multiplicar(int x, int y) {
            return x * y;
        }

        public float Dividir(int x, int y) {
            
            float resultado = 0;
            try {
                resultado = x / y;
            }
            catch (DivideByZeroException e) {
                Console.WriteLine(e);
            }

            return resultado;
        }
    }
}
