using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaludPublica.Models
{
    public class Enfermo
    {
        public int EnfermoID { get; set; }
        public ICollection<Enfermedad> Enfermedades { get; set; }
        public virtual ICollection<Paciente> Pacientes { get; set; }
    }
}
