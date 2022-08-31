using System;
using System.Text;
using System.Threading;

namespace PII_Game_Of_Life
{
    public class Tablero
    {
        public bool[,] TableroBool {get; set;} //variable que representa el tablero
        public int Alto {get;}
        public int Ancho {get;}

        // Constructor del Tablero requiere que le pases un tablero booleano (con lector de archivo)
        public Tablero(bool[,] tableroBool)
        {
            this.TableroBool = tableroBool;
            this.Alto = tableroBool.GetLength(0);
            this.Ancho = tableroBool.GetLength(1);
        }


        
        // Método estático que se encarga de pasar el tablero leído, al tablero posta en String para ser impreso.
        public override String ToString()
        {
            StringBuilder tableroSB = new StringBuilder();
            for (int y = 0; y < this.Ancho;y++)
            {
                for (int x = 0; x < this.Alto; x++)
                {
                    if(this.TableroBool[x,y])
                    {
                        tableroSB.Append("|X|");
                    }
                    else
                    {
                        tableroSB.Append("___");
                    }
                }
                tableroSB.Append("\n");
            }

            return tableroSB.ToString();
        }
    }
}

