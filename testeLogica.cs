using System;

class testeLogica {
    static void Main(string[] args) {
        
        int cod1, cod2, qtd1, qtd2;
        double preco1, preco2;
        
        Console.WriteLine("digite o primeiro produto");
        cod1 = int.Parse(Console.ReadLine());
        qtd1 = int.Parse(Console.ReadLine());
        preco1 = double.Parse(Console.ReadLine());

        Console.WriteLine("digite o segundo produto");
        cod2 = int.Parse(Console.ReadLine());
        qtd2 = int.Parse(Console.ReadLine());
        preco2 = double.Parse(Console.ReadLine());

        double total =  (qtd1 * preco1) + (qtd2 * preco2);
        total = total / 100;

        Console.WriteLine("O valor total a pagar é: " + total.ToString("F2"));

    }
}