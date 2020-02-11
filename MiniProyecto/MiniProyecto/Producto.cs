using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProyecto
{
    class Producto
    {

        protected String id;
        protected String name;
        protected double precio;
        protected int cantidad;

        public Producto() {

        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
