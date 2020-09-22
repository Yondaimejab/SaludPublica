﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using SaludPublica.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaludPublica.ViewModels
{
    public class PacienteProvinciaViewModel
    {
        public Paciente Paciente { get; set; }
        public List<Provincia> Provincias { get; set; }
        [Required]
        [DataType(DataType.Upload)]
        public IFormFile FotoPerfil { get; set; }

    }
}
