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
    public partial class InicioSesion : Form
    {
        public string valTxtUsuario;
        private string connectionString = "server=localhost; database=Almacen; uid=root; pwd=R0bert541;";
        public InicioSesion()
        {
            InitializeComponent();
        }
        public static string VarTtxUser { get; set; }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
           
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand comando = new MySqlCommand("VerificarLogin", connection))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@p_Nombre", TxtNombre.Text);
                        comando.Parameters.AddWithValue("@p_RFCDesencriptado", TxtRFC.Text);
                        string resultado = Convert.ToString(comando.ExecuteScalar());

                        if (resultado == "Login exitoso")
                        {
                            MessageBox.Show("¡Login exitoso!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            VarTtxUser = TxtNombre.Text;
                            FrmMenu formularioDestino = new FrmMenu();
                            formularioDestino.Show();
                            this.Hide();
                                                    }
                        else
                        {
                            resultado = "Credenciales inválidas";
                            MessageBox.Show("Credenciales inválidas. Por favor, inténtelo de nuevo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar iniciar sesión. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LimpiarTxtRFC()
        {
            TxtRFC.Clear();
        }
        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
