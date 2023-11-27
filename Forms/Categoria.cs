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
    public partial class Categoria : Form
    {
       
        public Categoria()
        {
            InitializeComponent();
        }
    private void BtnAgregar_Click(object sender, EventArgs e)
    {
        try
        {
            if (!string.IsNullOrEmpty(TxtCategoria.Text))
            {
                using (MySqlConnection connection = new MySqlConnection(Program.ConnectionString))
                {
                    connection.Open();

                    using (MySqlCommand comando = new MySqlCommand("InsertarCategoria", connection))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("p_TipoCategoria", TxtCategoria.Text);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Categoría insertada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Falta ingresar el tipo de categoría.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al intentar insertar categoría. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void Categoria_Load(object sender, EventArgs e)
        {

        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Program.ConnectionString))
                {
                    connection.Open();
                    using (MySqlCommand comando = new MySqlCommand("ObtenerCategorias", connection))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                        {
                            DataTable tablaCategorias = new DataTable();
                            adaptador.Fill(tablaCategorias);
                            dgvCategorias.DataSource = tablaCategorias;
                        }
                    }
                }
                MessageBox.Show("Categorías obtenidas exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar obtener categorías. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnActualir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(IDTextBox.Text) && !string.IsNullOrEmpty(TxtCategoria.Text))
                {
                    using (MySqlConnection connection = new MySqlConnection(Program.ConnectionString))
                    {
                        connection.Open();
                        using (MySqlCommand comando = new MySqlCommand("ActualizarCategoria", connection))
                        {
                            comando.CommandType = CommandType.StoredProcedure;
                            comando.Parameters.AddWithValue("p_IdCategoria", int.Parse(IDTextBox.Text));
                            comando.Parameters.AddWithValue("p_TipoCategoria", TxtCategoria.Text);
                            comando.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Categoría actualizada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falta ingresar el ID de la categoría o el tipo de categoría.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar actualizar categoría. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
