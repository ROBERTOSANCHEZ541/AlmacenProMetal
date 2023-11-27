namespace AlmacenProMetal.Forms
{
    partial class FrmMenu
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
            this.Btnclose = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.LbUsuario = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.MenuGeneral = new System.Windows.Forms.MenuStrip();
            this.CatalogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComprasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DetallesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SucursalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProveedoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoriasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PedidosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DetallesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransporteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel1.SuspendLayout();
            this.MenuGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btnclose
            // 
            this.Btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btnclose.Location = new System.Drawing.Point(436, 272);
            this.Btnclose.Name = "Btnclose";
            this.Btnclose.Size = new System.Drawing.Size(82, 36);
            this.Btnclose.TabIndex = 20;
            this.Btnclose.Text = "Cerrar Sesion";
            this.Btnclose.UseVisualStyleBackColor = false;
            this.Btnclose.Click += new System.EventHandler(this.Btnclose_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Panel1.Controls.Add(this.LbUsuario);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Location = new System.Drawing.Point(373, 9);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(145, 54);
            this.Panel1.TabIndex = 19;
            // 
            // LbUsuario
            // 
            this.LbUsuario.AutoSize = true;
            this.LbUsuario.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUsuario.Location = new System.Drawing.Point(3, 31);
            this.LbUsuario.Name = "LbUsuario";
            this.LbUsuario.Size = new System.Drawing.Size(0, 20);
            this.LbUsuario.TabIndex = 16;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(0, 3);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(86, 20);
            this.Label3.TabIndex = 15;
            this.Label3.Text = "Usuario:";
            // 
            // MenuGeneral
            // 
            this.MenuGeneral.BackColor = System.Drawing.Color.LightSeaGreen;
            this.MenuGeneral.Dock = System.Windows.Forms.DockStyle.None;
            this.MenuGeneral.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.MenuGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CatalogoToolStripMenuItem});
            this.MenuGeneral.Location = new System.Drawing.Point(9, 9);
            this.MenuGeneral.Name = "MenuGeneral";
            this.MenuGeneral.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MenuGeneral.Size = new System.Drawing.Size(82, 24);
            this.MenuGeneral.TabIndex = 18;
            this.MenuGeneral.Text = "MenuStrip1";
            // 
            // CatalogoToolStripMenuItem
            // 
            this.CatalogoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ComprasToolStripMenuItem1,
            this.ClientesToolStripMenuItem,
            this.ProductosToolStripMenuItem,
            this.SucursalesToolStripMenuItem,
            this.EmpleadosToolStripMenuItem,
            this.ProveedoresToolStripMenuItem1,
            this.CategoriasToolStripMenuItem1,
            this.PedidosToolStripMenuItem1,
            this.TransporteToolStripMenuItem1});
            this.CatalogoToolStripMenuItem.Name = "CatalogoToolStripMenuItem";
            this.CatalogoToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.CatalogoToolStripMenuItem.Text = "Catalogo:";
            // 
            // ComprasToolStripMenuItem1
            // 
            this.ComprasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DetallesToolStripMenuItem1});
            this.ComprasToolStripMenuItem1.Name = "ComprasToolStripMenuItem1";
            this.ComprasToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ComprasToolStripMenuItem1.Text = "Compras";
            this.ComprasToolStripMenuItem1.Click += new System.EventHandler(this.ComprasToolStripMenuItem1_Click);
            // 
            // DetallesToolStripMenuItem1
            // 
            this.DetallesToolStripMenuItem1.Name = "DetallesToolStripMenuItem1";
            this.DetallesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.DetallesToolStripMenuItem1.Text = "Detalles";
            this.DetallesToolStripMenuItem1.Click += new System.EventHandler(this.DetallesToolStripMenuItem1_Click);
            // 
            // ClientesToolStripMenuItem
            // 
            this.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem";
            this.ClientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ClientesToolStripMenuItem.Text = "Clientes";
            this.ClientesToolStripMenuItem.Click += new System.EventHandler(this.ClientesToolStripMenuItem_Click);
            // 
            // ProductosToolStripMenuItem
            // 
            this.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem";
            this.ProductosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ProductosToolStripMenuItem.Text = "Productos";
            this.ProductosToolStripMenuItem.Click += new System.EventHandler(this.ProductosToolStripMenuItem_Click);
            // 
            // SucursalesToolStripMenuItem
            // 
            this.SucursalesToolStripMenuItem.Name = "SucursalesToolStripMenuItem";
            this.SucursalesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SucursalesToolStripMenuItem.Text = "Sucursales";
            this.SucursalesToolStripMenuItem.Click += new System.EventHandler(this.SucursalesToolStripMenuItem_Click);
            // 
            // EmpleadosToolStripMenuItem
            // 
            this.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem";
            this.EmpleadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.EmpleadosToolStripMenuItem.Text = "Empleados";
            this.EmpleadosToolStripMenuItem.Click += new System.EventHandler(this.EmpleadosToolStripMenuItem_Click);
            // 
            // ProveedoresToolStripMenuItem1
            // 
            this.ProveedoresToolStripMenuItem1.Name = "ProveedoresToolStripMenuItem1";
            this.ProveedoresToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ProveedoresToolStripMenuItem1.Text = "Proveedores";
            this.ProveedoresToolStripMenuItem1.Click += new System.EventHandler(this.ProveedoresToolStripMenuItem1_Click);
            // 
            // CategoriasToolStripMenuItem1
            // 
            this.CategoriasToolStripMenuItem1.Name = "CategoriasToolStripMenuItem1";
            this.CategoriasToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.CategoriasToolStripMenuItem1.Text = "Categorias";
            this.CategoriasToolStripMenuItem1.Click += new System.EventHandler(this.CategoriasToolStripMenuItem1_Click);
            // 
            // PedidosToolStripMenuItem1
            // 
            this.PedidosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DetallesToolStripMenuItem});
            this.PedidosToolStripMenuItem1.Name = "PedidosToolStripMenuItem1";
            this.PedidosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.PedidosToolStripMenuItem1.Text = "Pedidos";
            this.PedidosToolStripMenuItem1.Click += new System.EventHandler(this.PedidosToolStripMenuItem1_Click);
            // 
            // DetallesToolStripMenuItem
            // 
            this.DetallesToolStripMenuItem.Name = "DetallesToolStripMenuItem";
            this.DetallesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DetallesToolStripMenuItem.Text = "Detalles";
            this.DetallesToolStripMenuItem.Click += new System.EventHandler(this.DetallesToolStripMenuItem_Click);
            // 
            // TransporteToolStripMenuItem1
            // 
            this.TransporteToolStripMenuItem1.Name = "TransporteToolStripMenuItem1";
            this.TransporteToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.TransporteToolStripMenuItem1.Text = "Transporte";
            this.TransporteToolStripMenuItem1.Click += new System.EventHandler(this.TransporteToolStripMenuItem1_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(524, 310);
            this.Controls.Add(this.Btnclose);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.MenuGeneral);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.MenuGeneral.ResumeLayout(false);
            this.MenuGeneral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Btnclose;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label LbUsuario;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.MenuStrip MenuGeneral;
        internal System.Windows.Forms.ToolStripMenuItem CatalogoToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ComprasToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem DetallesToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem ClientesToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ProductosToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SucursalesToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EmpleadosToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ProveedoresToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem CategoriasToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem PedidosToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem DetallesToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem TransporteToolStripMenuItem1;
    }
}