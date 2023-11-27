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
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            this.Hide();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            BtnActualir.Visible = false;
            BtnAgregar.Visible = false;
            BtnBorrar.Visible = false;
        }
        private bool ValidacionTxts()
        {
            return string.IsNullOrWhiteSpace(TxtNombre.Text) ||
                   string.IsNullOrWhiteSpace(TxtEdad.Text) ||
                   string.IsNullOrWhiteSpace(txtRfc.Text) ||
                   string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                   string.IsNullOrWhiteSpace(txtcurp.Text) ||
                   string.IsNullOrWhiteSpace(TxtNss.Text) ||
                   string.IsNullOrWhiteSpace(TxtPuesto.Text) ||
                   string.IsNullOrWhiteSpace(TxtIdSucursal.Text);
        }
        private bool ValidacionTxtID()
        {
            return string.IsNullOrWhiteSpace(IDTextBox.Text) ||
                   string.IsNullOrWhiteSpace(TxtEdad.Text) ||
                   string.IsNullOrWhiteSpace(txtRfc.Text) ||
                   string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                   string.IsNullOrWhiteSpace(txtcurp.Text) ||
                   string.IsNullOrWhiteSpace(TxtNss.Text) ||
                   string.IsNullOrWhiteSpace(TxtPuesto.Text) ||
                   string.IsNullOrWhiteSpace(TxtIdSucursal.Text);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidacionTxts())
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
                    using (MySqlConnection connection = new MySqlConnection(Program.ConnectionString))
                    {
                        connection.Open();
                        using (MySqlCommand comando = new MySqlCommand("InsertarEmpleadoEncriptado", connection))
                        {
                            comando.CommandType = CommandType.StoredProcedure;
                            comando.Parameters.AddWithValue("p_Nombre", TxtNombre.Text);
                            comando.Parameters.AddWithValue("p_Edad", TxtEdad.Text);
                            comando.Parameters.AddWithValue("p_RFC", txtRfc.Text);
                            comando.Parameters.AddWithValue("p_Telefono", txtTelefono.Text);
                            comando.Parameters.AddWithValue("p_CURP", txtcurp.Text);
                            comando.Parameters.AddWithValue("p_NSS", TxtNss.Text);
                            comando.Parameters.AddWithValue("p_Puesto", TxtPuesto.Text);
                            comando.Parameters.AddWithValue("p_IDSucursal", TxtIdSucursal.Text);
                            comando.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Empleado insertado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar insertar empleado. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

      

        private void BtnActualir_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidacionTxtID())
                {
                    using (MySqlConnection connection = new MySqlConnection(Program.ConnectionString))
                    {
                        connection.Open();
                        using (MySqlCommand comando = new MySqlCommand("ActualizarEmpleado", connection))
                        {
                            comando.CommandType = CommandType.StoredProcedure;
                            comando.Parameters.AddWithValue("p_IdEmpleado", int.Parse(IDTextBox.Text));
                            comando.Parameters.AddWithValue("p_Nombre", TxtNombre.Text);
                            comando.Parameters.AddWithValue("p_Edad", TxtEdad.Text);
                            comando.Parameters.AddWithValue("p_RFC", txtRfc.Text);
                            comando.Parameters.AddWithValue("p_Telefono", txtTelefono.Text);
                            comando.Parameters.AddWithValue("p_CURP", txtcurp.Text);
                            comando.Parameters.AddWithValue("p_NSS", TxtNss.Text);
                            comando.Parameters.AddWithValue("p_Puesto", TxtPuesto.Text);
                            comando.Parameters.AddWithValue("p_IDSucursal", TxtIdSucursal.Text);
                            comando.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Empleado actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Faltan campos por ingresar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar actualizar empleado. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(IDTextBox.Text))
                {
                    using (MySqlConnection connection = new MySqlConnection(Program.ConnectionString))
                    {
                        connection.Open();
                        using (MySqlCommand comando = new MySqlCommand("EliminarEmpleado", connection))
                        {
                            comando.CommandType = CommandType.StoredProcedure;
                            comando.Parameters.AddWithValue("p_IdEmpleado", int.Parse(IDTextBox.Text));
                            comando.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Empleado eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falta ingresar el ID del empleado a eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar eliminar empleado. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AgregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnAgregar.Visible = true;
            BtnActualir.Visible = false;
            IDTextBox.Visible = false;
        }

        private void MostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnAgregar.Visible = false;
            BtnActualir.Visible = false;
            IDTextBox.Visible = true;
        }

        private void ActualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnAgregar.Visible = false;
            BtnActualir.Visible = true;
            IDTextBox.Visible = false;
        }

        private void LimpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtcurp.Clear();
            txtTelefono.Clear();
            TxtNombre.Clear();
            IDTextBox.Clear();
            txtRfc.Clear();
            TxtEdad.Clear();
            TxtIdSucursal.Clear();
            TxtNss.Clear();
            TxtPuesto.Clear(); 
           
        }

        private void GeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Program.ConnectionString))
                {
                    connection.Open();
                    using (MySqlCommand comando = new MySqlCommand("ObtenerEmpleadosG", connection))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                        DataTable tablaEmpleados = new DataTable();
                        adaptador.Fill(tablaEmpleados);
                        dgvEmpleado.DataSource = tablaEmpleados;
                    }
                    connection.Close();
                }
                MessageBox.Show("Empleados obtenidos exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar obtener empleados. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
