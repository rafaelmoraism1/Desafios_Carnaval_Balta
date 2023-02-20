namespace Desafio3_Carnaval
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Vamos verificar qual a opção mais vantajosa de combustível para abastecer!");
            Console.WriteLine("--->Proporção abaixo de 70% - Etanol / Proporção acima de 70% - Gaolina");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Digite o valor da GASOLINA (R$): ");
            decimal gasolina = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do ETANOL(R$): ");
            decimal etanol = decimal.Parse(Console.ReadLine());
            decimal calculo = (etanol / gasolina) * 100;
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine($"A proporção é de {calculo.ToString("F2")}%");
            Console.WriteLine("--------------------------------------------------------------------------");

            switch (calculo)
            {
                case < 70: Console.WriteLine("Com base nos valores, o ETANOL é a melhor opção!"); break;
                default: Console.WriteLine("Com base nos valores, a GASOLINA é a melhor opção!"); break;
            }
            Console.WriteLine("--------------------------------------------------------------------------");


        }
    }
}