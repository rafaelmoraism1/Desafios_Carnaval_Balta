using System.Text;

namespace Desafio4_Carnaval
{
    class Program
    {
        static readonly double[] cedulas = { 200, 100, 50, 20, 10, 5, 2, 1 };
        static void Main(string[] args)
        {
            Console.Write("-> Valor da Compra: R$ ");
            double.TryParse(Console.ReadLine(), out double valorCompra);
            Console.Write("-> Valor do Pagamento: R$ ");
            double.TryParse(Console.ReadLine(), out double pagamento);
            var troco = pagamento - valorCompra;
            var dinheiro = DarTroco(troco);
            Console.WriteLine($"- Troco: \n{dinheiro}");
        }

        static string DarTroco(double troco)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var cedula in cedulas)
            {
                int quantidade = (int)(troco / cedula);
                if (quantidade > 0)
                {
                    troco -= (quantidade * cedula);
                    sb.Append($"   - {quantidade} nota de {cedula} reais\n");
                }
            }
            return sb.ToString();
        }
    }

}
