using static System.Console;
namespace eliminarDuplicados
{
    public class EliminarDuplicados
    {
        public static void eliminar()
        {

            Write("Introduce una lista de números separados por espacios: ");
            string? input = ReadLine();
            if (input == null)
            {
                WriteLine("Numero inválido");
                return;
            }
            string[]? numeros = input.Split();
            WriteLine(string.Join(", ", numeros));
            int[] numerosInt = Array.ConvertAll(numeros, s => int.Parse(s));

            List<int> numerosSinDuplicados = new List<int>();

            foreach (int numero in numerosInt)
            {
                if (!numerosSinDuplicados.Contains(numero))
                {
                    numerosSinDuplicados.Add(numero);
                }
            }

            WriteLine($"Números originales: {string.Join(", ", numerosInt)}");
            WriteLine($"Números no duplicados: {string.Join(", ", numerosSinDuplicados)}");
        }

    }

}
