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
    public partial class Pedidos : Form
    {
        public int UltimoID { get; set; }
        public Pedidos()
        {
            InitializeComponent();
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            TxtFecha();
            //Label1.Visible = false;
            //TxtIDPedido.Visible = false;
            LlenarCbClienteN();
        }
        private void LlenarCbClienteN()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Program.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT Nombre FROM Cliente";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            List<string> listaClientes = new List<string>();
                            while (reader.Read())
                            {
                                string nombreCliente = reader["Nombre"].ToString();
                                listaClientes.Add(nombreCliente);
                            }
                            CBNombreC.DataSource = listaClientes;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los nombres de los clientes. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtFecha()
        {
            DateTime fechaActual = DateTime.Now;
            string fechaFormateada = fechaActual.ToString("dd/MM/yyyy");
            txtFechaPedido.Text = fechaFormateada;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtClienteID.Text))
                {
                    MessageBox.Show("Faltan campos por ingresar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClienteID.Focus();
                    return;
                }

                if (!int.TryParse(txtClienteID.Text, out int clienteID))
                {
                    MessageBox.Show("El ClienteID debe ser un número entero válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (MySqlConnection connection = new MySqlConnection(Program.ConnectionString))
                {
                    connection.Open();

                    using (MySqlCommand comando = new MySqlCommand("InsertarPedidoID", connection))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("p_FechaPedido", txtFechaPedido.Text);
                        comando.Parameters.AddWithValue("p_ClienteID", clienteID);
                        MySqlParameter parametroUltimoID = new MySqlParameter("p_UltimoID", MySqlDbType.Int32);
                        parametroUltimoID.Direction = ParameterDirection.Output;
                        comando.Parameters.Add(parametroUltimoID);
                        comando.ExecuteNonQuery();
                        UltimoID = Convert.ToInt32(parametroUltimoID.Value);
                    }
                }
                TxtIDPedido.Text = UltimoID.ToString();
                MessageBox.Show("Pedido insertado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DetPedido detPedidoForm = new DetPedido();
                detPedidoForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar insertar el Pedido. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Program.ConnectionString))
                {
                    connection.Open();
                    using (MySqlCommand comando = new MySqlCommand("ObtenerPedidos", connection))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                        {
                            DataTable tablaPedidos = new DataTable();
                            adaptador.Fill(tablaPedidos);
                            dgvPedidos.DataSource = tablaPedidos;
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

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            this.Hide();
        }

        private void CBNombreC_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarTxtIDCliente();
        }
        private void CargarTxtIDCliente()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Program.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT IdCliente FROM Cliente WHERE Nombre = @nombre;";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", CBNombreC.SelectedItem);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int IdCliente = Convert.ToInt32(reader["IdCliente"]);
                                txtClienteID.Text = IdCliente.ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el ID del cliente. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
