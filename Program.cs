﻿using static System.Console;
using menorMayor;
using parImpar;


public class Program
{
    public static void Main()
    {
        bool salir = false;

        while (!salir)
        {
            WriteLine("*********** Menú Principal ***********");
            WriteLine("1. Numero menor mayor");
            WriteLine("2. Numero par o impar");
            WriteLine("3. Año bisiesto o no");
            WriteLine("4. Palindromo o no");
            WriteLine("5. Ordenar una lista");
            WriteLine("6. Factorial");
            WriteLine("7. Numero primo o no");
            WriteLine("8. Area perimetro");
            WriteLine("9. Suma numeros pares");
            WriteLine("10. Numero negativo o positivo");
            WriteLine("11. Media lista");
            WriteLine("12. Adivinar numero");
            WriteLine("13. Anagrama");
            WriteLine("14. Eliminar duplicados");
            WriteLine("15. Capicua");
            WriteLine("0. Salir");

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
                    MenorMayor.menor();

                    break;
                case 2:
                    ParImpar.par();

                    break;
                case 3:
                    anyoBisiesto.AnyoBisiesto.anyo();

                    break;
                case 4:
                    palindromo.Palindromo.palindromo();

                    break;
                case 5:
                    ordenarLista.OrdenarLista.ordenar();

                    break;
                case 6:
                    factorial.Factorial.fact();

                    break;
                case 7:
                    primo.Primo.primo();

                    break;
                case 8:
                    cubo.Cubo.cubo();

                    break;
                case 9:
                    sumaNumerosPares.SumaNumerosPares.suma();

                    break;
                case 10:
                    numPosNeg.NumPosNeg.numPos();

                    break;
                case 11:
                    mediaLista.MediaLista.media();

                    break;
                case 12:
                    adivinarNum.AdivinarNumero.adivinar();

                    break;
                case 13:
                    anagrama.Anagrama.anagrama();

                    break;
                case 14:
                    eliminarDuplicados.EliminarDuplicados.eliminar();

                    break;
                case 15:
                    capicua.Capicua.capicua();
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
