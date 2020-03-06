using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos el objeto libro
            LibroValoraciones libro = new LibroValoraciones();

            //Asignar valoraciones al objeto libro
            libro.AgregarValoracion(3.5f);//Agregamos un nuevo valor 3.5 float
            libro.AgregarValoracion(5);
            libro.AgregarValoracion(2);
            libro.AgregarValoracion(4.9f);
            libro.AgregarValoracion(0.342f);
            libro.AgregarValoracion(20);
            libro.AgregarValoracion(15);

            //Imprimir resultados de los calculos valoraciones
            libro.PublicarValoraciones();

        }
    }
}
