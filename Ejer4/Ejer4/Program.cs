using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string stNombre, stApellido;
            stNombre = "Pepe";
            stApellido = Console.ReadLine();

            stNombre = stNombre + " " + stApellido;
            Console.WriteLine(stNombre);

            int lon = stApellido.Length;
            Console.WriteLine("La primera letra del apellido es: {0} y tienen {1} letras", stApellido[0], lon);

            Console.WriteLine("El 2º y 3º caracter es: {0}", stApellido.Substring(1,2));

            Console.WriteLine("La primera letra es: {0}", stNombre[0]);

            Console.WriteLine("{0}", stApellido.ToUpper().Replace("Z","S"));

            Console.WriteLine("");

            int itPosicion = stApellido.IndexOf("p");

            if((itPosicion == -1))
            {
                Console.WriteLine("No existe el caracter p");
            }
            else
            {
                Console.WriteLine("La posición que ocupa el caracter p es: {0}", itPosicion);

            }
            
            /*
             *stApellido.Substring(0,3)
             * stApellido.Length
             * stApellido.ToUpper()
             * stApellido.ToLower()
             * .Insert(4, ", tio")
             * .Remove(0, 6)
             * .Replace("z", "s")
             * 
             * 
             * 
             * 
             */
            // Que tenga una arroba
            // que tenga un punto
            // 
            bool incorrecto = true;
            bool comp1 = true;
            bool comp2 = true;
            bool comp3 = true;
            bool comp4 = true;

            while (incorrecto) {

                Console.WriteLine("Introduzca un email");
                string email = Console.ReadLine();

                if (email.Contains("@"))
                {
                    string[] emailArray = email.Split('@');
                    if (emailArray.Length == 2)
                    {
                        if (!emailArray[1].Contains("."))
                        {
                            comp1 = false;
                            Console.WriteLine("Falta el dominio del email");
                        } 
                        if (!(emailArray[1].IndexOf(".") != 0 && emailArray[1].LastIndexOf(".") != emailArray[1].Length)) {
                            comp2 = false;
                        } 

                    } else
                    {
                        comp3 = false;
                        Console.WriteLine("El correo es incorrecto, solo puede tener una @");
                    }
                } else
                {
                    comp4 = false;
                    Console.WriteLine("El correo es incorrecto, no contiene ninguna @");
                }

                incorrecto = comp1 && comp2 && comp3 && comp4;

            }


            Console.ReadLine();

        }
    }
}
