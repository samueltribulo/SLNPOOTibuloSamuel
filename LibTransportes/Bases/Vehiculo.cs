using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Bases
{

    public abstract class Vehiculo
    {

        public Vehiculo(string Fabricante, string Modelo)
        {

            this.Fabricante = Fabricante;
            this.Modelo = Modelo;

        }
        public string Fabricante { get; set; }

        public string Modelo { get; set;}

        public abstract string Acelerar();

        public virtual string MostrarProps()
        {


            return $"Fabricante: {this.Fabricante}\n" +
                $"Modelo: {this.Modelo}";
        }

    }
}
