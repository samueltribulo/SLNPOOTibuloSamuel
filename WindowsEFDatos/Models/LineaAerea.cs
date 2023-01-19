﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFDatos.Models
{
    [Table("LineaAerea")]
    public class LineaAerea
    {

        [Key]
        public int IdLinea { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Nombre { get; set; }

        public DateTime FechaInicioActividades { get; set; }

        public List<Avion> Aviones { get; set; }
    }
}
