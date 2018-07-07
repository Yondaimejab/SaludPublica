using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SaludPublica.Models
{
    public class SintomaPorEnfermedades
    {
        public int ID { get; set; }
        [ForeignKey("EnfermedadesID")]
        public int EnfermedadID { get; set; }
        public Enfermedad Enfermedad { get; set; }
        [ForeignKey("EnfermedadesID")]
        public int SintomaID { get; set; }
        public Sintoma Sintoma { get; set; }

    }
}
