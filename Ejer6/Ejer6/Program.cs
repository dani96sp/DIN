using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pasar parametros por referencia
            /*
            int param = 1;
            Console.WriteLine("Main: " + param);

            Poreferencia(ref param);


            Console.WriteLine("Main: " + param);

    */


            // Potencia
            Console.WriteLine("Programa que calcula la potencia de un numero pasando el numero y la potencia.");
            Console.WriteLine("Inserta el numero.");

            double numero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Programa que calcula la potencia de un numero pasando el numero y la potencia.");

            double potencia = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("El resultado con nuestro metodo es: {0}", calcularPotencia(numero, potencia));

            Console.WriteLine("El resultado con el metodo Math.Pow() es: {0}", Math.Pow(numero, potencia));
            
            Console.ReadLine();
        }


        static double calcularPotencia(double num, double potencia)
        {
            double resultado = 1;
            for(int i = 1; i<=potencia; i++) {
                resultado = resultado * num;
            }
            return resultado;
        }








        static void Poreferencia(ref int intPara2)
        {
            intPara2 = intPara2 + 1;
            Console.WriteLine("Poreferencia: " + intPara2);
        }





        static void mostrar(string dato)
        {
            Console.WriteLine(dato);
            Console.WriteLine("sin la funcion vale: {0}", dato);
        }

        static void convalor(int intPara1)
        {
            intPara1 = intPara1 + 1;
            Console.WriteLine("Desde la funcion vale: {0}", intPara1);

        }


    }



}
