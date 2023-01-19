using LibTransportes.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes
{
    public class AutoElectrico:Vehiculo
    {
        public AutoElectrico(string Fabricante, string Modelo, string CapacidadBateria, string Velocidad):base(Fabricante, Modelo){ 
        
            this.Velocidad = Velocidad;
            this.CapacidadBateria = CapacidadBateria;

        }

        public string CapacidadBateria { get; set; }

        public string Velocidad { get; set; }

        public override string Acelerar()
        {

            return "Auto eléctrico acelerando ";

        }

    }
}
