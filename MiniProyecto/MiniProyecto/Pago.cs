using System;
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
    public partial class Pago : Form
    {
        private double pagoTotal;
        private Form1 form1;
        private Carrito carrito;

        public double PagoTotal { get => pagoTotal; set => pagoTotal = value; }
        public Form1 Form1 { get => form1; set => form1 = value; }
        public Carrito Carrito { get => carrito; set => carrito = value; }

        public Pago()
        {
            InitializeComponent();
            this.pagoTotal = 0.0;

            ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
            toolTip1.SetToolTip(button1, "Terminar de pagar el pedido");
            toolTip1.IsBalloon = true;
            toolTip1.InitialDelay = 500000;

            ToolTip toolTip2 = new System.Windows.Forms.ToolTip();
            toolTip2.SetToolTip(button2, "Volver a añadir mas productos al carrito");
            toolTip2.IsBalloon = true;
            toolTip2.InitialDelay = 500000;

            ToolTip toolTip3 = new System.Windows.Forms.ToolTip();
            toolTip3.SetToolTip(button3, "Nuevo Pedido");
            toolTip3.IsBalloon = true;
            toolTip3.InitialDelay = 500000;
        }

        private void Pago_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void generarTiempo() {
            this.label2.Text = pagoTotal.ToString();
            Random random = new Random();
            int tiempo= random.Next(5, 30);
            this.label3.Text = tiempo + " min";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.form1.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked == true)
            {
                MessageBox.Show("Pase por caja para pagar y recoger su pedido");
            }
            else if (this.radioButton2.Checked == true)
            {
                MessageBox.Show("Recoja su recibo y pase por caja a recoger su pedido");
            }
            Form1.productos.Clear();
            Form1.iniciarPedido();
            this.Close();
            this.carrito.hacerpedido();
            this.carrito.label2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se cancela este pedido");
            Form1.productos.Clear();
            this.Close();
            this.carrito.listaDePedido.Clear();
            this.carrito.label2.Text = "";
        }
    }
}
