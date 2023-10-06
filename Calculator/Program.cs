using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator {
    internal class Program {
        static void Main(string[] args) {
            //Lê o primeiro número do cálculo;
            Console.WriteLine("Informe o primeiro número do cálculo:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            //Lê o segundo número do cálculo;
            Console.WriteLine("Informe o segundo número do cálculo:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //Imprime na tela as opções;
            Console.WriteLine("Informe a operação do calculo:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            //Lê a opção do usuário
            int op = Convert.ToInt32(Console.ReadLine());
            
            //Declara variável que irá armazenar o resultado;
            float resultado = 0;

            //Instância a Calculadora;
            Calculadora calc = new Calculadora();
            
            switch (op) {
                case 1:
                    //Caso de soma
                    resultado = calc.Somar(num1, num2);
                    break;
                case 2:
                    //Caso de subtração
                    resultado = calc.Subtrair(num1, num2);
                    break;
                case 3:
                    //Caso de multiplicação
                    resultado = calc.Multiplicar(num1, num2);
                    break;
                case 4:
                    //Caso de divisão
                    resultado = calc.Dividir(num1, num2);
                    break;

            }
            //Imprime resultado
            Console.WriteLine("Resultado:" + resultado);
        }
    }
}
