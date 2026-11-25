using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class RutaLogica
    {
        private RutaRepository _rutaRepo = new RutaRepository();

        public void RegistrarRuta(string nombreRuta)
        {
            if (string.IsNullOrWhiteSpace(nombreRuta))
                throw new Exception("El nombre de la ruta es obligatorio.");

            _rutaRepo.Insertar(nombreRuta);
        }

        public DataTable ListarRutas()
        {
            return _rutaRepo.ObtenerTodas();
        }
    }
}
