using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SaludPublica.Models
{
    public class Provincia
    {
        public int ProvinciaID { get; set; }
        [Required]
        public string Nombre { get; set; }
        [ForeignKey("PaisID")]
        [Display(Name = "Pais")]
        public int PaisID { get; set; }
        public virtual Pais Pais { get; set; }
    }
}
