using static System.Console;

namespace sumaNumerosPares
{
    public class SumaNumerosPares
    {
        public static void suma()
        {

            int suma = 0;
            Write("Introduce una lista de números separados por espacios: ");
            string? input = ReadLine();

            string[] numeros = input.Split();
            WriteLine(string.Join(", ", numeros));

            foreach (string numero in numeros)
            {
                if (int.TryParse(numero, out int num))
                {
                    if (num % 2 == 0)
                        suma += num;
                }

            }

            WriteLine($"La suma de los números pares es {suma}" );

            ReadKey();
        }
    }
}