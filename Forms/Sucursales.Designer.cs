namespace AlmacenProMetal.Forms
{
    partial class Sucursales
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
            System.Windows.Forms.Label IDLabel;
            this.BtnMenu = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.TxtCiudad = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtCp = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.BtnActualir = new System.Windows.Forms.Button();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.LBcategoria = new System.Windows.Forms.Label();
            this.TxtSucursal = new System.Windows.Forms.TextBox();
            this.dgvSucursales = new System.Windows.Forms.DataGridView();
            IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursales)).BeginInit();
            this.SuspendLayout();
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            IDLabel.Location = new System.Drawing.Point(88, 111);
            IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new System.Drawing.Size(24, 13);
            IDLabel.TabIndex = 191;
            IDLabel.Text = "ID:";
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnMenu.Location = new System.Drawing.Point(49, 61);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(43, 23);
            this.BtnMenu.TabIndex = 204;
            this.BtnMenu.Text = "Menu";
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(67, 165);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(45, 13);
            this.Label3.TabIndex = 203;
            this.Label3.Text = "ciudad";
            // 
            // TxtCiudad
            // 
            this.TxtCiudad.Location = new System.Drawing.Point(151, 162);
            this.TxtCiudad.Name = "TxtCiudad";
            this.TxtCiudad.Size = new System.Drawing.Size(249, 20);
            this.TxtCiudad.TabIndex = 202;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(58, 207);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(83, 13);
            this.Label1.TabIndex = 201;
            this.Label1.Text = "codigo postal";
            // 
            // txtCp
            // 
            this.txtCp.Location = new System.Drawing.Point(151, 202);
            this.txtCp.Name = "txtCp";
            this.txtCp.Size = new System.Drawing.Size(249, 20);
            this.txtCp.TabIndex = 200;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(56, 243);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(57, 13);
            this.Label6.TabIndex = 199;
            this.Label6.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(149, 238);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(249, 20);
            this.txtTelefono.TabIndex = 198;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(151, 268);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(249, 65);
            this.txtDireccion.TabIndex = 197;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(65, 281);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(61, 13);
            this.Label5.TabIndex = 196;
            this.Label5.Text = "Dirección";
            // 
            // BtnActualir
            // 
            this.BtnActualir.Location = new System.Drawing.Point(371, 81);
            this.BtnActualir.Name = "BtnActualir";
            this.BtnActualir.Size = new System.Drawing.Size(75, 23);
            this.BtnActualir.TabIndex = 195;
            this.BtnActualir.Text = "Actualizar";
            this.BtnActualir.UseVisualStyleBackColor = true;
            this.BtnActualir.Click += new System.EventHandler(this.BtnActualir_Click);
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(295, 81);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(75, 23);
            this.BtnMostrar.TabIndex = 194;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(219, 81);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 193;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(151, 111);
            this.IDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(78, 20);
            this.IDTextBox.TabIndex = 192;
            // 
            // LBcategoria
            // 
            this.LBcategoria.AutoSize = true;
            this.LBcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBcategoria.Location = new System.Drawing.Point(62, 139);
            this.LBcategoria.Name = "LBcategoria";
            this.LBcategoria.Size = new System.Drawing.Size(50, 13);
            this.LBcategoria.TabIndex = 190;
            this.LBcategoria.Text = "Nombre";
            // 
            // TxtSucursal
            // 
            this.TxtSucursal.Location = new System.Drawing.Point(151, 136);
            this.TxtSucursal.Name = "TxtSucursal";
            this.TxtSucursal.Size = new System.Drawing.Size(257, 20);
            this.TxtSucursal.TabIndex = 189;
            // 
            // dgvSucursales
            // 
            this.dgvSucursales.AllowUserToAddRows = false;
            this.dgvSucursales.AllowUserToDeleteRows = false;
            this.dgvSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSucursales.Location = new System.Drawing.Point(414, 120);
            this.dgvSucursales.Name = "dgvSucursales";
            this.dgvSucursales.ReadOnly = true;
            this.dgvSucursales.Size = new System.Drawing.Size(338, 269);
            this.dgvSucursales.TabIndex = 188;
            // 
            // Sucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.TxtCiudad);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtCp);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.BtnActualir);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(IDLabel);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.LBcategoria);
            this.Controls.Add(this.TxtSucursal);
            this.Controls.Add(this.dgvSucursales);
            this.Name = "Sucursales";
            this.Text = "Sucursales";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button BtnMenu;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox TxtCiudad;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtCp;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtTelefono;
        internal System.Windows.Forms.TextBox txtDireccion;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button BtnActualir;
        internal System.Windows.Forms.Button BtnMostrar;
        internal System.Windows.Forms.Button BtnAgregar;
        internal System.Windows.Forms.TextBox IDTextBox;
        internal System.Windows.Forms.Label LBcategoria;
        internal System.Windows.Forms.TextBox TxtSucursal;
        internal System.Windows.Forms.DataGridView dgvSucursales;
    }
}