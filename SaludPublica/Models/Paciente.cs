using Microsoft.AspNetCore.Http;
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
        [DataType(DataType.PhoneNumber)]
        [Required]
        [RegularExpression(@"\d{3}[\-]\d{3}[\-]\d{4}",
         ErrorMessage = "Formato del telefono no valido.")]
        public string Telefono { get; set; }
        public string Calle { get; set; }
        [Display(Name = "No.")]
        public int NumeroDeCasa { get; set; }
        public string Sector { get; set; }
        [Display(Name = "Es Cliente")]
        public bool EsCliente { get; set; }
        [ForeignKey("ProvinciaID")]
        public int ProvinciaID { get; set; }
        public Provincia Provincia { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Nacimiento")]
        public DateTime FechaNacimiento { get; set; }
        [Required]
        public string Sexo { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public IList<Diagnostico> Diagnosticos { get; set; }
        [DataType(DataType.Upload)]
        public byte[] ImageData { get; set; }
        [Display(Name = "Comentario")]
        public string Descripcion { get; set; }
    }
}
