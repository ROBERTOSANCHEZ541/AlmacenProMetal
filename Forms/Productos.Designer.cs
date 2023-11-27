namespace AlmacenProMetal.Forms
{
    partial class Productos
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
            System.Windows.Forms.Label Label4;
            System.Windows.Forms.Label Label1;
            System.Windows.Forms.Label DescriptionLabel;
            System.Windows.Forms.Label QuantityLabel;
            this.BtnMenu = new System.Windows.Forms.Button();
            this.BtnActualir = new System.Windows.Forms.Button();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.TxtIdSuc = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TxtIdCategoria = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.TxtDescrip = new System.Windows.Forms.TextBox();
            this.TxtIdProducto = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            Label4 = new System.Windows.Forms.Label();
            Label1 = new System.Windows.Forms.Label();
            DescriptionLabel = new System.Windows.Forms.Label();
            QuantityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label4.Location = new System.Drawing.Point(46, 195);
            Label4.Name = "Label4";
            Label4.Size = new System.Drawing.Size(75, 13);
            Label4.TabIndex = 195;
            Label4.Text = "Description:";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label1.Location = new System.Drawing.Point(46, 94);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(24, 13);
            Label1.TabIndex = 189;
            Label1.Text = "ID:";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DescriptionLabel.Location = new System.Drawing.Point(47, 117);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new System.Drawing.Size(50, 13);
            DescriptionLabel.TabIndex = 191;
            DescriptionLabel.Text = "Nombre";
            // 
            // QuantityLabel
            // 
            QuantityLabel.AutoSize = true;
            QuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            QuantityLabel.Location = new System.Drawing.Point(47, 169);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new System.Drawing.Size(56, 13);
            QuantityLabel.TabIndex = 193;
            QuantityLabel.Text = "cantidad";
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnMenu.Location = new System.Drawing.Point(47, 43);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(43, 23);
            this.BtnMenu.TabIndex = 204;
            this.BtnMenu.Text = "Menu";
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // BtnActualir
            // 
            this.BtnActualir.Location = new System.Drawing.Point(227, 301);
            this.BtnActualir.Name = "BtnActualir";
            this.BtnActualir.Size = new System.Drawing.Size(75, 23);
            this.BtnActualir.TabIndex = 203;
            this.BtnActualir.Text = "Actualizar";
            this.BtnActualir.UseVisualStyleBackColor = true;
            this.BtnActualir.Click += new System.EventHandler(this.BtnActualir_Click);
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(151, 301);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(75, 23);
            this.BtnMostrar.TabIndex = 202;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(70, 301);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 201;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // TxtIdSuc
            // 
            this.TxtIdSuc.Location = new System.Drawing.Point(152, 258);
            this.TxtIdSuc.Name = "TxtIdSuc";
            this.TxtIdSuc.Size = new System.Drawing.Size(200, 20);
            this.TxtIdSuc.TabIndex = 200;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(47, 261);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(54, 13);
            this.Label2.TabIndex = 199;
            this.Label2.Text = "sucursal";
            // 
            // TxtIdCategoria
            // 
            this.TxtIdCategoria.Location = new System.Drawing.Point(152, 227);
            this.TxtIdCategoria.Name = "TxtIdCategoria";
            this.TxtIdCategoria.Size = new System.Drawing.Size(200, 20);
            this.TxtIdCategoria.TabIndex = 198;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(358, 76);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(397, 331);
            this.dgvProductos.TabIndex = 197;
            // 
            // TxtDescrip
            // 
            this.TxtDescrip.Location = new System.Drawing.Point(152, 188);
            this.TxtDescrip.Name = "TxtDescrip";
            this.TxtDescrip.Size = new System.Drawing.Size(200, 20);
            this.TxtDescrip.TabIndex = 196;
            // 
            // TxtIdProducto
            // 
            this.TxtIdProducto.Location = new System.Drawing.Point(152, 87);
            this.TxtIdProducto.Name = "TxtIdProducto";
            this.TxtIdProducto.Size = new System.Drawing.Size(200, 20);
            this.TxtIdProducto.TabIndex = 190;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(153, 110);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(200, 20);
            this.TxtNombre.TabIndex = 192;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(153, 162);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(200, 20);
            this.TxtCantidad.TabIndex = 194;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(47, 139);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(43, 13);
            this.Label3.TabIndex = 188;
            this.Label3.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(153, 136);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(199, 20);
            this.txtPrecio.TabIndex = 187;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(47, 230);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(61, 13);
            this.Label10.TabIndex = 186;
            this.Label10.Text = "Categoria";
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.BtnActualir);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtIdSuc);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TxtIdCategoria);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(Label4);
            this.Controls.Add(this.TxtDescrip);
            this.Controls.Add(Label1);
            this.Controls.Add(this.TxtIdProducto);
            this.Controls.Add(DescriptionLabel);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(QuantityLabel);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.Label10);
            this.Name = "Productos";
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button BtnMenu;
        internal System.Windows.Forms.Button BtnActualir;
        internal System.Windows.Forms.Button BtnMostrar;
        internal System.Windows.Forms.Button BtnAgregar;
        internal System.Windows.Forms.TextBox TxtIdSuc;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TxtIdCategoria;
        internal System.Windows.Forms.DataGridView dgvProductos;
        internal System.Windows.Forms.TextBox TxtDescrip;
        internal System.Windows.Forms.TextBox TxtIdProducto;
        internal System.Windows.Forms.TextBox TxtNombre;
        internal System.Windows.Forms.TextBox TxtCantidad;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtPrecio;
        internal System.Windows.Forms.Label Label10;
    }
}