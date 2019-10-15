namespace EJER1
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo");
            /*
                        int num = 4;
                        int a = 39;
                        int b = 85;
                        int suma = a + b;
                        */



            int numero1, numero2, total;
            Console.WriteLine("Escriba el primer numero a sumar");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba el segundo numero a sumar");
            numero2 = Convert.ToInt32(Console.ReadLine());

            total = numero1 + numero2;

            Console.WriteLine("El resultado de Sumar {0} y {1} es: {2}", numero1, numero2, total);



            
            Console.ReadLine();

        }
    }
}
