namespace AlmacenProMetal.Forms
{
    partial class Cliente
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
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.BtnActualir = new System.Windows.Forms.Button();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.lbNombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LBTel = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.LbEmail = new System.Windows.Forms.Label();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AgregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ActualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LimpiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            Label1 = new System.Windows.Forms.Label();
            IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new System.Drawing.Font("Agency FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label1.Location = new System.Drawing.Point(176, 80);
            Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(34, 14);
            Label1.TabIndex = 165;
            Label1.Text = "Ej:(506)";
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            IDLabel.Location = new System.Drawing.Point(22, 80);
            IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new System.Drawing.Size(24, 13);
            IDLabel.TabIndex = 163;
            IDLabel.Text = "ID:";
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnMenu.Location = new System.Drawing.Point(651, 1);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(43, 23);
            this.BtnMenu.TabIndex = 167;
            this.BtnMenu.Text = "Menu";
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(74, 80);
            this.IDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(78, 20);
            this.IDTextBox.TabIndex = 164;
            // 
            // BtnActualir
            // 
            this.BtnActualir.Location = new System.Drawing.Point(166, 218);
            this.BtnActualir.Name = "BtnActualir";
            this.BtnActualir.Size = new System.Drawing.Size(75, 23);
            this.BtnActualir.TabIndex = 162;
            this.BtnActualir.Text = "Actualizar";
            this.BtnActualir.UseVisualStyleBackColor = true;
            this.BtnActualir.Click += new System.EventHandler(this.BtnActualir_Click);
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(89, 218);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(75, 23);
            this.BtnMostrar.TabIndex = 161;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(21, 218);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 160;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(376, 80);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(397, 331);
            this.dgvClientes.TabIndex = 159;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(18, 110);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(50, 13);
            this.lbNombre.TabIndex = 158;
            this.lbNombre.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(74, 107);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(290, 20);
            this.TxtNombre.TabIndex = 157;
            // 
            // LBTel
            // 
            this.LBTel.AutoSize = true;
            this.LBTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTel.Location = new System.Drawing.Point(22, 170);
            this.LBTel.Name = "LBTel";
            this.LBTel.Size = new System.Drawing.Size(57, 13);
            this.LBTel.TabIndex = 156;
            this.LBTel.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(89, 170);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(249, 20);
            this.txtTelefono.TabIndex = 155;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(89, 139);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(249, 20);
            this.txtEmail.TabIndex = 154;
            // 
            // LbEmail
            // 
            this.LbEmail.AutoSize = true;
            this.LbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEmail.Location = new System.Drawing.Point(22, 139);
            this.LbEmail.Name = "LbEmail";
            this.LbEmail.Size = new System.Drawing.Size(37, 13);
            this.LbEmail.TabIndex = 153;
            this.LbEmail.Text = "Email";
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AgregarToolStripMenuItem,
            this.MostrarToolStripMenuItem,
            this.ActualizarToolStripMenuItem,
            this.LimpiarToolStripMenuItem,
            this.GeneralToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(800, 24);
            this.MenuStrip1.TabIndex = 166;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // AgregarToolStripMenuItem
            // 
            this.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem";
            this.AgregarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.AgregarToolStripMenuItem.Text = "Agregar";
            this.AgregarToolStripMenuItem.Click += new System.EventHandler(this.AgregarToolStripMenuItem_Click);
            // 
            // MostrarToolStripMenuItem
            // 
            this.MostrarToolStripMenuItem.Name = "MostrarToolStripMenuItem";
            this.MostrarToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.MostrarToolStripMenuItem.Text = "Mostrar";
            this.MostrarToolStripMenuItem.Click += new System.EventHandler(this.MostrarToolStripMenuItem_Click);
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
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(Label1);
            this.Controls.Add(IDLabel);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.BtnActualir);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LBTel);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.LbEmail);
            this.Controls.Add(this.MenuStrip1);
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button BtnMenu;
        internal System.Windows.Forms.TextBox IDTextBox;
        internal System.Windows.Forms.Button BtnActualir;
        internal System.Windows.Forms.Button BtnMostrar;
        internal System.Windows.Forms.Button BtnAgregar;
        internal System.Windows.Forms.DataGridView dgvClientes;
        internal System.Windows.Forms.Label lbNombre;
        internal System.Windows.Forms.TextBox TxtNombre;
        internal System.Windows.Forms.Label LBTel;
        internal System.Windows.Forms.TextBox txtTelefono;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.Label LbEmail;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem AgregarToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem MostrarToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ActualizarToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem LimpiarToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem GeneralToolStripMenuItem;
    }
}