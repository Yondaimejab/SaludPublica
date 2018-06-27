using SaludPublica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaludPublica.Services
{
    public interface  IReporte
    {
        Task GenerarReporteDiariolAsync(ICollection<Paciente> Pacientes,ICollection<Enfermedad> Enfermedades);
        Task GenerarReporteSemanalAsync(ICollection<Paciente> Pacientes, ICollection<Enfermedad> Enfermedades);
        Task GenerarReporteMensualAsync(ICollection<Paciente> Pacientes, ICollection<Enfermedad> Enfermedades);
    }
}
