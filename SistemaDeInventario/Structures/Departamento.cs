using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeInventario.Structures
{
    public class Departamento
    {
        public string Nombre { set; get; }
        public int Encargado { set; get; }
        public int Subencargado { set; get; }

        public Departamento (string _nombre, string _encargado, string _subencargado)
        {
            this.Nombre = _nombre;
            this.Encargado = int.Parse(_encargado);
            this.Subencargado = int.Parse(_subencargado);
        }
    }
}
