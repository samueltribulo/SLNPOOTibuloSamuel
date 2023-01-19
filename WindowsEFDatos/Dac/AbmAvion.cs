using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFDatos.Data;
using WindowsEFDatos.Models;

namespace WindowsEFDatos.Dac
{
    public static class AbmAvion
    {

        private static DBLineaAereaContext context = new DBLineaAereaContext();

        public static List<Avion> Listar()
        {

            return context.Aviones.ToList();

        }

        public static int Insertar(Avion Avion)
        {

            try
            {
                context.Aviones.Add(Avion);

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
