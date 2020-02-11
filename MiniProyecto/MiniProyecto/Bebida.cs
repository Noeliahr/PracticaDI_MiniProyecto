using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProyecto
{
    class Bebida: Producto
    {
        Boolean hielo;
        Boolean limon;


        public Bebida() {

        }

        public bool Hielo { get => hielo; set => hielo = value; }
        public bool Limon { get => limon; set => limon = value; }
    }
}
