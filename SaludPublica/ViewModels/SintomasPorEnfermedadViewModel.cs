using SaludPublica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaludPublica.ViewModels
{
    public class SintomasPorEnfermedadViewModel
    {
        public Enfermedad Enfermedad { get; set; }
        public int SintomaID { get; set; }
        public List<Sintoma> Sintomas { get; set; }
    }
}
