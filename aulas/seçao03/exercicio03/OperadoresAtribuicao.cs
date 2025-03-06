using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            Console.WriteLine("----------------");

            // Operador de atribuição " += " funcionando em strings

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);

            Console.WriteLine("----------------");

            // Operadores aritméticos / atribuiçao

            int b = a++; // " a++ " primeiro ele vai jogar o valor do A para o B (36), e depois incrementar 1, para ficar 37, valor do A é 37
            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine("----------------");

            int bb = ++a; // " ++a " primeiro ele incrementa 1 a variavel A e depois atribui o valor para a variavel bb
            Console.WriteLine(a);
            Console.WriteLine(bb);

        }
    }
}