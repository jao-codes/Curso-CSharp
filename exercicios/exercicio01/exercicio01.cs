using System;

namespace Program {
    class calculadora {
        static void Main(string[] args) {
            
            int num1, num2, soma;

            Console.WriteLine("Escreva o primeiro numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escreva o segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            soma = num1 + num2;

            Console.WriteLine("SOMA = " + soma);

        }
    }
}