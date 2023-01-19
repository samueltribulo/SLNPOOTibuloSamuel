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

        public static int Editar(int id, double capacidad, string denominacion, int lineaAereaId)
        {

            try
            {

                Avion AvionOrigen = context.Aviones.Where(Av => Av.IdAvion == id).FirstOrDefault();
                AvionOrigen.Capacidad = capacidad;
                AvionOrigen.Denominacion = denominacion;
                AvionOrigen.LineaAerea_Id = lineaAereaId;
                context.SaveChanges();

                return 1;
            }
            catch (Exception)
            {

                return 0;
            }

        }

        public static int Eliminar(int id)
        {
            try
            {

                Avion AvionOrigen = context.Aviones.Remove(context.Aviones.Single( av => av.IdAvion == id));
                context.SaveChanges();

                return 1;
            }
            catch (Exception)
            {

                return 0;
            }

        }

        public static List<Avion> TraerPorId(int id)
        {

                List<Avion> Avion = context.Aviones.Where(av => av.IdAvion == id).ToList();

                return Avion;

        }

    }
}
