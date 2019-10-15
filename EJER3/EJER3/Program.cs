using System;

namespace EJER3
{
    class Program
    {
        static void Main(string[] args)
        {
            int intN1;
            Console.Write("Introduce un numero: ");

            intN1 = Convert.ToInt32(Console.ReadLine());

            switch (intN1) {
                case 1:
                    Console.WriteLine("UNO");
                    break;
                default:
                    Console.WriteLine("No se que numero es");
                    break;

            }
            Console.ReadLine();
        }
    }
}
