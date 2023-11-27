using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlmacenProMetal.Forms
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            string varTtxUser = InicioSesion.VarTtxUser;
            LbUsuario.Text = varTtxUser;
        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            InicioSesion login = new InicioSesion();
            login.LimpiarTxtRFC();
            login.Show();
            this.Close();
          
        }

        private void DetallesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DetCompra detCompra = new DetCompra();
            detCompra.Show();
            this.Hide();
        }

        private void DetallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetPedido detPedido = new DetPedido();
            detPedido.Show();
            this.Hide();
        }

        private void ComprasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Compras compras = new Compras();
            compras.Show();
            this.Hide();
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Show();
            this.Hide();
        }

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();  
            productos.Show();
            this.Hide();
        }

        private void SucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sucursales sucursales = new Sucursales();
            sucursales.Show();
            this.Hide();
        }

        private void EmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados empleados = new Empleados();
                empleados.Show();
            this.Hide();
        }

        private void ProveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor();
            proveedor.Show();
            this.Hide();

        }

        private void CategoriasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            categoria.Show();
            this.Hide();
        }

        private void PedidosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Pedidos pedidos = new Pedidos();
            pedidos.Show();
            this.Hide();

        }

        private void TransporteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Transporte transporte = new Transporte();
            transporte.Show();
            this.Hide();

        }
    }
}
