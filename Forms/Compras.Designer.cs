namespace AlmacenProMetal.Forms
{
    partial class Compras
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
            System.Windows.Forms.Label DescriptionLabel;
            this.CBNombreP = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TxtIDCompra = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TxtEmpId = new System.Windows.Forms.TextBox();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.txtFechaPedido = new System.Windows.Forms.TextBox();
            this.lbIDClient = new System.Windows.Forms.Label();
            this.txtProvID = new System.Windows.Forms.TextBox();
            this.BtnMenu = new System.Windows.Forms.Button();
            DescriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DescriptionLabel.Location = new System.Drawing.Point(246, 15);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new System.Drawing.Size(42, 13);
            DescriptionLabel.TabIndex = 236;
            DescriptionLabel.Text = "Fecha";
            // 
            // CBNombreP
            // 
            this.CBNombreP.FormattingEnabled = true;
            this.CBNombreP.Location = new System.Drawing.Point(304, 39);
            this.CBNombreP.Name = "CBNombreP";
            this.CBNombreP.Size = new System.Drawing.Size(121, 21);
            this.CBNombreP.TabIndex = 246;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(188, 42);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(116, 13);
            this.Label3.TabIndex = 245;
            this.Label3.Text = "Nombre Proveedor:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(478, 14);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(62, 13);
            this.Label1.TabIndex = 244;
            this.Label1.Text = "IDCompra";
            // 
            // TxtIDCompra
            // 
            this.TxtIDCompra.Location = new System.Drawing.Point(546, 11);
            this.TxtIDCompra.Name = "TxtIDCompra";
            this.TxtIDCompra.Size = new System.Drawing.Size(67, 20);
            this.TxtIDCompra.TabIndex = 243;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(213, 63);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(75, 13);
            this.Label2.TabIndex = 242;
            this.Label2.Text = "EmpleadoID";
            // 
            // TxtEmpId
            // 
            this.TxtEmpId.Enabled = false;
            this.TxtEmpId.Location = new System.Drawing.Point(292, 63);
            this.TxtEmpId.Name = "TxtEmpId";
            this.TxtEmpId.Size = new System.Drawing.Size(79, 20);
            this.TxtEmpId.TabIndex = 241;
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(533, 79);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(75, 23);
            this.BtnMostrar.TabIndex = 240;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(452, 79);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 239;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // dgvCompras
            // 
            this.dgvCompras.AllowUserToAddRows = false;
            this.dgvCompras.AllowUserToDeleteRows = false;
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Location = new System.Drawing.Point(211, 108);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.ReadOnly = true;
            this.dgvCompras.Size = new System.Drawing.Size(397, 331);
            this.dgvCompras.TabIndex = 238;
            // 
            // txtFechaPedido
            // 
            this.txtFechaPedido.Enabled = false;
            this.txtFechaPedido.Location = new System.Drawing.Point(291, 11);
            this.txtFechaPedido.Name = "txtFechaPedido";
            this.txtFechaPedido.Size = new System.Drawing.Size(80, 20);
            this.txtFechaPedido.TabIndex = 237;
            // 
            // lbIDClient
            // 
            this.lbIDClient.AutoSize = true;
            this.lbIDClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDClient.Location = new System.Drawing.Point(428, 42);
            this.lbIDClient.Name = "lbIDClient";
            this.lbIDClient.Size = new System.Drawing.Size(78, 13);
            this.lbIDClient.TabIndex = 235;
            this.lbIDClient.Text = "ProveedorID";
            // 
            // txtProvID
            // 
            this.txtProvID.Location = new System.Drawing.Point(511, 39);
            this.txtProvID.Name = "txtProvID";
            this.txtProvID.Size = new System.Drawing.Size(79, 20);
            this.txtProvID.TabIndex = 234;
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnMenu.Location = new System.Drawing.Point(191, 13);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(43, 23);
            this.BtnMenu.TabIndex = 233;
            this.BtnMenu.Text = "Menu";
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CBNombreP);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TxtIDCompra);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TxtEmpId);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.dgvCompras);
            this.Controls.Add(DescriptionLabel);
            this.Controls.Add(this.txtFechaPedido);
            this.Controls.Add(this.lbIDClient);
            this.Controls.Add(this.txtProvID);
            this.Controls.Add(this.BtnMenu);
            this.Name = "Compras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox CBNombreP;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TxtIDCompra;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TxtEmpId;
        internal System.Windows.Forms.Button BtnMostrar;
        internal System.Windows.Forms.Button BtnAgregar;
        internal System.Windows.Forms.DataGridView dgvCompras;
        internal System.Windows.Forms.TextBox txtFechaPedido;
        internal System.Windows.Forms.Label lbIDClient;
        internal System.Windows.Forms.TextBox txtProvID;
        internal System.Windows.Forms.Button BtnMenu;
    }
}