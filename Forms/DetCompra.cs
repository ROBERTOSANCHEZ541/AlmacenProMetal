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
    public partial class DetCompra : Form
    {
        public DetCompra()
        {
            InitializeComponent();
        }

        private bool ValidacionTxtID()
        {
            return !int.TryParse(txtIdTransporte.Text, out _) &&
                   !int.TryParse(TxtIdCompra.Text, out _) &&
                   !decimal.TryParse(TxtPrecio.Text, out _) &&
                   !int.TryParse(TxtStock.Text, out _);
        }
        private void ActualizarProducto()
        {
            decimal stock = decimal.Parse(TxtStock.Text);
            decimal cantidad = decimal.Parse(TxtCantidad.Text);
            decimal totalStock = stock + cantidad;
            TxtRestante.Text = totalStock.ToString();
            try
            {
                if (!ValidacionTxtID())
                {
                    MessageBox.Show("Faltan campos por ingresar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
                    {
                        connection.Open();
                        using (SqlCommand comando = new SqlCommand("ActualizarProducto1", connection))
                        {
                            comando.CommandType = CommandType.StoredProcedure;
                            comando.Parameters.AddWithValue("p_IdArticulo", CbIdProduct.SelectedItem);
                            comando.Parameters.AddWithValue("p_NombreProducto", CbProductosN.SelectedItem);
                            comando.Parameters.AddWithValue("p_Precio", decimal.Parse(TxtPrecio.Text));
                            comando.Parameters.AddWithValue("p_Stock", decimal.Parse(TxtRestante.Text));
                            comando.ExecuteNonQuery();
                        }
                        connection.Close();
                    }
                    MessageBox.Show("Producto actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar actualizar el producto. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            ActualizarProducto();
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
                        using (MySqlCommand comando = new MySqlCommand("InsertarDetalleCompra", conexion))
                        {
                            comando.CommandType = CommandType.StoredProcedure;
                            comando.Parameters.AddWithValue("@p_CompraID", int.Parse(TxtIdCompra.Text));
                            comando.Parameters.AddWithValue("@p_ProductoID", int.Parse(CbIdProduct.SelectedItem.ToString()));
                            comando.Parameters.AddWithValue("@p_IDTransporte", int.Parse(txtIdTransporte.Text));
                            comando.Parameters.AddWithValue("@p_Cantidad", int.Parse(TxtCantidad.Text));
                            comando.Parameters.AddWithValue("@p_PrecioUnitario", decimal.Parse(TxtTotal.Text));
                            comando.ExecuteNonQuery();
                        }
                        conexion.Close();
                    }
                    MessageBox.Show("Detalle de compra registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar insertar el detalle de compra. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Program.ConnectionString))
                {
                    connection.Open();
                    using (MySqlCommand comando = new MySqlCommand("ObtenerDetallesCompra", connection))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                        {
                            DataTable tablaDTCompra = new DataTable();
                            adaptador.Fill(tablaDTCompra);
                            dgvDTCompra.DataSource = tablaDTCompra;
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los Detalles de las Compras. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            this.Hide();
        }
        private void LlenarCbProductosN()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Program.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT NombreProducto FROM Productos";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            List<string> listaProductos = new List<string>();
                            while (reader.Read())
                            {
                                string nombreProducto = reader["NombreProducto"].ToString();
                                listaProductos.Add(nombreProducto);
                            }
                            CbProductosN.DataSource = listaProductos;
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los nombres de los productos. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LlenarCTranspN()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Program.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT Nombre FROM Transporte";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            List<string> listaTransp = new List<string>();
                            while (reader.Read())
                            {
                                string nombreTransp = reader["Nombre"].ToString();
                                listaTransp.Add(nombreTransp);
                            }
                            CBTransp.DataSource = listaTransp;
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los nombres de los transportes. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DetCompra_Load(object sender, EventArgs e)
        {
            Compras IdCompras = new Compras();
            TxtIdCompra.Text = IdCompras.ultimoID.ToString();
            LlenarCbProductosN();
            LlenarCTranspN();
            TxtRestante.Visible = false;
        }
        private void CargarPrecio()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Program.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT precio, Stock FROM Productos WHERE IdArticulo = @IdArticulo;";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdArticulo", CbIdProduct.SelectedItem);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int precio = Convert.ToInt32(reader["precio"]);
                                int stock = Convert.ToInt32(reader["Stock"]);
                                TxtPrecio.Text = precio.ToString();
                                TxtStock.Text = stock.ToString();
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el precio y stock del producto. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CargarPrecio();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            decimal precio = decimal.Parse(TxtPrecio.Text);
            decimal cantidad = decimal.Parse(TxtCantidad.Text);
            decimal total = precio * cantidad;
            TxtTotal.Text = total.ToString();
        }
        private void LlenarCbProductosID()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Program.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT IdArticulo FROM Productos WHERE NombreProducto = @NombreProducto;";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NombreProducto", CbProductosN.SelectedItem);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            List<string> listaProductosID = new List<string>();
                            while (reader.Read())
                            {
                                string IDProducto = reader["IdArticulo"].ToString();
                                listaProductosID.Add(IDProducto);
                            }
                            CbIdProduct.DataSource = listaProductosID;
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los ID de los productos. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbProductosN_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarCbProductosID();
        }
        private void CargarTxtIDtransp()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Program.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT IDTransporte FROM Transporte WHERE Nombre = @nombre;";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", CBTransp.SelectedItem);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int Idtransp = Convert.ToInt32(reader["IDTransporte"]);
                                txtIdTransporte.Text = Idtransp.ToString();
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el ID de transporte. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CBTransp_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarTxtIDtransp();
        }
    }
}
