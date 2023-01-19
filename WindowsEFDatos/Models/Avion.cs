using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFDatos.Models
{

    [Table("Avion")]
    public class Avion
    {
        [Key]
        public int IdAvion { get; set; }

        public double Capacidad { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Denominacion { get; set; }

        public virtual int LineaAerea_Id { get; set; }

        [ForeignKey("LineaAerea_Id")]
        public LineaAerea LineaAerea { get; set; }

    }
}
