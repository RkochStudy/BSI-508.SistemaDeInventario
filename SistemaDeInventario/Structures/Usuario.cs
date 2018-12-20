using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeInventario.Structures
{
    public class Usuario
    {
        public int id { set; get; }
        public string Name { set; get; }
        public string User { set; get; }
        public string Mail { set; get; }
        public int Age { set; get; }
        public int Rol { set; get; }

        public Usuario (int _id, string _name, string _user, string _mail, int _age, int _rol)
        {
            this.id = _id;
            this.Name = _name;
            this.User = _user;
            this.Mail = _mail;
            this.Age = _age;
            this.Rol = _rol;
        }

        public Usuario ()
        {

        }
    }
}
