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
    public partial class Compras : Form
    {
        public int ultimoID { get; set; }
        public Compras()
        {
            InitializeComponent();
        }
        private bool ValidacionTxtID()

        {
            return int.TryParse(txtProvID.Text, out _) &&
                   int.TryParse(TxtEmpId.Text, out _);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidacionTxtID())
                {
                    MessageBox.Show("Faltan campos por ingresar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    using (MySqlConnection conexion = new MySqlConnection(Program.ConnectionString))
                    {
                        conexion.Open();
                        using (MySqlCommand comando = new MySqlCommand("InsertarCompraID", conexion))
                        {
                            comando.CommandType = CommandType.StoredProcedure;
                            comando.Parameters.AddWithValue("p_FechaCompra", txtFechaPedido.Text);
                            comando.Parameters.AddWithValue("p_ProveedorID", int.Parse(txtProvID.Text));
                            comando.Parameters.AddWithValue("p_EmpleadoID", int.Parse(TxtEmpId.Text));

                            MySqlParameter parametroUltimoID = new MySqlParameter("@UltimoID", MySqlDbType.Int32);
                            parametroUltimoID.Direction = ParameterDirection.Output;
                            comando.Parameters.Add(parametroUltimoID);
                            comando.ExecuteNonQuery();
                            ultimoID = Convert.ToInt32(parametroUltimoID.Value);
                            TxtIDCompra.Text = ultimoID.ToString();
                        }
                        conexion.Close();
                    }
                    MessageBox.Show("Compra registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DetCompra frmCompra = new DetCompra();
                    frmCompra.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar insertar la compra. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Program.ConnectionString))
                {
                    connection.Open();
                    using (MySqlCommand comando = new MySqlCommand("ObtenerCompras", connection))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                        {
                            DataTable tablaPedidos = new DataTable();
                            adaptador.Fill(tablaPedidos);
                            dgvCompras.DataSource = tablaPedidos;
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las compras. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            this.Hide();
        }

        private void Compras_Load(object sender, EventArgs e)
        {

        }
    }
}
