using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnDoeEjercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius, fahrenheit, mayorTemperatura;
            double promedio=0;
            
            int cantidadX;
           
            do
            {
                Console.Write("Ingrese la cantidad de temperaturas a evaluar:");
                if (!int.TryParse(Console.ReadLine(),out cantidadX))
                {
                    Console.WriteLine("Cantidad mal ingresada");

                }
                else if (cantidadX<=0 || cantidadX>20)
                {
                    Console.WriteLine("La cantidad debe ser positiva e inferior o igual a 20");
                }
                else
                {
                    break;
                }
            } while (true);


            mayorTemperatura = -71;
            for (int contador = 0; contador < cantidadX; contador++)
            {
                do
                {
                    Console.Write($"Ingrese la temperatura {contador+1}:");
                    if (!double.TryParse(Console.ReadLine(), out celsius))
                    {
                        Console.WriteLine("Cantidad mal ingresada");
                    }
                    else if (celsius < -70 || celsius > 60)
                    {
                        Console.WriteLine("La temp debe estar en el rango -70 y 60 grados");
                    }
                    else
                    {
                        break;//me saca del ciclo;
                    }

                } while (true);

                fahrenheit = ConvertirFahrenheit(celsius);
                Console.WriteLine($"{celsius} equivalen a {fahrenheit} grados F");
                if (celsius>mayorTemperatura)
                {
                    mayorTemperatura = celsius;
                }

                promedio += celsius;
            }

            promedio /= cantidadX;
            Console.WriteLine($"La mayor temperatura es {mayorTemperatura}");
            Console.WriteLine($"La media de temperatura es {promedio}");
            Console.ReadLine();

        }

        private static double ConvertirFahrenheit(double grados)
        {
            return 1.8 * grados + 32;
        }
    }
}
