using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SaludPublica.Models;

namespace SaludPublica.Services
{
    public class Reporte : IReporte
    {
        public Task GenerarReporteDiariolAsync(ICollection<Paciente> Pacientes, ICollection<Enfermedad> Enfermedades)
        {
            //TODO
            throw new NotImplementedException();
        }

        public Task GenerarReporteMensualAsync(ICollection<Paciente> Pacientes, ICollection<Enfermedad> Enfermedades)
        {
            //TODO
            throw new NotImplementedException();
        }

        public Task GenerarReporteSemanalAsync(ICollection<Paciente> Pacientes, ICollection<Enfermedad> Enfermedades)
        {
            //TODO
            throw new NotImplementedException();
        }
    }
}
