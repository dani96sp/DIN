using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer5
{
    class Program
    {
        // Variables globales
        struct tipoPersona
        {
            public string nombre;
            public char inicial;
            public int edad;
            public float nota;
        }

        static void Main(string[] args)
        {

            //int[] numeros = new int[5];
            //int suma = 0;
            /*
            numeros[0] = 150;
            numeros[1] = 350;
            numeros[2] = -50;
            numeros[3] = 250;
            numeros[4] = 950;
            */

            //suma = numeros[0] + numeros[1] + numeros[2] + numeros[3] + numeros[4];



            /*
            Console.WriteLine("Los elementos a sumar son: ");

            for (int i = 0; i <= 4; i++) {
                Console.WriteLine("Introduce un numero para la posicion: {0}", i);
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                suma += numeros[i];
            }

            Console.WriteLine("");
            Console.WriteLine("La suma es: {0}", suma);

             


            // Matrices

            int[,] notas1 = new int[2,2];

            notas1[0, 0] = 1;
            notas1[0, 1] = 2;
            notas1[1, 0] = 3;
            notas1[1, 1] = 4;

            int[,] notas2 = {
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                {10, 2, 3, 1, 2, 3, 4, 5, 10, 10 }
            };

            float media1 = 0;
            float media2 = 0;

            foreach (int n in notas1) {
                
                media1 += n;
            }
            media1 = media1 / notas1.Length;

            foreach (int n in notas2) {
                
                media2 += n;
            }
            media2 = media2 / notas2.Length;

            Console.WriteLine("La media de las notas1 es: {0}", media1);
            Console.WriteLine("La media de las notas2 es: {0}", media2);
            media2 = 0;
            for (int i = 0; i<2; i++) {
                for (int j = 0; j<10; j++) {
                    media2 += notas2[i, j];
                }
            }
            media2 = media2 / notas2.Length;
            Console.WriteLine("La media de las notas2 es: {0}", media2);


            */





            // Variables globales

            tipoPersona persona = new tipoPersona();
            
            persona.inicial = 'P';
            
            

            Console.WriteLine("Creando una nueva persona, introduce nombre: ");
            persona.nombre = Console.ReadLine();

            Console.WriteLine("Edad:");
            persona.edad = Convert.ToInt16(Console.ReadLine());


            Console.WriteLine("Nota: ");
            persona.nota = Convert.ToInt16(Console.ReadLine());

            persona.inicial = Convert.ToChar(persona.nombre.Substring(0, 1));
















            Console.ReadLine();





        }
    }
}
