using static System.Console;

namespace ordenarLista
{
    public class OrdenarLista
    {
        public static void ordenar()
        {
            List<string> nombres = new List<string>();
            Write("Ingrese nombres separado con espacios: ");
            string? input = ReadLine();
            if (input == null)
            {
                WriteLine("Número inválido");
                return;
            }
            string[]? nombresLista = input.Split();

            nombres.AddRange(nombresLista);
            nombres.Sort();

            WriteLine("Lista ordenada alfabéticamente:");

            foreach (string nombre in nombres)
            {
                WriteLine(nombre);
            }
        }
    }
}