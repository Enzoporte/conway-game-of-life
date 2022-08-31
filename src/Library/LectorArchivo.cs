using System.IO;

namespace PII_Game_Of_Life
{
    public class LectorArchivo
    {
        // SRP: 

        // Método estático que devuelve el tablero en forma booleana para ser utilizada por la clase Tablero
        public static bool[,] LeerArchivo(string urlArchivo)
        {
            string content = File.ReadAllText(urlArchivo);
            string[] contentLines = content.Split('\n');
            bool[,] board = new bool[contentLines.Length, contentLines[0].Length];
            // For para recorrer cada espacio (cada fila por cada columna)
            for (int  y=0; y<contentLines.Length;y++)
            {
                for (int x=0; x<contentLines[y].Length; x++)
                {
                    if(contentLines[y][x]=='1')
                    {
                        board[x,y]=true;    //Reemplazar 1 por true. El board bool viene por defecto con los espacios en false (?)
                    } 
                }
            }

            return board;
        }
    }
}