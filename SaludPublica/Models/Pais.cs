﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaludPublica.Models
{
    public class Pais
    {
        public int PaisID { get; set; }
        [Required]
        public string Nombre { get; set; }
    }
}
