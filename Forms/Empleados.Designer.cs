namespace AlmacenProMetal.Forms
{
    partial class Empleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label Label1;
            System.Windows.Forms.Label IDLabel;
            this.BtnMenu = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.TxtPuesto = new System.Windows.Forms.TextBox();
            this.lbpuesto = new System.Windows.Forms.Label();
            this.TxtIdSucursal = new System.Windows.Forms.TextBox();
            this.lbIdSucursal = new System.Windows.Forms.Label();
            this.txtcurp = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtRfc = new System.Windows.Forms.TextBox();
            this.lbrfc = new System.Windows.Forms.Label();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.lbEdad = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.BtnActualir = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.dgvEmpleado = new System.Windows.Forms.DataGridView();
            this.lbNombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LBTel = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.TxtNss = new System.Windows.Forms.TextBox();
            this.LbNss = new System.Windows.Forms.Label();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AgregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ActualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LimpiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            Label1 = new System.Windows.Forms.Label();
            IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).BeginInit();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label1.Location = new System.Drawing.Point(168, 83);
            Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(45, 16);
            Label1.TabIndex = 184;
            Label1.Text = "Ej:(1204)";
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            IDLabel.Location = new System.Drawing.Point(14, 83);
            IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new System.Drawing.Size(24, 13);
            IDLabel.TabIndex = 182;
            IDLabel.Text = "ID:";
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnMenu.Location = new System.Drawing.Point(745, 32);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(43, 23);
            this.BtnMenu.TabIndex = 197;
            this.BtnMenu.Text = "Menu";
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Location = new System.Drawing.Point(183, 385);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(75, 23);
            this.BtnBorrar.TabIndex = 196;
            this.BtnBorrar.Text = "borrar";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // TxtPuesto
            // 
            this.TxtPuesto.Location = new System.Drawing.Point(80, 313);
            this.TxtPuesto.Name = "TxtPuesto";
            this.TxtPuesto.Size = new System.Drawing.Size(249, 20);
            this.TxtPuesto.TabIndex = 195;
            // 
            // lbpuesto
            // 
            this.lbpuesto.AutoSize = true;
            this.lbpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpuesto.Location = new System.Drawing.Point(13, 313);
            this.lbpuesto.Name = "lbpuesto";
            this.lbpuesto.Size = new System.Drawing.Size(45, 13);
            this.lbpuesto.TabIndex = 194;
            this.lbpuesto.Text = "puesto";
            // 
            // TxtIdSucursal
            // 
            this.TxtIdSucursal.Location = new System.Drawing.Point(80, 339);
            this.TxtIdSucursal.Name = "TxtIdSucursal";
            this.TxtIdSucursal.Size = new System.Drawing.Size(249, 20);
            this.TxtIdSucursal.TabIndex = 193;
            // 
            // lbIdSucursal
            // 
            this.lbIdSucursal.AutoSize = true;
            this.lbIdSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdSucursal.Location = new System.Drawing.Point(9, 342);
            this.lbIdSucursal.Name = "lbIdSucursal";
            this.lbIdSucursal.Size = new System.Drawing.Size(69, 13);
            this.lbIdSucursal.TabIndex = 192;
            this.lbIdSucursal.Text = "IDSucursal";
            // 
            // txtcurp
            // 
            this.txtcurp.Location = new System.Drawing.Point(77, 255);
            this.txtcurp.Name = "txtcurp";
            this.txtcurp.Size = new System.Drawing.Size(249, 20);
            this.txtcurp.TabIndex = 191;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(10, 255);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(32, 13);
            this.Label2.TabIndex = 190;
            this.Label2.Text = "curp";
            // 
            // txtRfc
            // 
            this.txtRfc.Location = new System.Drawing.Point(77, 188);
            this.txtRfc.Name = "txtRfc";
            this.txtRfc.Size = new System.Drawing.Size(249, 20);
            this.txtRfc.TabIndex = 189;
            // 
            // lbrfc
            // 
            this.lbrfc.AutoSize = true;
            this.lbrfc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrfc.Location = new System.Drawing.Point(10, 188);
            this.lbrfc.Name = "lbrfc";
            this.lbrfc.Size = new System.Drawing.Size(22, 13);
            this.lbrfc.TabIndex = 188;
            this.lbrfc.Text = "rfc";
            // 
            // TxtEdad
            // 
            this.TxtEdad.Location = new System.Drawing.Point(77, 149);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(249, 20);
            this.TxtEdad.TabIndex = 187;
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdad.Location = new System.Drawing.Point(10, 149);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(35, 13);
            this.lbEdad.TabIndex = 186;
            this.lbEdad.Text = "edad";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(66, 83);
            this.IDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(78, 20);
            this.IDTextBox.TabIndex = 183;
            // 
            // BtnActualir
            // 
            this.BtnActualir.Location = new System.Drawing.Point(102, 385);
            this.BtnActualir.Name = "BtnActualir";
            this.BtnActualir.Size = new System.Drawing.Size(75, 23);
            this.BtnActualir.TabIndex = 181;
            this.BtnActualir.Text = "Actualizar";
            this.BtnActualir.UseVisualStyleBackColor = true;
            this.BtnActualir.Click += new System.EventHandler(this.BtnActualir_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(21, 385);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 179;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.AllowUserToAddRows = false;
            this.dgvEmpleado.AllowUserToDeleteRows = false;
            this.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleado.Location = new System.Drawing.Point(376, 100);
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.ReadOnly = true;
            this.dgvEmpleado.Size = new System.Drawing.Size(397, 331);
            this.dgvEmpleado.TabIndex = 178;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(10, 113);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(50, 13);
            this.lbNombre.TabIndex = 177;
            this.lbNombre.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(66, 110);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(290, 20);
            this.TxtNombre.TabIndex = 176;
            // 
            // LBTel
            // 
            this.LBTel.AutoSize = true;
            this.LBTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTel.Location = new System.Drawing.Point(10, 221);
            this.LBTel.Name = "LBTel";
            this.LBTel.Size = new System.Drawing.Size(57, 13);
            this.LBTel.TabIndex = 175;
            this.LBTel.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(77, 221);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(249, 20);
            this.txtTelefono.TabIndex = 174;
            // 
            // TxtNss
            // 
            this.TxtNss.Location = new System.Drawing.Point(77, 281);
            this.TxtNss.Name = "TxtNss";
            this.TxtNss.Size = new System.Drawing.Size(249, 20);
            this.TxtNss.TabIndex = 173;
            // 
            // LbNss
            // 
            this.LbNss.AutoSize = true;
            this.LbNss.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNss.Location = new System.Drawing.Point(10, 281);
            this.LbNss.Name = "LbNss";
            this.LbNss.Size = new System.Drawing.Size(32, 13);
            this.LbNss.TabIndex = 172;
            this.LbNss.Text = "NSS";
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AgregarToolStripMenuItem,
            this.ActualizarToolStripMenuItem,
            this.LimpiarToolStripMenuItem,
            this.GeneralToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(800, 24);
            this.MenuStrip1.TabIndex = 185;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // AgregarToolStripMenuItem
            // 
            this.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem";
            this.AgregarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.AgregarToolStripMenuItem.Text = "Agregar";
            this.AgregarToolStripMenuItem.Click += new System.EventHandler(this.AgregarToolStripMenuItem_Click);
            // 
            // ActualizarToolStripMenuItem
            // 
            this.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem";
            this.ActualizarToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.ActualizarToolStripMenuItem.Text = "Actualizar";
            this.ActualizarToolStripMenuItem.Click += new System.EventHandler(this.ActualizarToolStripMenuItem_Click);
            // 
            // LimpiarToolStripMenuItem
            // 
            this.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem";
            this.LimpiarToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.LimpiarToolStripMenuItem.Text = "Limpiar";
            this.LimpiarToolStripMenuItem.Click += new System.EventHandler(this.LimpiarToolStripMenuItem_Click);
            // 
            // GeneralToolStripMenuItem
            // 
            this.GeneralToolStripMenuItem.Name = "GeneralToolStripMenuItem";
            this.GeneralToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.GeneralToolStripMenuItem.Text = "General";
            this.GeneralToolStripMenuItem.Click += new System.EventHandler(this.GeneralToolStripMenuItem_Click);
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.TxtPuesto);
            this.Controls.Add(this.lbpuesto);
            this.Controls.Add(this.TxtIdSucursal);
            this.Controls.Add(this.lbIdSucursal);
            this.Controls.Add(this.txtcurp);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtRfc);
            this.Controls.Add(this.lbrfc);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.lbEdad);
            this.Controls.Add(Label1);
            this.Controls.Add(IDLabel);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.BtnActualir);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.dgvEmpleado);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LBTel);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.TxtNss);
            this.Controls.Add(this.LbNss);
            this.Controls.Add(this.MenuStrip1);
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).EndInit();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button BtnMenu;
        internal System.Windows.Forms.Button BtnBorrar;
        internal System.Windows.Forms.TextBox TxtPuesto;
        internal System.Windows.Forms.Label lbpuesto;
        internal System.Windows.Forms.TextBox TxtIdSucursal;
        internal System.Windows.Forms.Label lbIdSucursal;
        internal System.Windows.Forms.TextBox txtcurp;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtRfc;
        internal System.Windows.Forms.Label lbrfc;
        internal System.Windows.Forms.TextBox TxtEdad;
        internal System.Windows.Forms.Label lbEdad;
        internal System.Windows.Forms.TextBox IDTextBox;
        internal System.Windows.Forms.Button BtnActualir;
        internal System.Windows.Forms.Button BtnAgregar;
        internal System.Windows.Forms.DataGridView dgvEmpleado;
        internal System.Windows.Forms.Label lbNombre;
        internal System.Windows.Forms.TextBox TxtNombre;
        internal System.Windows.Forms.Label LBTel;
        internal System.Windows.Forms.TextBox txtTelefono;
        internal System.Windows.Forms.TextBox TxtNss;
        internal System.Windows.Forms.Label LbNss;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem AgregarToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ActualizarToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem LimpiarToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem GeneralToolStripMenuItem;
    }
}