namespace SEGURETAT_Aimad_Aisa_Driouchi
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administradorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolsToolStripMenuItem,
            this.usuarisToolStripMenuItem,
            this.sortirToolStripMenuItem});
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.administradorToolStripMenuItem.Text = "Administrador";
            // 
            // rolsToolStripMenuItem
            // 
            this.rolsToolStripMenuItem.Name = "rolsToolStripMenuItem";
            this.rolsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rolsToolStripMenuItem.Text = "Rols";
            // 
            // usuarisToolStripMenuItem
            // 
            this.usuarisToolStripMenuItem.Name = "usuarisToolStripMenuItem";
            this.usuarisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuarisToolStripMenuItem.Text = "Usuaris";
            this.usuarisToolStripMenuItem.Click += new System.EventHandler(this.usuarisToolStripMenuItem_Click);
            // 
            // sortirToolStripMenuItem
            // 
            this.sortirToolStripMenuItem.Image = global::SEGURETAT_Aimad_Aisa_Driouchi.Properties.Resources.salir;
            this.sortirToolStripMenuItem.Name = "sortirToolStripMenuItem";
            this.sortirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sortirToolStripMenuItem.Text = "Sortir";
            this.sortirToolStripMenuItem.Click += new System.EventHandler(this.sortirToolStripMenuItem_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SEGURETAT_Aimad_Aisa_Driouchi.Properties.Resources.fondoc_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortirToolStripMenuItem;
    }
}

