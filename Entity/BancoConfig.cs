using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class BancoConfig
    {
        public BancoConfig(string entrada, string salida, string patrones, string definirRed, string tipoRed, string funcionActivacion, string reglaEntrenamiento)
        {
            Entrada = entrada;
            Salida = salida;
            Patrones = patrones;
            DefinirRed = definirRed;
            TipoRed = tipoRed;
            FuncionActivacion = funcionActivacion;
            ReglaEntrenamiento = reglaEntrenamiento;
        }

        public string Entrada { get; set; }
        public string Salida { get; set; }
        public string Patrones { get; set; }
        public string DefinirRed { get; set; }
        public string TipoRed { get; set; }
        public string FuncionActivacion { get; set; }
        public string ReglaEntrenamiento { get; set; }
    }
}
