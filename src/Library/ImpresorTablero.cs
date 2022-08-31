using System;
using System.Threading;

namespace PII_Game_Of_Life
{
    public class ImpresorTablero
    {
        
        public static void ImprimirTablero(Tablero tablero)
        {

            Console.Clear();
            Console.WriteLine(tablero.ToString());
            Thread.Sleep(300);
        }
        
    }
}