using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Util
{
    public static class Printer
    {
        //agregar //
        public static void DibujarLinea (int tamanio = 20)
        {
            Console.WriteLine("".PadLeft(tamanio,'='));   //rellenar con = a la izquierda
        }
        //formato del titulo
        public static void DibujarTitulo (string titulo)
        {
            var tamaño = titulo.Length + 4;
            DibujarLinea(tamaño);
            Console.WriteLine($"| {titulo} |");
            DibujarLinea(tamaño);
        }

        // sonido beep
        public static void SonidoBeep(int hz = 2000, int tiempo = 500, int cantidad = 1)
        {
            while(cantidad-- > 0)
            {
                Console.Beep(hz, tiempo);
            }
        }
    }
}