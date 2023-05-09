using static System.Console;

public class Program
{
    public static void Main()
    {
        bool salir = false;

        while (!salir)
        {  
            WriteLine("╔══════════════════════════════════════════════════╗");
            WriteLine("║                  Menú Principal                  ║");
            WriteLine("╠═════════╦════════════════════════════════════════╣");
            WriteLine("║ Opción  ║             Descripción                ║");
            WriteLine("╠═════════╬════════════════════════════════════════╣");
            WriteLine("║    1    ║        Numero menor y mayor            ║");
            WriteLine("║    2    ║          Numero par o impar            ║");
            WriteLine("║    3    ║           Año bisiesto o no            ║");
            WriteLine("║    4    ║           Palindromo o no              ║");
            WriteLine("║    5    ║            Ordenar una lista           ║");
            WriteLine("║    6    ║               Factorial                ║");
            WriteLine("║    7    ║          Numero primo o no             ║");
            WriteLine("║    8    ║           Calcular área y perímetro    ║");
            WriteLine("║    9    ║          Suma de números pares         ║");
            WriteLine("║    10   ║       Identificar número positivo      ║");
            WriteLine("║         ║             o negativo                 ║");
            WriteLine("║    11   ║              Media lista               ║");
            WriteLine("║    12   ║            Adivinar número             ║");
            WriteLine("║    13   ║                Anagrama                ║");
            WriteLine("║    14   ║            Eliminar duplicados         ║");
            WriteLine("║    15   ║                Capicúa                 ║");
            WriteLine("║    0    ║                  Salir                 ║");
            WriteLine("╚═════════╩════════════════════════════════════════╝");


            Write("Ingrese el número de opción: ");
            string? opcionStr = ReadLine();

            int opcion;

            if (!int.TryParse(opcionStr, out opcion))
            {
                WriteLine("Ingrese un número válido.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    new menorMayor.MenorMayor().menor();

                    break;
                case 2:
                    new parImpar.ParImpar().par();

                    break;
                case 3:
                    new anyoBisiesto.AnyoBisiesto().anyo();

                    break;
                case 4:
                    new palindromo.Palindromo().palindromo();

                    break;
                case 5:
                    new ordenarLista.OrdenarLista().ordenar();

                    break;
                case 6:
                    new factorial.Factorial().fact();

                    break;
                case 7:
                    new primo.Primo().primo();

                    break;
                case 8:
                    new cubo.Cubo().cubo();

                    break;
                case 9:
                    new sumaNumerosPares.SumaNumerosPares().suma();

                    break;
                case 10:
                    new numPosNeg.NumPosNeg().numPos();

                    break;
                case 11:
                    new mediaLista.MediaLista().media();

                    break;
                case 12:
                    new adivinarNum.AdivinarNumero().adivinar();

                    break;
                case 13:
                    new anagrama.Anagrama().anagrama();

                    break;
                case 14:
                    new eliminarDuplicados.EliminarDuplicados().eliminar();

                    break;
                case 15:
                    new capicua.Capicua().capicua();
                    break;
                case 0:
                    WriteLine("Saliendo del programa...");
                    salir = true;
                    break;
                default:
                    WriteLine("Opción no válida.");
                    break;
            }
            WriteLine("Presione cualquier tecla para continuar.");
            ReadKey();
            Clear();
        }
    }
}

