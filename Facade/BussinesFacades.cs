using BussinesEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    public class BussinesFacades
    {
        public Usuario Login(string identificador, string password)
        {
            return new BussinesLogic.AdmLogin().Login(identificador, password);
        }
    }
}
