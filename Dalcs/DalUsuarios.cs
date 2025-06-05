using BussinesEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Dalcs
{
    public class DalUsuarios
    {
        private string GetFilePath()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "usuarios.csv");
        }

        public List<Usuario> GetUsuarios(string identificador, string password)
        {
            var path = GetFilePath();
            var result = new List<Usuario>();

            if (!File.Exists(path))
                return result;

            foreach (var line in File.ReadAllLines(path))
            {
                var parts = line.Split(';');
                if (parts.Length != 6)
                    continue;

                int edad;
                int.TryParse(parts[2], out edad);

                var usuario = new Usuario
                {
                    Nombre = parts[0],
                    Apellido = parts[1],
                    Edad = edad,
                    Email = parts[3],
                    Identificar = parts[4],
                    Password = parts[5]
                };

                if (usuario.Identificar == identificador && usuario.Password == password)
                {
                    result.Add(usuario);
                }
            }

            return result;
        }

        public void AddUsuario(Usuario usuario)
        {
            var path = GetFilePath();
            var line = string.Join(";", new[]
            {
                usuario.Nombre,
                usuario.Apellido,
                usuario.Edad.ToString(),
                usuario.Email,
                usuario.Identificar,
                usuario.Password
            });

            File.AppendAllLines(path, new[] { line });
        }
    }
}
