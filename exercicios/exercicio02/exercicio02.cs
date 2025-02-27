using System;

namespace Program {
    class raio {
        static void Main(string[] args) {

            double pi = 3.14159;
            double raio;

            Console.WriteLine("calculadora de area de circulo");
            Console.WriteLine("Qual é o raio do circulo");

            raio = Convert.ToDouble(Console.ReadLine());

            double calculo = pi * raio * raio;
            calculo = calculo / 10000;

            Console.WriteLine("a area do circulo é: " + calculo.ToString("F4"));

        }
    }
}