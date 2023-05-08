using static System.Console;
namespace adivinarNum
{
    public class AdivinarNumero
    {
        public static void adivinar()
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 101);
            int intentos = 0;
            int numeroUsuario = 0;
            WriteLine(numeroAleatorio);
            while (numeroUsuario != numeroAleatorio)
            {
                WriteLine("Adivina el número (entre 1 y 100):");
                if (!int.TryParse(ReadLine(), out numeroUsuario))
                {
                    WriteLine("Número invalido");
                    continue;
                }
                intentos++;

                if (numeroUsuario < numeroAleatorio)
                {
                    WriteLine("El número introducido es menor que el número aleatorio.");
                }
                else if (numeroUsuario > numeroAleatorio)
                {
                    WriteLine("El número introducido es mayor que el número aleatorio.");
                }
            }

            WriteLine($"¡Has acertado el número en{intentos} intentos!");
        }

    }

}