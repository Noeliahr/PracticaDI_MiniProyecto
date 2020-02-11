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
    public partial class Comida : UserControl
    {
        public Comida()
        {
            InitializeComponent();

            ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
            toolTip1.SetToolTip(Callos, "Añadir al carrito");
            toolTip1.SetToolTip(Tortilla, "Añadir al carrito");
            toolTip1.SetToolTip(button1, "Añadir al carrito");
            toolTip1.SetToolTip(button2, "Añadir al carrito");
            toolTip1.SetToolTip(button3, "Alergenos");
            toolTip1.SetToolTip(button4, "Alergenos");
            toolTip1.SetToolTip(button5, "Alergenos");
            toolTip1.IsBalloon = true;
            toolTip1.InitialDelay = 500000;

        }


        private void Aquarius_Click(object sender, EventArgs e)
        {
            Bebida aquarius = new Bebida();
            aquarius.Hielo = true;
            aquarius.Limon = false;
            aquarius.Id = "pictureBox1";
            aquarius.Name = "Callos";
            aquarius.Precio = 1.2;
            aquarius.Cantidad = 1;
            Form1.productos.Add(aquarius);
            MessageBox.Show("Añadido al carrito");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bebida aquarius = new Bebida();
            aquarius.Id = "pictureBox1";
            aquarius.Name = "Tortilla de Espinacas";
            aquarius.Precio = 1.2;
            aquarius.Cantidad = 1;
            Form1.productos.Add(aquarius);
            MessageBox.Show("Añadido al carrito");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Bebida aquarius = new Bebida();
            aquarius.Hielo = true;
            aquarius.Limon = false;
            aquarius.Id = "pictureBox1";
            aquarius.Name = "Tosta de Solomillo";
            aquarius.Precio = 7.9;
            aquarius.Cantidad = 1;
            Form1.productos.Add(aquarius);
            MessageBox.Show("Añadido al carrito");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bebida aquarius = new Bebida();
            aquarius.Hielo = true;
            aquarius.Limon = false;
            aquarius.Id = "pictureBox1";
            aquarius.Name = "Hamburguesa";
            aquarius.Precio = 7.9;
            aquarius.Cantidad = 1;
            Form1.productos.Add(aquarius);
            MessageBox.Show("Añadido al carrito");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contiene Gluten");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contiene Gluten, y trazas de huevo");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contiene Gluten");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contiene Huevo");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
