namespace AlmacenProMetal.Forms
{
    partial class DetPedido
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
            System.Windows.Forms.Label Label2;
            System.Windows.Forms.Label Label4;
            System.Windows.Forms.Label DescriptionLabel;
            System.Windows.Forms.Label QuantityLabel;
            this.CBTransp = new System.Windows.Forms.ComboBox();
            this.TxtIdPedido = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtIdTransporte = new System.Windows.Forms.TextBox();
            this.TxtRestante = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.BtnTotal = new System.Windows.Forms.Button();
            this.CbIdProduct = new System.Windows.Forms.ComboBox();
            this.CbProductosN = new System.Windows.Forms.ComboBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.dgvDTPedido = new System.Windows.Forms.DataGridView();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.BtnMenu = new System.Windows.Forms.Button();
            Label1 = new System.Windows.Forms.Label();
            Label2 = new System.Windows.Forms.Label();
            Label4 = new System.Windows.Forms.Label();
            DescriptionLabel = new System.Windows.Forms.Label();
            QuantityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDTPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label1.Location = new System.Drawing.Point(167, 26);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(61, 13);
            Label1.TabIndex = 249;
            Label1.Text = "IdPedido:";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label2.Location = new System.Drawing.Point(230, 179);
            Label2.Name = "Label2";
            Label2.Size = new System.Drawing.Size(60, 13);
            Label2.TabIndex = 245;
            Label2.Text = "cantidad:";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label4.Location = new System.Drawing.Point(117, 75);
            Label4.Name = "Label4";
            Label4.Size = new System.Drawing.Size(58, 13);
            Label4.TabIndex = 241;
            Label4.Text = "Producto";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DescriptionLabel.Location = new System.Drawing.Point(154, 99);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new System.Drawing.Size(20, 13);
            DescriptionLabel.TabIndex = 231;
            DescriptionLabel.Text = "ID";
            // 
            // QuantityLabel
            // 
            QuantityLabel.AutoSize = true;
            QuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            QuantityLabel.Location = new System.Drawing.Point(117, 179);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new System.Drawing.Size(44, 13);
            QuantityLabel.TabIndex = 232;
            QuantityLabel.Text = "Stock:";
            // 
            // CBTransp
            // 
            this.CBTransp.FormattingEnabled = true;
            this.CBTransp.Location = new System.Drawing.Point(429, 20);
            this.CBTransp.Name = "CBTransp";
            this.CBTransp.Size = new System.Drawing.Size(121, 21);
            this.CBTransp.TabIndex = 251;
            this.CBTransp.SelectedIndexChanged += new System.EventHandler(this.CBTransp_SelectedIndexChanged);
            // 
            // TxtIdPedido
            // 
            this.TxtIdPedido.Location = new System.Drawing.Point(239, 23);
            this.TxtIdPedido.Name = "TxtIdPedido";
            this.TxtIdPedido.Size = new System.Drawing.Size(84, 20);
            this.TxtIdPedido.TabIndex = 250;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(355, 21);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(68, 13);
            this.Label3.TabIndex = 248;
            this.Label3.Text = "Transporte";
            // 
            // txtIdTransporte
            // 
            this.txtIdTransporte.Enabled = false;
            this.txtIdTransporte.Location = new System.Drawing.Point(556, 20);
            this.txtIdTransporte.Name = "txtIdTransporte";
            this.txtIdTransporte.Size = new System.Drawing.Size(83, 20);
            this.txtIdTransporte.TabIndex = 247;
            // 
            // TxtRestante
            // 
            this.TxtRestante.Enabled = false;
            this.TxtRestante.Location = new System.Drawing.Point(120, 221);
            this.TxtRestante.Name = "TxtRestante";
            this.TxtRestante.Size = new System.Drawing.Size(84, 20);
            this.TxtRestante.TabIndex = 246;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(233, 195);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(63, 20);
            this.TxtCantidad.TabIndex = 244;
            // 
            // BtnTotal
            // 
            this.BtnTotal.Location = new System.Drawing.Point(126, 247);
            this.BtnTotal.Name = "BtnTotal";
            this.BtnTotal.Size = new System.Drawing.Size(48, 23);
            this.BtnTotal.TabIndex = 243;
            this.BtnTotal.Text = "Total:";
            this.BtnTotal.UseVisualStyleBackColor = true;
            this.BtnTotal.Click += new System.EventHandler(this.BtnTotal_Click);
            // 
            // CbIdProduct
            // 
            this.CbIdProduct.FormattingEnabled = true;
            this.CbIdProduct.Location = new System.Drawing.Point(181, 99);
            this.CbIdProduct.Name = "CbIdProduct";
            this.CbIdProduct.Size = new System.Drawing.Size(121, 21);
            this.CbIdProduct.TabIndex = 242;
            // 
            // CbProductosN
            // 
            this.CbProductosN.FormattingEnabled = true;
            this.CbProductosN.Location = new System.Drawing.Point(181, 72);
            this.CbProductosN.Name = "CbProductosN";
            this.CbProductosN.Size = new System.Drawing.Size(121, 21);
            this.CbProductosN.TabIndex = 240;
            this.CbProductosN.SelectedIndexChanged += new System.EventHandler(this.CbProductosN_SelectedIndexChanged);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(180, 126);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 239;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtTotal
            // 
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Location = new System.Drawing.Point(182, 247);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(84, 20);
            this.TxtTotal.TabIndex = 238;
            // 
            // dgvDTPedido
            // 
            this.dgvDTPedido.AllowUserToAddRows = false;
            this.dgvDTPedido.AllowUserToDeleteRows = false;
            this.dgvDTPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDTPedido.Location = new System.Drawing.Point(308, 78);
            this.dgvDTPedido.Name = "dgvDTPedido";
            this.dgvDTPedido.ReadOnly = true;
            this.dgvDTPedido.Size = new System.Drawing.Size(375, 353);
            this.dgvDTPedido.TabIndex = 237;
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(130, 318);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(75, 23);
            this.BtnMostrar.TabIndex = 236;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(129, 289);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 235;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Enabled = false;
            this.TxtPrecio.Location = new System.Drawing.Point(181, 156);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(84, 20);
            this.TxtPrecio.TabIndex = 234;
            // 
            // TxtStock
            // 
            this.TxtStock.Enabled = false;
            this.TxtStock.Location = new System.Drawing.Point(117, 195);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(85, 20);
            this.TxtStock.TabIndex = 233;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(125, 156);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(43, 13);
            this.Label10.TabIndex = 230;
            this.Label10.Text = "Precio";
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnMenu.Location = new System.Drawing.Point(118, 21);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(43, 23);
            this.BtnMenu.TabIndex = 229;
            this.BtnMenu.Text = "Menu";
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // DetPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CBTransp);
            this.Controls.Add(Label1);
            this.Controls.Add(this.TxtIdPedido);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtIdTransporte);
            this.Controls.Add(this.TxtRestante);
            this.Controls.Add(Label2);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.BtnTotal);
            this.Controls.Add(this.CbIdProduct);
            this.Controls.Add(Label4);
            this.Controls.Add(this.CbProductosN);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.dgvDTPedido);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(DescriptionLabel);
            this.Controls.Add(QuantityLabel);
            this.Controls.Add(this.TxtStock);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.BtnMenu);
            this.Name = "DetPedido";
            this.Text = "DetPedido";
            this.Load += new System.EventHandler(this.DetPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDTPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox CBTransp;
        internal System.Windows.Forms.TextBox TxtIdPedido;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtIdTransporte;
        internal System.Windows.Forms.TextBox TxtRestante;
        internal System.Windows.Forms.TextBox TxtCantidad;
        internal System.Windows.Forms.Button BtnTotal;
        internal System.Windows.Forms.ComboBox CbIdProduct;
        internal System.Windows.Forms.ComboBox CbProductosN;
        internal System.Windows.Forms.Button BtnBuscar;
        internal System.Windows.Forms.TextBox TxtTotal;
        internal System.Windows.Forms.DataGridView dgvDTPedido;
        internal System.Windows.Forms.Button BtnMostrar;
        internal System.Windows.Forms.Button BtnAgregar;
        internal System.Windows.Forms.TextBox TxtPrecio;
        internal System.Windows.Forms.TextBox TxtStock;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Button BtnMenu;
    }
}