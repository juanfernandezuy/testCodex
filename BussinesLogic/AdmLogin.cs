using BussinesEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinesLogic
{
    public class AdmLogin
    {
        public Usuario Login(string identificador, string password)
        {
            var usuarios = new Mappers.MapUsuarios().GetUsuarios(identificador, password);
            return usuarios.FirstOrDefault();
        }
    }
}
