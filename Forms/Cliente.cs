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
    public partial class Cliente : Form
    {
        public Cliente()
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
                if (string.IsNullOrEmpty(TxtNombre.Text) && string.IsNullOrEmpty(txtEmail.Text) && string.IsNullOrEmpty(txtTelefono.Text))
                {
                    MessageBox.Show("Faltan campos por ingresar");
                }
                else if (txtTelefono.Text.Length != 10)
                {
                    MessageBox.Show("Faltan o tiene más de 10 dígitos", "Ingrese su Número a 10 dígitos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtTelefono.Focus();
                }
                else
                {
                    using (MySqlConnection connection = new MySqlConnection(Program.ConnectionString))
                    {
                        connection.Open();

                        using (MySqlCommand comando = new MySqlCommand("InsertarCliente", connection))
                        {
                            comando.CommandType = CommandType.StoredProcedure;
                            comando.Parameters.AddWithValue("p_Nombre", TxtNombre.Text);
                            comando.Parameters.AddWithValue("p_Email", txtEmail.Text);
                            comando.Parameters.AddWithValue("p_Telefono", txtTelefono.Text);

                            MySqlParameter nuevoIdParam = new MySqlParameter("p_NuevoID", MySqlDbType.Int32);
                            nuevoIdParam.Direction = ParameterDirection.Output;
                            comando.Parameters.Add(nuevoIdParam);

                            comando.ExecuteNonQuery();

                            int nuevoId = Convert.ToInt32(nuevoIdParam.Value);
                            MessageBox.Show($"Cliente agregado exitosamente. Nuevo ID: {nuevoId}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar agregar el cliente. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IDTextBox.Text))
            {
                MessageBox.Show("Faltan campos por ingresar");
            }
            else
            {
                if (int.TryParse(IDTextBox.Text, out int idCliente))
                {
                    try
                    {
                        using (MySqlConnection connection = new MySqlConnection(Program.ConnectionString))
                        {
                            connection.Open();

                            using (MySqlCommand comando = new MySqlCommand("ObtenerClientesF", connection))
                            {
                                comando.CommandType = CommandType.StoredProcedure;
                                comando.Parameters.AddWithValue("p_IdCliente", idCliente);
                                using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                                {
                                    DataTable tablaClientes = new DataTable();
                                    adaptador.Fill(tablaClientes);
                                    dgvClientes.DataSource = tablaClientes;
                                }
                            }
                        }

                        MessageBox.Show("Clientes obtenidos exitosamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al intentar obtener los clientes. Detalles: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("El ID del cliente debe ser un número entero válido.");
                }
            }

        }

        private void BtnActualir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNombre.Text) && string.IsNullOrEmpty(txtEmail.Text) && string.IsNullOrEmpty(txtTelefono.Text) && string.IsNullOrEmpty(IDTextBox.Text))
            {
                MessageBox.Show("Faltan campos por ingresar");
            }
            else if (txtTelefono.Text.Length != 10)
            {
                MessageBox.Show("El número de teléfono debe tener 10 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTelefono.Focus();
            }
            else
            {
                try
                {
                    if (int.TryParse(IDTextBox.Text, out int idCliente))
                    {
                        using (MySqlConnection conexion = new MySqlConnection(Program.ConnectionString))
                        {
                            conexion.Open();
                            using (MySqlCommand comando = new MySqlCommand("ActualizarCliente", conexion))
                            {
                                comando.CommandType = CommandType.StoredProcedure;
                                comando.Parameters.AddWithValue("p_IdCliente", idCliente);
                                comando.Parameters.AddWithValue("p_Nombre", TxtNombre.Text);
                                comando.Parameters.AddWithValue("p_Email", txtEmail.Text);
                                comando.Parameters.AddWithValue("p_Telefono", txtTelefono.Text);
                                comando.ExecuteNonQuery();
                            }
                            conexion.Close();
                        }
                        MessageBox.Show("Cliente actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El ID del cliente no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar actualizar el cliente. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void AgregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnAgregar.Visible = true;
            BtnActualir.Visible = false;
            BtnMostrar.Visible = false;
            IDTextBox.Visible = false;
        }

        private void MostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnMostrar.Visible = true;
            BtnAgregar.Visible = false;
            BtnActualir.Visible = false;
            IDTextBox.Visible = true;
        }

        private void ActualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnMostrar.Visible = true;
            BtnAgregar.Visible = false;
            BtnActualir.Visible = true;
            IDTextBox.Visible = false;
        }

        private void LimpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtTelefono.Clear();
            TxtNombre.Clear();
            IDTextBox.Clear();
        }

        private void GeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Program.ConnectionString))
                {
                    connection.Open();
                    using (MySqlCommand comando = new MySqlCommand("ObtenerClientes", connection))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                        {
                            DataTable tablaClientes = new DataTable();
                            adaptador.Fill(tablaClientes);
                            dgvClientes.DataSource = tablaClientes;
                        }
                    }
                }
                MessageBox.Show("Clientes obtenidas exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar obtener clientes. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            //DataTable dataTable = new DataTable();
            //dataTable.Columns.Add("IdCliente", typeof(int));
            //dataTable.Columns.Add("Nombre", typeof(string));
            //dataTable.Columns.Add("Email", typeof(string));
            //dataTable.Columns.Add("Telefono", typeof(string));
            //dgvClientes.DataSource = dataTable;
        }
    }
}