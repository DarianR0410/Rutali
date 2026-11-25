using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class AutobusLogica
    {
        private AutobusRepository _autobusRepo = new AutobusRepository();

        public void RegistrarAutobus(string marca, string modelo, string placa, string color, string anioTexto)
        {
            if (string.IsNullOrWhiteSpace(marca) || string.IsNullOrWhiteSpace(modelo) ||
                string.IsNullOrWhiteSpace(placa) || string.IsNullOrWhiteSpace(color))
                throw new Exception("Todos los campos son obligatorios.");

            if (!int.TryParse(anioTexto, out int anio) || anio < 1990 || anio > DateTime.Now.Year + 1)
                throw new Exception("Ingrese un año válido.");

            _autobusRepo.Insertar(marca, modelo, placa, color, anio);
        }

        public DataTable ListarAutobuses()
        {
            return _autobusRepo.ObtenerTodos();
        }
    }
}