using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniProyecto.Properties;

namespace MiniProyecto
{
    public partial class Carrito : UserControl
    {
        private double precio=0;
        public int contador;
        private Form1 Form1;

        public Form1 Form11 { get => Form1; set => Form1 = value; }

        public Carrito()
        {
            InitializeComponent();

        }

        private void Carrito_Load(object sender, EventArgs e)
        {

        }
        public void hacerpedido()
        {

            listaDePedido.Items.Clear();
            listaDePedido.View = View.Details;
            listaDePedido.GridLines = true;
            double precio = 0.0;

            for (int i = 0; i < Form1.productos.Count; i++)
            {
                Producto aux = (Producto)Form1.productos[i];
                ListViewItem item = new ListViewItem(aux.Cantidad.ToString());
                // Place a check mark next to the item.
                item.SubItems.Add(aux.Name);
                item.SubItems.Add(aux.Precio.ToString());
                listaDePedido.Items.Add(item);
                precio += aux.Precio;
            }

            this.label2.Text = precio.ToString();

        }

        private void borrar_Click(object sender, EventArgs e)
        {
            Form1.productos.RemoveAt(listaDePedido.SelectedIndices[0]);
            listaDePedido.Items.Remove(listaDePedido.SelectedItems[0]);
            this.borrar.Visible = false;
            precio = 0;
            for (int i = 0; i < Form1.productos.Count; i++){
                Producto aux = (Producto)Form1.productos[i];
                ListViewItem item = new ListViewItem(aux.Cantidad.ToString());
                precio += aux.Precio;

            }

            this.label2.Text = precio.ToString();

        }



        private void listaDePedido_MouseClick(object sender, MouseEventArgs e)
        {
            this.borrar.Visible = true;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.precio < 0)
            {
                MessageBox.Show("No hay productos en el pedido");
            }

            else if (this.textBox1.Text.Equals("#HOLA30") && contador == 0)
            {
                this.precio = Convert.ToDouble(this.label2.Text) *0.9;
                contador = 1;
                this.label2.Text = this.precio.ToString();
            }
            else if (contador == 1)
            {
                MessageBox.Show("No puedes aplicar varios descuentos");
            }
            else {
                MessageBox.Show("No existe ese codigo de descuento");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Form1.productos.Count > 0)
            {
                Pago pago = new Pago();
                pago.Form1 = this.Form11;
                pago.Carrito = this;
                pago.PagoTotal = Convert.ToDouble(this.label2.Text);
                pago.generarTiempo();
                pago.Show();
            }
            else {
                MessageBox.Show("No hay elementos en el pedido");
            }
            
        }
    }
}
