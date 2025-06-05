using BussinesEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinesLogic
{
    public class AdmUsuarios
    {
        public void CrearUsuario(Usuario usuario)
        {
            new Mappers.MapUsuarios().AddUsuario(usuario);
        }
    }
}
