using Microsoft.AspNetCore.Mvc.Rendering;
using SaludPublica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaludPublica.ViewModels
{
    public class PacienteProvinciaViewModel
    {
        public Paciente Paciente { get; set; }
        public List<Provincia> Provincias { get; set; }
    }
}
