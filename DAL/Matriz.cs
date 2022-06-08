using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Matriz
    {
        static private string filename = "RegistroMatriz.txt";

        public void Guardar(double[,] matriz, double[] umbral, int entrada, int salida)
        {
            FileStream file = new FileStream(filename, FileMode.Create);
            StreamWriter writer = new StreamWriter(file);
            string linea = "";
            for (int i = 0; i < salida; i++)
            {
                for (int j = 0; j < entrada; j++)
                {
                    linea = linea + matriz[i, j] + ";";
                }
                writer.WriteLine($"{linea}");
                linea = "";
            }

            for (int i = 0; i < salida; i++)
            {
                linea = linea + umbral[i] + "|";
            }

            writer.WriteLine($"{linea}");
            writer.Close();
            file.Close();
        }
    }
}
