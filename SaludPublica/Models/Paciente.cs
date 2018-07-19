using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SaludPublica.Models
{
    public class Paciente
    {
        public int PacienteID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Calle { get; set; }
        [Display(Name = "No.")]
        public int NumeroDeCasa { get; set; }
        public string Sector { get; set; }
        [ForeignKey("ProvinciaID")]
        public int ProvinciaID { get; set; }
        public Provincia Provincia { get; set; }
        public int Edad { get; set; }
        [StringLength(1)]
        public string Sexo { get; set; }
        public IList<Diagnostico> Diagnosticos { get; set; }
        
    }
}
