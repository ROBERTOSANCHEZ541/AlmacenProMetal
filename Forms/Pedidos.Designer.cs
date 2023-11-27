namespace AlmacenProMetal.Forms
{
    partial class Pedidos
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
            System.Windows.Forms.Label LBFecha;
            this.CBNombreC = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TxtIDPedido = new System.Windows.Forms.TextBox();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.txtFechaPedido = new System.Windows.Forms.TextBox();
            this.lbIDClient = new System.Windows.Forms.Label();
            this.txtClienteID = new System.Windows.Forms.TextBox();
            LBFecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // LBFecha
            // 
            LBFecha.AutoSize = true;
            LBFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LBFecha.Location = new System.Drawing.Point(244, 18);
            LBFecha.Name = "LBFecha";
            LBFecha.Size = new System.Drawing.Size(42, 13);
            LBFecha.TabIndex = 233;
            LBFecha.Text = "Fecha";
            // 
            // CBNombreC
            // 
            this.CBNombreC.FormattingEnabled = true;
            this.CBNombreC.Location = new System.Drawing.Point(289, 37);
            this.CBNombreC.Name = "CBNombreC";
            this.CBNombreC.Size = new System.Drawing.Size(121, 21);
            this.CBNombreC.TabIndex = 242;
            this.CBNombreC.SelectedIndexChanged += new System.EventHandler(this.CBNombreC_SelectedIndexChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(223, 37);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(50, 13);
            this.Label3.TabIndex = 241;
            this.Label3.Text = "Nombre";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(223, 84);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(59, 13);
            this.Label1.TabIndex = 240;
            this.Label1.Text = "IDPedido";
            // 
            // TxtIDPedido
            // 
            this.TxtIDPedido.Location = new System.Drawing.Point(291, 88);
            this.TxtIDPedido.Name = "TxtIDPedido";
            this.TxtIDPedido.Size = new System.Drawing.Size(67, 20);
            this.TxtIDPedido.TabIndex = 239;
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnMenu.Location = new System.Drawing.Point(195, 8);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(43, 23);
            this.BtnMenu.TabIndex = 238;
            this.BtnMenu.Text = "Menu";
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(496, 56);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(75, 23);
            this.BtnMostrar.TabIndex = 237;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(495, 27);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 236;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(209, 111);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.Size = new System.Drawing.Size(397, 331);
            this.dgvPedidos.TabIndex = 235;
            // 
            // txtFechaPedido
            // 
            this.txtFechaPedido.Enabled = false;
            this.txtFechaPedido.Location = new System.Drawing.Point(289, 14);
            this.txtFechaPedido.Name = "txtFechaPedido";
            this.txtFechaPedido.Size = new System.Drawing.Size(200, 20);
            this.txtFechaPedido.TabIndex = 234;
            // 
            // lbIDClient
            // 
            this.lbIDClient.AutoSize = true;
            this.lbIDClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDClient.Location = new System.Drawing.Point(223, 56);
            this.lbIDClient.Name = "lbIDClient";
            this.lbIDClient.Size = new System.Drawing.Size(63, 13);
            this.lbIDClient.TabIndex = 232;
            this.lbIDClient.Text = "ID Cliente";
            // 
            // txtClienteID
            // 
            this.txtClienteID.Location = new System.Drawing.Point(289, 63);
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.Size = new System.Drawing.Size(79, 20);
            this.txtClienteID.TabIndex = 231;
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CBNombreC);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TxtIDPedido);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(LBFecha);
            this.Controls.Add(this.txtFechaPedido);
            this.Controls.Add(this.lbIDClient);
            this.Controls.Add(this.txtClienteID);
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox CBNombreC;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TxtIDPedido;
        internal System.Windows.Forms.Button BtnMenu;
        internal System.Windows.Forms.Button BtnMostrar;
        internal System.Windows.Forms.Button BtnAgregar;
        internal System.Windows.Forms.DataGridView dgvPedidos;
        internal System.Windows.Forms.TextBox txtFechaPedido;
        internal System.Windows.Forms.Label lbIDClient;
        internal System.Windows.Forms.TextBox txtClienteID;
    }
}