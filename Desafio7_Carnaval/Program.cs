namespace Desafio7_Carnaval
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine(" 1");
            Console.WriteLine(" 1 1");
            Console.WriteLine(" 1 1 2");
            List<int> fibonacci = new List<int>() { 1, 2 };
            string sequencia = " 1 1 2";

            for (int valor = 1; valor != 35; valor++)
            {
                fibonacci.Add(fibonacci[valor] + fibonacci[valor - 1]);
                sequencia += ($" {fibonacci[valor] + fibonacci[valor - 1]}");
                Console.WriteLine($"{sequencia}");
            }


        }
    }
}