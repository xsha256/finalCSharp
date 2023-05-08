using static System.Console;
namespace mediaLista
{
    public class MediaLista
    {
        public static void media()
        {
            Write("Introduce una lista de números separados por espacios: ");
            string? input = ReadLine();

            string[]? numeros = input.Split();
            WriteLine(string.Join(", ", numeros));
             int[] numerosInt = Array.ConvertAll(numeros, s => int.Parse(s));


            double media = numerosInt.Average();
            WriteLine("La media es: " + media);

        }

    }

}
