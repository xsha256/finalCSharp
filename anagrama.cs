using static System.Console;
namespace anagrama
{
    public class Anagrama
    {
        public static void anagrama()
        {
            WriteLine("Introduce la cadena 1: ");
            string? palabra1 = ReadLine();
            if (palabra1 == null)
            {
                WriteLine("Palabra inválida");
                return;
            }
            WriteLine("Introduce la cadena 1: ");
            string? palabra2 = ReadLine();
            if (palabra2 == null)
            {
                WriteLine("Palabra inválida");
                return;
            }



            char[] letras1 = palabra1.ToLower().ToCharArray();
            char[] letras2 = palabra2.ToLower().ToCharArray();

            Array.Sort(letras1);
            Array.Sort(letras2);

            bool sonAnagramas = letras1.SequenceEqual(letras2);

            if (sonAnagramas)
            {
                WriteLine(palabra1 + " y " + palabra2 + " son anagramas.");
            }
            else
            {
                WriteLine(palabra1 + " y " + palabra2 + " no son anagramas.");
            }
        }
    }

}