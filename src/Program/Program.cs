using System;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] tableroArchivo = LectorArchivo.LeerArchivo("../../assets/board.txt");
            Tablero tablero1 = new Tablero(tableroArchivo);
            ImpresorTablero.ImprimirTablero(tablero1);
            
            while (true)
            {
                var tableroBoolActualizado = Logica.TableroActualizado(tablero1);
                tablero1.TableroBool = tableroBoolActualizado;
                ImpresorTablero.ImprimirTablero(tablero1);
            }
        }
    }
}
