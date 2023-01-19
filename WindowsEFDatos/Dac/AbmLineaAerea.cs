using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using WindowsEFDatos.Data;
using WindowsEFDatos.Models;

namespace WindowsEFDatos.Dac
{
    public static class AbmLineaAerea
    {
        private static DBLineaAereaContext context = new DBLineaAereaContext();

        public static int Insertar(LineaAerea lineaAerea)
        {
            try
            {

                context.LineasAereas.Add(lineaAerea);
                context.SaveChanges();
                return 1;

            }
            catch (Exception ex)
            {

                return 0;

            }

        }

    }
}
