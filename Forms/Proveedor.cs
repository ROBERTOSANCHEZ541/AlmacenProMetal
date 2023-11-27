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
    public partial class Proveedor : Form
    {
        public Proveedor()
        {
            InitializeComponent();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            this.Hide();
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                    string.IsNullOrWhiteSpace(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtRFC.Text))
                {
                    MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (MySqlConnection conexion = new MySqlConnection(Program.ConnectionString))
                {
                    conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand("InsertarProveedor", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("p_Nombre", txtNombre.Text);
                        comando.Parameters.AddWithValue("p_Telefono", txtTelefono.Text);
                        comando.Parameters.AddWithValue("p_Direccion", txtDireccion.Text);
                        comando.Parameters.AddWithValue("p_RFC", txtRFC.Text);
                        comando.ExecuteNonQuery();
                    }
                    conexion.Close();
                }

                MessageBox.Show("Proveedor insertado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar insertar el proveedor. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Program.ConnectionString))
                {
                    connection.Open();
                    using (MySqlCommand comando = new MySqlCommand("ObtenerProveedores", connection))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                        {
                            DataTable tablaProveedores = new DataTable();
                            adaptador.Fill(tablaProveedores);
                            dgvProveedores.DataSource = tablaProveedores;
                        }
                    }
                    connection.Close();
                }
                MessageBox.Show("Proveedores obtenidos exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar obtener Proveedores. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool ValidacionTxtID()
        {
            return !string.IsNullOrWhiteSpace(IDTextBox.Text) &&
                   !string.IsNullOrWhiteSpace(txtNombre.Text) &&
                   !string.IsNullOrWhiteSpace(txtTelefono.Text) &&
                   !string.IsNullOrWhiteSpace(txtRFC.Text) &&
                   !string.IsNullOrWhiteSpace(txtDireccion.Text);
        }

        private void BtnActualir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidacionTxtID())
                {
                    MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtTelefono.Text.Length != 10)
                {
                    MessageBox.Show("Faltan o tiene más de 10 dígitos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtTelefono.Focus();
                }
                else
                {
                    using (MySqlConnection connection = new MySqlConnection(Program.ConnectionString))
                    {
                        connection.Open();
                        using (MySqlCommand comando = new MySqlCommand("ActualizarProveedor", connection))
                        {
                            comando.CommandType = CommandType.StoredProcedure;
                            comando.Parameters.AddWithValue("p_IdProveedor", int.Parse(IDTextBox.Text));
                            comando.Parameters.AddWithValue("p_Nombre", txtNombre.Text);
                            comando.Parameters.AddWithValue("p_Telefono", txtTelefono.Text);
                            comando.Parameters.AddWithValue("p_Direccion", txtDireccion.Text);
                            comando.Parameters.AddWithValue("p_RFC", txtRFC.Text);
                            comando.ExecuteNonQuery();
                        }
                        connection.Close();
                    }
                    MessageBox.Show("Proveedor actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar actualizar el proveedor. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
