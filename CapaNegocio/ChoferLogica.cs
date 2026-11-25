using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class ChoferLogica
    {
        private ChoferRepository _choferRepo = new ChoferRepository();

        public void RegistrarChofer(string nombre, string apellido, DateTime fechaNac, string cedula)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(cedula))
                throw new Exception("Todos los campos marcados son obligatorios.");

            if (cedula.Length < 11)
                throw new Exception("La cédula debe tener al menos 11 dígitos.");

            _choferRepo.Insertar(nombre, apellido, fechaNac, cedula);
        }

        public DataTable ListarChoferes()
        {
            return _choferRepo.ObtenerTodos();
        }


        
    }
}