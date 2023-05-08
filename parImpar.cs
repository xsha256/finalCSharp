using System;
using static System.Console;

namespace parImpar
{
    public class ParImpar
    {
        public static void par()
        {
            Write("Intoduce un número: ");
            String? input = ReadLine();

            if (int.TryParse(input, out int num))
            {
                WriteLine($"Tipo de num: {num.GetType()}");

                if (num % 2 == 0)
                {
                    WriteLine($"El número {num} es par");
                }
                else
                {
                    WriteLine($"El número {num} es impar");
                }
            }
            else
            {
                WriteLine($"{input} no es un número");
            }
        }

    }
}