namespace Desafio6_Carnaval
{
    public class Program
    {

        public static void Main(string[] args)
        {
            string[] array = new string[] {"d","&","f","g","h","!","j","k","l","m","n","*","p",
                                            "q","r","s","t","#","v","x","y","w","z","%","b","c" };

            Console.Clear();
            Console.WriteLine("Digite seu texto: ");
            var texto = Console.ReadLine().ToUpper();
            var criptografia = texto.Replace("A", array[0])
            .Replace("B", array[1]).Replace("C", array[2])
            .Replace("D", array[3]).Replace("E", array[4]).Replace("F", array[5])
            .Replace("G", array[6]).Replace("H", array[7]).Replace("I", array[8])
            .Replace("J", array[9]).Replace("K", array[10]).Replace("L", array[11])
            .Replace("M", array[12]).Replace("N", array[13]).Replace("O", array[14]).Replace("P", array[15])
            .Replace("Q", array[16]).Replace("R", array[17]).Replace("S", array[18]).Replace("T", array[19])
            .Replace("U", array[20]).Replace("V", array[21]).Replace("X", array[22]).Replace("Y", array[23])
            .Replace("W", array[24]).Replace("Z", array[25]);
            Console.WriteLine(criptografia);








        }
    }
}