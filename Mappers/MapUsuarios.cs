using BussinesEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mappers
{
    public class MapUsuarios
    {
        public List<Usuario> GetUsuarios(string identificador, string password)
        {
            return new Dalcs.DalUsuarios().GetUsuarios(identificador, password);
        }

        public void AddUsuario(Usuario usuario)
        {
            new Dalcs.DalUsuarios().AddUsuario(usuario);
        }
    }
}
