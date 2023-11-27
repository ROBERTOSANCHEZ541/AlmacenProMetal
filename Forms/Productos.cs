using MySql.Data.MySqlClient;
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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Program.ConnectionString))
                {
                    connection.Open();
                    using (MySqlCommand comando = new MySqlCommand("ObtenerProductos", connection))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                        {
                            DataTable tablaPedidos = new DataTable();
                            adaptador.Fill(tablaPedidos);
                            dgvProductos.DataSource = tablaPedidos;
                        }
                    }
                    connection.Close();
                }
                MessageBox.Show("Pedidos obtenidos exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los pedidos. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidacionTxts()
        {
            return !string.IsNullOrWhiteSpace(txtPrecio.Text) &&
                   !string.IsNullOrWhiteSpace(TxtCantidad.Text) &&
                   !string.IsNullOrWhiteSpace(TxtDescrip.Text) &&
                   !string.IsNullOrWhiteSpace(TxtIdCategoria.Text) &&
                   !string.IsNullOrWhiteSpace(TxtIdSuc.Text) &&
                   !string.IsNullOrWhiteSpace(TxtNombre.Text);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidacionTxts())
                {
                    MessageBox.Show("Faltan campos por ingresar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    using (MySqlConnection connection = new MySqlConnection(Program.ConnectionString))
                    {
                        connection.Open();
                        using (MySqlCommand comando = new MySqlCommand("InsertarProducto", connection))
                        {
                            comando.CommandType = CommandType.StoredProcedure;
                            comando.Parameters.AddWithValue("p_NombreProducto", TxtNombre.Text);
                            comando.Parameters.AddWithValue("p_Precio", Decimal.Parse(txtPrecio.Text));
                            comando.Parameters.AddWithValue("p_Stock", int.Parse(TxtCantidad.Text));
                            comando.Parameters.AddWithValue("p_Descripcion", TxtDescrip.Text);
                            comando.Parameters.AddWithValue("p_IDCategoria", int.Parse(TxtIdCategoria.Text));
                            comando.Parameters.AddWithValue("p_IDSucursal", int.Parse(TxtIdSuc.Text));
                            comando.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Producto insertado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar insertar el producto. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool ValidacionTxtID()
        {
            int idProducto;
            return int.TryParse(TxtIdProducto.Text, out idProducto) &&
                   !string.IsNullOrWhiteSpace(txtPrecio.Text) &&
                   !string.IsNullOrWhiteSpace(TxtCantidad.Text) &&
                   !string.IsNullOrWhiteSpace(TxtDescrip.Text) &&
                   !string.IsNullOrWhiteSpace(TxtIdCategoria.Text) &&
                   !string.IsNullOrWhiteSpace(TxtIdSuc.Text) &&
                   !string.IsNullOrWhiteSpace(TxtNombre.Text);
        }

        private void BtnActualir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidacionTxtID())
                {
                    MessageBox.Show("Faltan campos por ingresar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    using (MySqlConnection connection = new MySqlConnection(Program.ConnectionString))
                    {
                        connection.Open();
                        using (MySqlCommand comando = new MySqlCommand("ActualizarProducto", connection))
                        {
                            comando.CommandType = CommandType.StoredProcedure;
                            comando.Parameters.AddWithValue("p_IdArticulo", TxtIdProducto.Text);
                            comando.Parameters.AddWithValue("p_NombreProducto", TxtNombre.Text);
                            comando.Parameters.AddWithValue("p_Precio", Decimal.Parse(txtPrecio.Text));
                            comando.Parameters.AddWithValue("p_Stock", int.Parse(TxtCantidad.Text));
                            comando.Parameters.AddWithValue("p_Descripcion", TxtDescrip.Text);
                            comando.Parameters.AddWithValue("p_IDCategoria", int.Parse(TxtIdCategoria.Text));
                            comando.Parameters.AddWithValue("p_IDSucursal", int.Parse(TxtIdSuc.Text));
                            comando.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Producto actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar actualizar el producto. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            this.Hide();
        }
    }
}
