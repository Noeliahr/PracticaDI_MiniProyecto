using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProyecto
{
    public partial class Form1 : Form
    {
        public static ArrayList productos = new ArrayList();

        public Form1()
        {
            InitializeComponent();
            inicio2.BringToFront();

            ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
            toolTip1.SetToolTip(button1, "Pantalla de Bebidas");
            toolTip1.IsBalloon = true;
            toolTip1.InitialDelay = 500000;

            ToolTip toolTip2 = new System.Windows.Forms.ToolTip();
            toolTip2.SetToolTip(button2, "Pantalla de Comidas");
            toolTip2.IsBalloon = true;
            toolTip2.InitialDelay = 500000;

            ToolTip toolTip3 = new System.Windows.Forms.ToolTip();
            toolTip3.SetToolTip(button4, "Pantalla de Carrito");
            toolTip3.IsBalloon = true;
            toolTip3.InitialDelay = 500000;

            ToolTip toolTip4 = new System.Windows.Forms.ToolTip();
            toolTip4.SetToolTip(button3, "Reiniciar Pedido");
            toolTip4.IsBalloon = true;
            toolTip4.InitialDelay = 500000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bebidas1.BringToFront();
        }

        private void inicio1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1.carrito1.hacerpedido();
            Form1.carrito1.Form11 = this;
            Form1.carrito1.hacerpedido();
            Form1.carrito1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            inicio1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.comida1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
        public static void iniciarPedido() {
            Form1.productos.Clear();
            Form1.carrito1.contador = 0;
            Form1.carrito1.hacerpedido();
            //this.carrito1.listaDePedido.Clear();
            Form1.carrito1.label2.Text = "";
            Form1.inicio2.BringToFront();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Se cancela este pedido");
            Form1.productos.Clear();
            Form1.carrito1.contador = 0;
            Form1.carrito1.hacerpedido();
            //this.carrito1.listaDePedido.Clear();
            Form1.carrito1.label2.Text = "";
            inicio2.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
