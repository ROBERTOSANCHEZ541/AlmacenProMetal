using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlmacenProMetal.Forms
{
    public partial class Sucursales : Form
    {
        public Sucursales()
        {
            InitializeComponent();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            this.Hide();
        }
        private bool ValidacionTxts()
        {
            return !string.IsNullOrWhiteSpace(TxtSucursal.Text) &&
                   !string.IsNullOrWhiteSpace(txtDireccion.Text) &&
                   !string.IsNullOrWhiteSpace(txtTelefono.Text) &&
                   !string.IsNullOrWhiteSpace(txtCp.Text) &&
                   !string.IsNullOrWhiteSpace(TxtCiudad.Text);
        }

        private bool ValidacionTxtID()
        {
            return !string.IsNullOrWhiteSpace(IDTextBox.Text) &&
                   !string.IsNullOrWhiteSpace(TxtSucursal.Text) &&
                   !string.IsNullOrWhiteSpace(txtDireccion.Text) &&
                   !string.IsNullOrWhiteSpace(txtTelefono.Text) &&
                   !string.IsNullOrWhiteSpace(txtCp.Text) &&
                   !string.IsNullOrWhiteSpace(TxtCiudad.Text);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidacionTxts())
                {
                    MessageBox.Show("Faltan campos por ingresar");
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
                        using (MySqlCommand comando = new MySqlCommand("InsertarSucursal", connection))
                        {
                            comando.CommandType = CommandType.StoredProcedure;
                            comando.Parameters.AddWithValue("p_NombreSucursal", TxtSucursal.Text);
                            comando.Parameters.AddWithValue("p_Direccion", txtDireccion.Text);
                            comando.Parameters.AddWithValue("P_Ciudad", TxtCiudad.Text);
                            comando.Parameters.AddWithValue("p_CodigoPostal", txtCp.Text);
                            comando.Parameters.AddWithValue("p_elefono", txtTelefono.Text);
                            comando.ExecuteNonQuery();
                        }
                        connection.Close();
                    }
                    MessageBox.Show("Sucursal insertada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar insertar sucursal. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Program.ConnectionString))
                {
                    connection.Open();
                    using (MySqlCommand comando = new MySqlCommand("ObtenerSucursales", connection))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                        {
                            DataTable tablaSucursales = new DataTable();
                            adaptador.Fill(tablaSucursales);
                            dgvSucursales.DataSource = tablaSucursales;
                        }
                    }
                }
                MessageBox.Show("Sucursales obtenidas exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las sucursales. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnActualir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidacionTxtID())
                {
                    MessageBox.Show("Faltan campos por ingresar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        using (MySqlCommand comando = new MySqlCommand("ActualizarSucursal", connection))
                        {
                            comando.CommandType = CommandType.StoredProcedure;
                            comando.Parameters.AddWithValue("p_IDSucursal", IDTextBox.Text);
                            comando.Parameters.AddWithValue("p_NombreSucursal", TxtSucursal.Text);
                            comando.Parameters.AddWithValue("p_Direccion", txtDireccion.Text);
                            comando.Parameters.AddWithValue("p_Ciudad", TxtCiudad.Text);
                            comando.Parameters.AddWithValue("p_CodigoPostal", txtCp.Text);
                            comando.Parameters.AddWithValue("p_Telefono", txtTelefono.Text);
                            comando.ExecuteNonQuery();
                        }
                        connection.Close();
                    }
                    MessageBox.Show("Sucursal actualizada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar actualizar la sucursal. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
