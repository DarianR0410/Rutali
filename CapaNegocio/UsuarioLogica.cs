using System;
using CapaDatos;

namespace CapaNegocio
{
    public class UsuarioLogica
    {
        public string IniciarSesion(string usuario, string password)
        {
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(password))
            {
                throw new Exception("Por favor, llene todos los campos.");
            }

            if (usuario == "admin" && password == "admin123")
            {
                return "Administrador";
            }
            else if (usuario == "user" && password == "user123")
            {
                return "Generico";
            }

            return null;
        }
    }
}