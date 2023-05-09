using System;
using static System.Console;

namespace anyoBisiesto
{
    public class AnyoBisiesto
    {
        public void anyo()
        {
            Write("Ingrese un año: ");
            int anio = 0;
            if (int.TryParse(ReadLine(), out anio))

                if ((anio % 4 == 0 && anio % 100 != 0) || anio % 400 == 0)
                {
                    WriteLine(anio + " es un año bisiesto");
                }
                else
                {
                    WriteLine(anio + " no es un año bisiesto");
                }
            else
                WriteLine("Ha entrado un año incorrecto");
        }
    }
}