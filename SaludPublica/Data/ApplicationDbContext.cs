using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SaludPublica.Models;

namespace SaludPublica.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Enfermedad> Enfermedades { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Provincia> Provincias {get; set;}
        public DbSet<Sintoma> Sintomas { get; set; }
        public DbSet<Diagnostico> Diagnosticos { get; set; }
        public DbSet<SintomaPorEnfermedades> SintomaPorEnfermedades { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
