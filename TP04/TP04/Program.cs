using System;

namespace TP04
{
    public class Pagamento
    {
        public decimal Valor { get; set; }

        public Pagamento(decimal valor)
        {
            this.Valor = valor;
        }

        public virtual void ProcessarPagamento()
        {
            Console.WriteLine("O pagamento será processado.");
        }
    }

    public class Boleto : Pagamento
    {
        public Boleto(decimal valor) : base(valor) { }

        public override void ProcessarPagamento()
        {
            decimal valorFinal = Valor * 0.90m; // 10% de desconto
            Console.WriteLine($"Valor original: R$ {Valor:F2}. Pagamento via Boleto com 10% de desconto: R$ {valorFinal:F2}");
        }
    }

    public class CartaoCredito : Pagamento
    {
        public CartaoCredito(decimal valor) : base(valor) { }

        public override void ProcessarPagamento()
        {
            Console.WriteLine($"Pagamento via Cartão de Crédito sem desconto. Valor total: R$ {Valor:F2}");
        }
    }

    public class Pix : Pagamento
    {
        public Pix(decimal valor) : base(valor) { }

        public override void ProcessarPagamento()
        {
            decimal valorFinal = Valor * 0.85m; // 15% de desconto
            Console.WriteLine($"Valor original: R$ {Valor:F2}. Pagamento via PIX com 15% de desconto: R$ {valorFinal:F2}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Pagamento boleto = new Boleto(5000);
            Pagamento cartao = new CartaoCredito(3000);
            Pagamento pix = new Pix(1500);

            boleto.ProcessarPagamento();
            cartao.ProcessarPagamento();
            pix.ProcessarPagamento();

            Console.ReadKey();
        }
    }
}
