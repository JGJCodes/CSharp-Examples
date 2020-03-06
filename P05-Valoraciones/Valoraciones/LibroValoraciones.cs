using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones
{
    public class LibroValoraciones
    {
        /*
        *Clase que define los atributos y funciones de un 
        * libro o coleccion de valores numericos
        */

        List<float> valoraciones;//Lista o conjunto de valores numericos
        public float valpromedio, valmaxima, valminima;

        /*
         * Metodo constructor de la clase
         * Inicializa el atributo valoraciones
         */
        public LibroValoraciones() {
            valoraciones = new List<float>();
            valpromedio = valmaxima = valminima = 0;
        }

        /*
         * Metodo que agrega un nuevo valor a la 
         * lista de valoraciones
         */
        public void AgregarValoracion(float valoracion)
        {
            valoraciones.Add(valoracion);
        }

        /*
         * Metodo que Imprime todos los resultados del proceso
         */
        public void PublicarValoraciones()
        {
            Console.WriteLine("El promedio de las valoraciones es: "+ this.PromedioValoraciones());
            Console.WriteLine("La valoracion minima es: " + this.MinimaValoracion());
            Console.WriteLine("La valoracion maxima es: " + this.MaximaValoracion());
        }

        /*
         * Metodo que calcula la sumatoria de las valoraciones
         */
        public float SumaValoraciones()
        {
            float sumavalor = 0;
            foreach (float valor in valoraciones) {
                sumavalor += valor;
            }
            return sumavalor;
        }

        /*
         * Metodo que calcula el promedio de las valoraciones
         */
        public float PromedioValoraciones()
        {
            valpromedio = SumaValoraciones() / valoraciones.Count;
            return valpromedio;
        }

        /*
         * Metodo que calcula el valor maximo de las valoraciones
         */
        public float MaximaValoracion()
        {
            float maxima = 0;
            foreach (float valor in valoraciones)
            {
                maxima = Math.Max(valor,maxima);
            }
            valmaxima = maxima;
            return maxima;
        }

        /*
         * Metodo que calcula el valor minimo de las valoraciones
         */
        public float MinimaValoracion()
        {
            float minima = float.MaxValue;
            foreach (float valor in valoraciones)
            {
                minima = Math.Min(valor, minima);
            }
            valminima = minima;
            return minima;
        }

        
    }
}
