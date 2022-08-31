using System;
namespace computerMaintenance.App.Dominio
{
    /// <summary>Class <c>HistoriaTecnico</c>
    /// Modela la historia del tecnico
    /// </summary>
    public class HistoriaTecnico 
    {
        ///Relación entre HistoriaTecnico y Cliente
        public Tecnico Tecnico { get; set; }       
        /// relación entre HistoriaTecnico y NuevaSolicitud
        public NuevaSolicitud NuevaSolicitud { get; set; }
    }
}