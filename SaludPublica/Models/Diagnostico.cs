using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SaludPublica.Models
{
    public class Diagnostico
    {
        public int DiagnosticoID { get; set; }
        [ForeignKey("PacienteID")]
        public int PacienteID { get; set; }
        public Paciente Paciente { get; set; }
        [ForeignKey("EnfermedadID")]
        public string EnfermedadID { get; set; }
        public Enfermedad Enfermedad { get; set; }
        [ForeignKey("DoctorID")]
        public string DoctorID { get; set; }
        public ApplicationUser Doctor { get; set; }



    }
}
