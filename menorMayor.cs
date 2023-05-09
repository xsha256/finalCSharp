using static System.Console;

namespace menorMayor
{
    public class MenorMayor
    {
        public void menor()
        {

            Write("Introduce una lista de números separados por espacios: ");
            string? input = ReadLine();
            if (input == null)
            {
                WriteLine("Número inválido");
                return;
            }

            string[] numeros = input.Split();
            WriteLine(string.Join(", ", numeros));

            int mayor = int.MinValue;
            int menor = int.MaxValue;
            bool numeroInvalido = false;

            foreach (string numero in numeros)
            {

                if (int.TryParse(numero, out int num))
                {
                    if (num > mayor)
                    {
                        mayor = num;
                    }
                    if (num < menor)
                    {
                        menor = num;
                    }
                }

                else
                {
                    WriteLine("Número inválido");
                    numeroInvalido = true;
                    break;
                }
            }

            if (!numeroInvalido)
            {
                WriteLine($"El número mayor es: {mayor}");
                WriteLine($"El número menor es: {menor}");
            }

        }

    }
}