using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BancoConfigRepository
    {
        static private string filename = "RegistroBancoConfig.txt";

        public void Guardar(BancoConfig config)
        {
            FileStream file = new FileStream(filename, FileMode.Create);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine($"{config.Entrada};{config.Salida};{config.Patrones};{config.DefinirRed};{config.TipoRed};{config.FuncionActivacion};{config.ReglaEntrenamiento}");
            writer.Close();
            file.Close();
        }
    }
}
