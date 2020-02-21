using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saludo
{
    class Program
    {
        /**Se recibe un argumento de inicio en args[] 
         * Se puede modificar el argumento en propiedades del proyecto
         * en la seccion de DEBUG en el apartado de START OPTIONS
        **/
        static void Main(string[] args)
        {
            Console.WriteLine("Hola "+args[0]); //Imprime un mensaje junto con un argumento en consola 
        }
    }
}
