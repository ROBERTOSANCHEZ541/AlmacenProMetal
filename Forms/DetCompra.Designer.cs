namespace AlmacenProMetal.Forms
{
    partial class DetCompra
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
            System.Windows.Forms.Label Label2;
            System.Windows.Forms.Label Label4;
            System.Windows.Forms.Label Label1;
            System.Windows.Forms.Label DescriptionLabel;
            System.Windows.Forms.Label QuantityLabel;
            this.TxtRestante = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.CbIdProduct = new System.Windows.Forms.ComboBox();
            this.CbProductosN = new System.Windows.Forms.ComboBox();
            this.CBTransp = new System.Windows.Forms.ComboBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.dgvDTCompra = new System.Windows.Forms.DataGridView();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.TxtIdCompra = new System.Windows.Forms.TextBox();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtIdTransporte = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.BtnMenu = new System.Windows.Forms.Button();
            Label2 = new System.Windows.Forms.Label();
            Label4 = new System.Windows.Forms.Label();
            Label1 = new System.Windows.Forms.Label();
            DescriptionLabel = new System.Windows.Forms.Label();
            QuantityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDTCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label2.Location = new System.Drawing.Point(233, 172);
            Label2.Name = "Label2";
            Label2.Size = new System.Drawing.Size(60, 13);
            Label2.TabIndex = 228;
            Label2.Text = "cantidad:";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label4.Location = new System.Drawing.Point(120, 68);
            Label4.Name = "Label4";
            Label4.Size = new System.Drawing.Size(58, 13);
            Label4.TabIndex = 224;
            Label4.Text = "Producto";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label1.Location = new System.Drawing.Point(164, 36);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(66, 13);
            Label1.TabIndex = 211;
            Label1.Text = "IDCompra:";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DescriptionLabel.Location = new System.Drawing.Point(157, 92);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new System.Drawing.Size(20, 13);
            DescriptionLabel.TabIndex = 213;
            DescriptionLabel.Text = "ID";
            // 
            // QuantityLabel
            // 
            QuantityLabel.AutoSize = true;
            QuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            QuantityLabel.Location = new System.Drawing.Point(120, 172);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new System.Drawing.Size(44, 13);
            QuantityLabel.TabIndex = 214;
            QuantityLabel.Text = "Stock:";
            // 
            // TxtRestante
            // 
            this.TxtRestante.Enabled = false;
            this.TxtRestante.Location = new System.Drawing.Point(123, 214);
            this.TxtRestante.Name = "TxtRestante";
            this.TxtRestante.Size = new System.Drawing.Size(84, 20);
            this.TxtRestante.TabIndex = 229;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(236, 188);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(63, 20);
            this.TxtCantidad.TabIndex = 227;
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(129, 240);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(48, 23);
            this.Button2.TabIndex = 226;
            this.Button2.Text = "Total:";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // CbIdProduct
            // 
            this.CbIdProduct.FormattingEnabled = true;
            this.CbIdProduct.Location = new System.Drawing.Point(184, 92);
            this.CbIdProduct.Name = "CbIdProduct";
            this.CbIdProduct.Size = new System.Drawing.Size(121, 21);
            this.CbIdProduct.TabIndex = 225;
            // 
            // CbProductosN
            // 
            this.CbProductosN.FormattingEnabled = true;
            this.CbProductosN.Location = new System.Drawing.Point(184, 65);
            this.CbProductosN.Name = "CbProductosN";
            this.CbProductosN.Size = new System.Drawing.Size(121, 21);
            this.CbProductosN.TabIndex = 223;
            this.CbProductosN.SelectedIndexChanged += new System.EventHandler(this.CbProductosN_SelectedIndexChanged);
            // 
            // CBTransp
            // 
            this.CBTransp.FormattingEnabled = true;
            this.CBTransp.Location = new System.Drawing.Point(426, 30);
            this.CBTransp.Name = "CBTransp";
            this.CBTransp.Size = new System.Drawing.Size(121, 21);
            this.CBTransp.TabIndex = 222;
            this.CBTransp.SelectedIndexChanged += new System.EventHandler(this.CBTransp_SelectedIndexChanged);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(183, 119);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 221;
            this.Button1.Text = "Buscar";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TxtTotal
            // 
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Location = new System.Drawing.Point(185, 240);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(84, 20);
            this.TxtTotal.TabIndex = 220;
            // 
            // dgvDTCompra
            // 
            this.dgvDTCompra.AllowUserToAddRows = false;
            this.dgvDTCompra.AllowUserToDeleteRows = false;
            this.dgvDTCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDTCompra.Location = new System.Drawing.Point(311, 71);
            this.dgvDTCompra.Name = "dgvDTCompra";
            this.dgvDTCompra.ReadOnly = true;
            this.dgvDTCompra.Size = new System.Drawing.Size(375, 353);
            this.dgvDTCompra.TabIndex = 219;
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(133, 311);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(75, 23);
            this.BtnMostrar.TabIndex = 218;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(132, 282);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 217;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Enabled = false;
            this.TxtPrecio.Location = new System.Drawing.Point(184, 149);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(84, 20);
            this.TxtPrecio.TabIndex = 216;
            // 
            // TxtIdCompra
            // 
            this.TxtIdCompra.Location = new System.Drawing.Point(236, 33);
            this.TxtIdCompra.Name = "TxtIdCompra";
            this.TxtIdCompra.Size = new System.Drawing.Size(84, 20);
            this.TxtIdCompra.TabIndex = 212;
            // 
            // TxtStock
            // 
            this.TxtStock.Enabled = false;
            this.TxtStock.Location = new System.Drawing.Point(120, 188);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(85, 20);
            this.TxtStock.TabIndex = 215;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(352, 31);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(68, 13);
            this.Label3.TabIndex = 210;
            this.Label3.Text = "Transporte";
            // 
            // txtIdTransporte
            // 
            this.txtIdTransporte.Enabled = false;
            this.txtIdTransporte.Location = new System.Drawing.Point(553, 30);
            this.txtIdTransporte.Name = "txtIdTransporte";
            this.txtIdTransporte.Size = new System.Drawing.Size(83, 20);
            this.txtIdTransporte.TabIndex = 209;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(128, 149);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(43, 13);
            this.Label10.TabIndex = 208;
            this.Label10.Text = "Precio";
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnMenu.Location = new System.Drawing.Point(115, 26);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(43, 23);
            this.BtnMenu.TabIndex = 207;
            this.BtnMenu.Text = "Menu";
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // DetCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtRestante);
            this.Controls.Add(Label2);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.CbIdProduct);
            this.Controls.Add(Label4);
            this.Controls.Add(this.CbProductosN);
            this.Controls.Add(this.CBTransp);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.dgvDTCompra);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(Label1);
            this.Controls.Add(this.TxtIdCompra);
            this.Controls.Add(DescriptionLabel);
            this.Controls.Add(QuantityLabel);
            this.Controls.Add(this.TxtStock);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtIdTransporte);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.BtnMenu);
            this.Name = "DetCompra";
            this.Text = "DetCompra";
            this.Load += new System.EventHandler(this.DetCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDTCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox TxtRestante;
        internal System.Windows.Forms.TextBox TxtCantidad;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.ComboBox CbIdProduct;
        internal System.Windows.Forms.ComboBox CbProductosN;
        internal System.Windows.Forms.ComboBox CBTransp;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox TxtTotal;
        internal System.Windows.Forms.DataGridView dgvDTCompra;
        internal System.Windows.Forms.Button BtnMostrar;
        internal System.Windows.Forms.Button BtnAgregar;
        internal System.Windows.Forms.TextBox TxtPrecio;
        internal System.Windows.Forms.TextBox TxtIdCompra;
        internal System.Windows.Forms.TextBox TxtStock;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtIdTransporte;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Button BtnMenu;
    }
}