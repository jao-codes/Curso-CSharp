using System;
using System.Globalization;

namespace Course {
    class SaidaDeDados {
        static void Main(string[] args) {

            CultureInfo myCIintl = new CultureInfo("pt-BR", false); // Cria e inicializa o CultureInfo que usa a classificação internacional.

            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "João";


            Console.WriteLine("-------------------");
            Console.WriteLine("Exemplo de saida de dados");

            Console.Write("Bom dia");
            Console.WriteLine("Boa tarde");       
            Console.WriteLine("Boa noite");     

            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("--------------------");

            // Placeholders, concatenação

            // Placeholder
            Console.WriteLine("Exemplo de placeholder");

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);
            Console.WriteLine("--------------------");
            Console.WriteLine("Exemplo de concatenação");

            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");

        }
    }
}