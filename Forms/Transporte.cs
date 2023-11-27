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
    public partial class Transporte : Form
    {
        public Transporte()
        {
            InitializeComponent();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            this.Hide();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidacionTxts())
                {
                    MessageBox.Show("Faltan campos por ingresar o los datos son inválidos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    using (MySqlConnection conexion = new MySqlConnection(Program.ConnectionString))
                    {
                        conexion.Open();
                        using (MySqlCommand comando = new MySqlCommand("InsertarTransporte", conexion))
                        {
                            comando.CommandType = CommandType.StoredProcedure;
                            comando.Parameters.AddWithValue("p_Nombre", txtNombre.Text);
                            comando.Parameters.AddWithValue("p_Tipo", TxtTipo.Text);
                            comando.Parameters.AddWithValue("p_CapacidadKg", int.Parse(TxtCapacidad.Text));
                            comando.Parameters.AddWithValue("p_NumeroPlaca", TxtPlaca.Text);
                            comando.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Transporte insertado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar insertar el transporte. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(Program.ConnectionString))
                {
                    conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand("ObtenerTransportes", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                        {
                            DataTable tablaTransportes = new DataTable();
                            adaptador.Fill(tablaTransportes);
                            dgvTransporte.DataSource = tablaTransportes;
                           
                        }
                    }
                }
                MessageBox.Show("Transportes obtenidos exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar obtener los transportes. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnActualir_Click(object sender, EventArgs e)
        {
            IDTextBox.Visible = true;
            try
            {
                if (ValidacionTxtID())
                {
                    using (MySqlConnection conexion = new MySqlConnection(Program.ConnectionString))
                    {
                        conexion.Open();
                        using (MySqlCommand comando = new MySqlCommand("ActualizarTransporte", conexion))
                        {
                            comando.CommandType = CommandType.StoredProcedure;
                            comando.Parameters.AddWithValue("p_IDTransporte", int.Parse(IDTextBox.Text));
                            comando.Parameters.AddWithValue("p_Nombre", txtNombre.Text);
                            comando.Parameters.AddWithValue("p_Tipo", TxtTipo.Text);
                            comando.Parameters.AddWithValue("p_CapacidadKg", int.Parse(TxtCapacidad.Text));
                            comando.Parameters.AddWithValue("p_NumeroPlaca", TxtPlaca.Text);
                            comando.ExecuteNonQuery();
                        }
                        conexion.Close();
                    }
                    MessageBox.Show("Transporte actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar actualizar el transporte. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool ValidacionTxts()
        {
            return !string.IsNullOrWhiteSpace(txtNombre.Text) &&
                   int.TryParse(TxtCapacidad.Text, out _) &&
                   !string.IsNullOrWhiteSpace(TxtPlaca.Text) &&
                   !string.IsNullOrWhiteSpace(TxtTipo.Text);
        }
        private bool ValidacionTxtID()
        {
            return int.TryParse(IDTextBox.Text, out _) &&
                   !string.IsNullOrWhiteSpace(txtNombre.Text) &&
                   int.TryParse(TxtCapacidad.Text, out _) &&
                   !string.IsNullOrWhiteSpace(TxtPlaca.Text) &&
                   !string.IsNullOrWhiteSpace(TxtTipo.Text);
        }
        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            IDTextBox.Visible = true;
            try
            {
                if (string.IsNullOrEmpty(IDTextBox.Text))
                {
                    MessageBox.Show("Debe ingresar un transporte para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                using (MySqlConnection conexion = new MySqlConnection(Program.ConnectionString))
                {
                    conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand("EliminarTransporte", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("p_IDTransporte", int.Parse(IDTextBox.Text));
                        comando.ExecuteNonQuery();
                    }
                    conexion.Close();
                }
                MessageBox.Show("Transporte eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar eliminar el transporte. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Transporte_Load(object sender, EventArgs e)
        {
            IDTextBox.Visible = false;
        }
    }
}
