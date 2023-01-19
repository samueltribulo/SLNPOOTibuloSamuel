using LibTransportes.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes
{
    public class Camion : Vehiculo
    {

        public Camion(string Fabricante, Remolque Remolque, string Modelo, string CapacidadMotor, double CapacidadCarga):base(Fabricante, Modelo) {
            
            this.Remolque = Remolque;
            this.CapacidadMotor = CapacidadMotor;
            this.CapacidadCarga = CapacidadCarga;
        
        }

        public double CapacidadCarga { get; set; }

        public string CapacidadMotor { get; set; }

        public Remolque Remolque { get; set; }

        public void QuitarRemolque()
        {

            this.Remolque = null;

        }

        public override string Acelerar()
        {

            return "Camion acelerando";

        }

       
        public override string MostrarProps()
        {
            string respuesta = this.Remolque == null ? "No" : "Si";

            return base.MostrarProps() + $"\nCapacidad motor: {CapacidadMotor}\n" +
                $"Capacidad carga: {this.CapacidadCarga}\n" +
                $"Remolque: {respuesta}";
        }

    }
}
