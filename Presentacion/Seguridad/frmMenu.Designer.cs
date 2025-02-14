namespace Presentacion.Seguridad
{
    partial class frmMenu
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarCarritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesCarritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(85, 20);
            this.toolStripStatusLabel1.Text = "22/01/2025";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(59, 20);
            this.toolStripStatusLabel2.Text = "Usuario";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarClienteToolStripMenuItem,
            this.administrarProductosToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(89, 24);
            this.toolStripMenuItem2.Text = "Inventario";
            // 
            // administrarClienteToolStripMenuItem
            // 
            this.administrarClienteToolStripMenuItem.Name = "administrarClienteToolStripMenuItem";
            this.administrarClienteToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.administrarClienteToolStripMenuItem.Text = "Administrar Cliente";
            this.administrarClienteToolStripMenuItem.Click += new System.EventHandler(this.administrarClienteToolStripMenuItem_Click);
            // 
            // administrarProductosToolStripMenuItem
            // 
            this.administrarProductosToolStripMenuItem.Name = "administrarProductosToolStripMenuItem";
            this.administrarProductosToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.administrarProductosToolStripMenuItem.Text = "Administrar Productos";
            this.administrarProductosToolStripMenuItem.Click += new System.EventHandler(this.administrarProductosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarCarritoToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(98, 24);
            this.toolStripMenuItem3.Text = "Facturacion";
            // 
            // administrarCarritoToolStripMenuItem
            // 
            this.administrarCarritoToolStripMenuItem.Name = "administrarCarritoToolStripMenuItem";
            this.administrarCarritoToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.administrarCarritoToolStripMenuItem.Text = "Administrar Carrito";
            this.administrarCarritoToolStripMenuItem.Click += new System.EventHandler(this.administrarCarritoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesCarritoToolStripMenuItem,
            this.reportesClienteToolStripMenuItem,
            this.reportesProductosToolStripMenuItem});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(82, 24);
            this.toolStripMenuItem4.Text = "Reportes";
            // 
            // reportesCarritoToolStripMenuItem
            // 
            this.reportesCarritoToolStripMenuItem.Name = "reportesCarritoToolStripMenuItem";
            this.reportesCarritoToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.reportesCarritoToolStripMenuItem.Text = "Reportes Carrito";
            // 
            // reportesClienteToolStripMenuItem
            // 
            this.reportesClienteToolStripMenuItem.Name = "reportesClienteToolStripMenuItem";
            this.reportesClienteToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.reportesClienteToolStripMenuItem.Text = "Reportes Cliente";
            // 
            // reportesProductosToolStripMenuItem
            // 
            this.reportesProductosToolStripMenuItem.Name = "reportesProductosToolStripMenuItem";
            this.reportesProductosToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.reportesProductosToolStripMenuItem.Text = "Reportes Productos";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem administrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarCarritoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesCarritoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesProductosToolStripMenuItem;
    }
}