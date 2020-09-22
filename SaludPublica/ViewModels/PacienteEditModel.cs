using Microsoft.AspNetCore.Http;
using SaludPublica.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludPublica.ViewModels
{
    public class PacienteEditModel
    {
        [Required]
        public Paciente Paciente { get; set; }
        public List<Provincia> Provincias { get; set; }
        [DataType(DataType.Upload)]
        public IFormFile FotoPerfil { get; set; }
    }
}
