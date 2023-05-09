using static System.Console;
namespace capicua
{
    public class Capicua
    {
        public  void capicua()
        {
            Write("Ingresa un número: ");
            int num = 0;
            if (!int.TryParse(ReadLine(), out num))
            {
                WriteLine("Número invalido");
                return;
            }
            int originalNum = num;
            int reversedNum = 0;

            while (num > 0)
            {
                int digit = num % 10;
                reversedNum = (reversedNum * 10) + digit;
                num /= 10;
            }

            if (originalNum == reversedNum)
            {
                WriteLine("El número es capicúa.");
            }
            else
            {
                WriteLine("El número no es capicúa.");
            }
        }

    }
}
