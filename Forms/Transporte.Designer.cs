namespace AlmacenProMetal.Forms
{
    partial class Transporte
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
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.TxtCapacidad = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TxtPlaca = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.TxtTipo = new System.Windows.Forms.TextBox();
            this.BtnActualir = new System.Windows.Forms.Button();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.LBcategoria = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dgvTransporte = new System.Windows.Forms.DataGridView();
            IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransporte)).BeginInit();
            this.SuspendLayout();
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            IDLabel.Location = new System.Drawing.Point(164, 76);
            IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new System.Drawing.Size(24, 13);
            IDLabel.TabIndex = 192;
            IDLabel.Text = "ID:";
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnMenu.Location = new System.Drawing.Point(157, 41);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(43, 23);
            this.BtnMenu.TabIndex = 204;
            this.BtnMenu.Text = "Menu";
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Location = new System.Drawing.Point(548, 71);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(75, 23);
            this.BtnBorrar.TabIndex = 203;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(368, 115);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(66, 13);
            this.Label3.TabIndex = 202;
            this.Label3.Text = "capacidad";
            // 
            // TxtCapacidad
            // 
            this.TxtCapacidad.Location = new System.Drawing.Point(440, 112);
            this.TxtCapacidad.Name = "TxtCapacidad";
            this.TxtCapacidad.Size = new System.Drawing.Size(97, 20);
            this.TxtCapacidad.TabIndex = 201;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(333, 141);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(101, 13);
            this.Label2.TabIndex = 200;
            this.Label2.Text = "numero de placa";
            // 
            // TxtPlaca
            // 
            this.TxtPlaca.Location = new System.Drawing.Point(440, 138);
            this.TxtPlaca.Name = "TxtPlaca";
            this.TxtPlaca.Size = new System.Drawing.Size(97, 20);
            this.TxtPlaca.TabIndex = 199;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(186, 141);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(28, 13);
            this.Label1.TabIndex = 198;
            this.Label1.Text = "tipo";
            // 
            // TxtTipo
            // 
            this.TxtTipo.Location = new System.Drawing.Point(220, 134);
            this.TxtTipo.Name = "TxtTipo";
            this.TxtTipo.Size = new System.Drawing.Size(97, 20);
            this.TxtTipo.TabIndex = 197;
            // 
            // BtnActualir
            // 
            this.BtnActualir.Location = new System.Drawing.Point(467, 71);
            this.BtnActualir.Name = "BtnActualir";
            this.BtnActualir.Size = new System.Drawing.Size(75, 23);
            this.BtnActualir.TabIndex = 196;
            this.BtnActualir.Text = "Actualizar";
            this.BtnActualir.UseVisualStyleBackColor = true;
            this.BtnActualir.Click += new System.EventHandler(this.BtnActualir_Click);
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(391, 71);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(75, 23);
            this.BtnMostrar.TabIndex = 195;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(315, 71);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 194;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(220, 76);
            this.IDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(78, 20);
            this.IDTextBox.TabIndex = 193;
            // 
            // LBcategoria
            // 
            this.LBcategoria.AutoSize = true;
            this.LBcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBcategoria.Location = new System.Drawing.Point(164, 110);
            this.LBcategoria.Name = "LBcategoria";
            this.LBcategoria.Size = new System.Drawing.Size(50, 13);
            this.LBcategoria.TabIndex = 191;
            this.LBcategoria.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(220, 107);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(114, 20);
            this.txtNombre.TabIndex = 190;
            // 
            // dgvTransporte
            // 
            this.dgvTransporte.AllowUserToAddRows = false;
            this.dgvTransporte.AllowUserToDeleteRows = false;
            this.dgvTransporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransporte.Location = new System.Drawing.Point(169, 163);
            this.dgvTransporte.Name = "dgvTransporte";
            this.dgvTransporte.ReadOnly = true;
            this.dgvTransporte.Size = new System.Drawing.Size(475, 246);
            this.dgvTransporte.TabIndex = 189;
            // 
            // Transporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.TxtCapacidad);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TxtPlaca);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TxtTipo);
            this.Controls.Add(this.BtnActualir);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(IDLabel);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.LBcategoria);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dgvTransporte);
            this.Name = "Transporte";
            this.Text = "Transporte";
            this.Load += new System.EventHandler(this.Transporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button BtnMenu;
        internal System.Windows.Forms.Button BtnBorrar;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox TxtCapacidad;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TxtPlaca;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TxtTipo;
        internal System.Windows.Forms.Button BtnActualir;
        internal System.Windows.Forms.Button BtnMostrar;
        internal System.Windows.Forms.Button BtnAgregar;
        internal System.Windows.Forms.TextBox IDTextBox;
        internal System.Windows.Forms.Label LBcategoria;
        internal System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.DataGridView dgvTransporte;
    }
}