using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProyecto
{
    public partial class Bebidas : UserControl
    {
        public Bebidas()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Aquarius_Click(object sender, EventArgs e)
        {
            Bebida aquarius = new Bebida();
            aquarius.Hielo = true;
            aquarius.Limon = false;
            aquarius.Id = "pictureBox1";
            aquarius.Name = "Aquaruis de Naranja";
            aquarius.Precio = 2.2;
            aquarius.Cantidad = 1;
            Form1.productos.Add(aquarius);
            MessageBox.Show("Añadida al carrito");

        }

        private void cocacola_Click(object sender, EventArgs e)
        {
            Bebida cocacola = new Bebida();
            cocacola.Hielo = true;
            cocacola.Limon = true;
            cocacola.Id = "pictureBox2";
            cocacola.Name = "Cocacola";
            cocacola.Precio = 2.2;
            cocacola.Cantidad = 1;
            Form1.productos.Add(cocacola);
            MessageBox.Show("Añadida al carrito");

        }

        private void fanta_Click(object sender, EventArgs e)
        {
            Bebida fanta = new Bebida();
            fanta.Hielo = true;
            fanta.Limon = true;
            fanta.Id = "pictureBox3";
            fanta.Name = "Fanta";
            fanta.Precio = 2.2;
            fanta.Cantidad = 1;
            Form1.productos.Add(fanta);
            MessageBox.Show("Añadida al carrito");
        }


        private void cania_Click(object sender, EventArgs e)
        {     
            Bebida cania = new Bebida();
            cania.Hielo = false;
            cania.Limon = false;
            cania.Id = "pictureBox4";
            cania.Name = "Caña";
            cania.Precio = 1.8;
            cania.Cantidad = 1;
            Form1.productos.Add(cania);
            MessageBox.Show("Añadida al carrito");
        }

    }
}
