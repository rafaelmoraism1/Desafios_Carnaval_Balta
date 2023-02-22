namespace Desafio1_Carnaval
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto que eu irei contar quantos caracteres possui e quantas palavras:");

            string? texto = Console.ReadLine();
            int caracteres = texto.Length;
            int palavras = texto.Split(' ').Length;

            Console.WriteLine($"Seu texto possui {caracteres} caracteres e {palavras} palavras!");
            Console.WriteLine("================================================================");

        }
    }
}
