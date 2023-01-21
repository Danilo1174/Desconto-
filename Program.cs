using System;

namespace AtividadeDesconto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("infome o nome  produto: ");
            string nome = Console.ReadLine();
            Console.WriteLine("informe o preco do produto: ");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("informe a quantidade que foram compradas: ");
            int quantidade = int.Parse(Console.ReadLine());

            Desconto produto = new Desconto(nome, preco, quantidade);


            produto.MostarDesconto();


        }
    }
}
