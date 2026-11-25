using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class AsignacionLogica
    {
        private AsignacionRepository _asignacionRepo = new AsignacionRepository();
        private ChoferRepository _choferRepo = new ChoferRepository();
        private AutobusRepository _autobusRepo = new AutobusRepository();
        private RutaRepository _rutaRepo = new RutaRepository();

        public DataTable CargarChoferesDisponibles() => _choferRepo.ObtenerDisponibles();
        public DataTable CargarAutobusesDisponibles() => _autobusRepo.ObtenerDisponibles();
        public DataTable CargarRutasDisponibles() => _rutaRepo.ObtenerDisponibles();

        public void GuardarAsignacion(object idChofer, object idAutobus, object idRuta)
        {
            if (idChofer == null || idAutobus == null || idRuta == null)
                throw new Exception("Debe seleccionar un chofer, un autobús y una ruta.");

            _asignacionRepo.Crear((int)idChofer, (int)idAutobus, (int)idRuta);
        }

        public DataTable ListarAsignacionesActivas() => _asignacionRepo.ObtenerAsignacionesActivas();
    }
}