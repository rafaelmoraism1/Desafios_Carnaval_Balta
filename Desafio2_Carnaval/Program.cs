namespace Desafio2_Carnaval
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Vamos Calcular seu ICM!");
            Console.WriteLine("Obs: Peso em Kg => Ex: 72 / Altura em metros => Ex: 1,70");
            Console.WriteLine("========================================================");

            Console.WriteLine("Digite seu PESO (kg): ");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Digite sua ALTURA (m): ");
            double altura = double.Parse(Console.ReadLine());
            double calculoImc = peso / (altura * altura);
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine($"-> Seu IMC é {calculoImc.ToString("F2")} Kg/m2");

            switch (calculoImc)
            {
                case < 16: Console.WriteLine("-> Magreza Grau III"); break;
                case < 16.9: Console.WriteLine("-> Magreza Grau II"); break;
                case < 18.4: Console.WriteLine("-> Magreza Grau I"); break;
                case < 24.9: Console.WriteLine("-> Eutrofia"); break;
                case < 29.9:
                    Console.WriteLine("-> Sobrepeso");
                    Console.WriteLine("-> Risco: Aumentado");
                    break;
                case < 34.9:
                    Console.WriteLine("-> Obesidade Grau I");
                    Console.WriteLine("-> Risco: Moderado");
                    break;
                case < 40:
                    Console.WriteLine("-> Obesidade Grau II");
                    Console.WriteLine("-> Risco: Grave");
                    break;
                default:
                    Console.WriteLine("-> Obesidade Grau III");
                    Console.WriteLine("-> Risco: Muito Grave");
                    break;
            }
            Console.WriteLine("");
        }

    }

}