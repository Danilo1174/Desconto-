namespace AtividadeDesconto
{
    using System;
    class Desconto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
        





        public Desconto(string nome, double preco, int quantidade)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;



        }
        public double CalculoFinal() => this.Quantidade * this.Preco;

        public double Total() => CalculoFinal();


        public void MostarDesconto()
        {


            if (this.Quantidade >= 11 && this.Quantidade <= 20)
            {
                Console.WriteLine($"o valor a ser pago com desconto de 10%: {Total() - (0.1 * CalculoFinal())  }" );

            }
            if (this.Quantidade >= 21 && this.Quantidade <= 50)
            {
                Console.WriteLine($"o valor a ser pago com desconto de 20%: {Total() - (0.2 * CalculoFinal())} " );
            }
            if (this.Quantidade > 50)
            {
                Console.WriteLine($"o valor a ser pago com desconto de 25%: {Total() - (0.25 * CalculoFinal()) }" );
                
            }
            if (this.Quantidade <= 10)
            {
              Console.WriteLine("o valor a ser pago é: " + Total());
            }

        }
    }
}
