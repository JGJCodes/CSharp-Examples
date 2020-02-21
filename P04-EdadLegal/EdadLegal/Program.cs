using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdadLegal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba su nombre y presione Enter:");
            string nombre = Console.ReadLine(); //Recibe el nombre escrito
            
            Console.WriteLine("Escriba su edad y presione Enter:");
            int edad = int.Parse(Console.ReadLine()); //Recibe la edad y la convierte en un valor numerico

            if (edad >= 18) //Evalua si la edad es mayor o igual de 18 
            {
                Console.WriteLine("Tu nombre es " + nombre + " y legalmente eres mayor de edad");
            }
            else {
                Console.WriteLine("Tu nombre es " + nombre + " y legalmente eres menor de edad");
            }
        }
    }
}
