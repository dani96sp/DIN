using System;

namespace EJER2 {
    class Program {
        static void Main(string[] args) {

            int numero;
            Console.Write("Introduce un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());


            /*
            bool positivo = numero > 0;

            bool negativo = numero < 0;


            if (negativo) {
                Console.WriteLine("El numero es negativo");
            } else if (positivo) {
                Console.WriteLine("El numero es positivo");
            } else {
                Console.WriteLine("El numero es un cero");
            }
            */
            /*
            bool positivo = numero > 0 ? true : false;
            bool negativo = numero < 0 ? true : false;

            */


            if ((numero >= 10) && (numero <=20)) {
                Console.WriteLine("El numero esta entre 10 y 20");
            }




            Console.ReadLine();

        }
    }
}
