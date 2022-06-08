using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BancoConfigService
    {
        BancoConfigRepository BancoConfig;

        public BancoConfigService()
        {
            BancoConfig = new BancoConfigRepository();
        }

        public string Guardar(BancoConfig config)
        {
            try
            {
                    BancoConfig.Guardar(config);
                    return "Registro guardado Satisfactoriamente";

            }
            catch (Exception e)
            {
                return "Error. De Aplicacion: " + e.Message;
            }
        }
    }
}
