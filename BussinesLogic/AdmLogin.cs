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
            return new Mappers.MapUsuarios().GetUsuarios(identificador, password)[1];
        }
    }
}
