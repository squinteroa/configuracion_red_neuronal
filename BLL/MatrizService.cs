using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MatrizService
    {
        Matriz mAtriz;

        public MatrizService()
        {
            mAtriz = new Matriz();
        }

        public string Guardar(double[,] matriz, double[] umbral, int entrada, int salida)
        {
            try
            {
                mAtriz.Guardar(matriz,umbral,entrada,salida);
                return "Registro guardado Satisfactoriamente";

            }
            catch (Exception e)
            {
                return "Error. De Aplicacion: " + e.Message;
            }
        }
    }
}
