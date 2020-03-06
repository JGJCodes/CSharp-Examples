using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;//libreria externa

namespace SpeakConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Codigo de ejemplo de como integrar una libreria externa
            string mensaje = "Bienvenido al sistema, en que puedo ayudarte";
            Console.WriteLine(mensaje);

            //utilizacion de los componentes de la libreria externa
            SpeechSynthesizer hablar = new SpeechSynthesizer();
            hablar.Speak(mensaje); 
        }
    }
}
