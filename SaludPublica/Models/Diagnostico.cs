using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SaludPublica.Models
{
    public class Diagnostico
    {
        public int DiagnosticoID { get; set; }
        [Display( Name = "Comentario")]
        [MaxLength(300)]
        public string  Comment { get; set; }
        [Display( Name = "fecha")]
        public DateTime Date { get; set; }
        [ForeignKey("PacienteID")]
        public int PacienteID { get; set; }
        public Paciente Paciente { get; set; }
        [ForeignKey("EnfermedadID")]
        public int EnfermedadID { get; set; }
        public Enfermedad Enfermedad { get; set; }
        [ForeignKey("DoctorID")]
        public string DoctorID { get; set; }
        public ApplicationUser Doctor { get; set; }



    }
}
