using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            float x = 4.5f; // conversao implicita de tipos
            double y = x;

            Console.WriteLine(y);

            y = 4.5;
            x = (float)y; // casting, valor double ( 8 bytes ) em um float ( 4 bytes )

            Console.WriteLine(x);

            double b = 1.0;
            int c;

            c = (int)b;

            Console.WriteLine(c);

            c = 5;
            int d = 2;

            double resultado = (double)c / d;

            Console.WriteLine(resultado);

        }
    }
}