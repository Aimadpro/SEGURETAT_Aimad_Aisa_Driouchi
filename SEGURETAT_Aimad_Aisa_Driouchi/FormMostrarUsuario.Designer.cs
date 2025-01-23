namespace SEGURETAT_Aimad_Aisa_Driouchi
{
    partial class FormMostrarUsuario
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
            this.usuariosGridView = new System.Windows.Forms.DataGridView();
            this.agregarUsuario = new System.Windows.Forms.MenuStrip();
            this.afegirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esborrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.correu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cognoms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actiu = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nomRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosGridView)).BeginInit();
            this.agregarUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // usuariosGridView
            // 
            this.usuariosGridView.BackgroundColor = System.Drawing.Color.Lavender;
            this.usuariosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuariosGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.correu,
            this.id,
            this.id1,
            this.nom,
            this.cognoms,
            this.actiu,
            this.nomRol});
            this.usuariosGridView.Location = new System.Drawing.Point(-1, 76);
            this.usuariosGridView.Name = "usuariosGridView";
            this.usuariosGridView.ReadOnly = true;
            this.usuariosGridView.Size = new System.Drawing.Size(789, 161);
            this.usuariosGridView.TabIndex = 0;
            // 
            // agregarUsuario
            // 
            this.agregarUsuario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afegirToolStripMenuItem,
            this.esborrarToolStripMenuItem,
            this.sortirToolStripMenuItem});
            this.agregarUsuario.Location = new System.Drawing.Point(0, 0);
            this.agregarUsuario.Name = "agregarUsuario";
            this.agregarUsuario.Size = new System.Drawing.Size(800, 24);
            this.agregarUsuario.TabIndex = 8;
            this.agregarUsuario.Text = "menuStrip1";
            // 
            // afegirToolStripMenuItem
            // 
            this.afegirToolStripMenuItem.Image = global::SEGURETAT_Aimad_Aisa_Driouchi.Properties.Resources.annadir;
            this.afegirToolStripMenuItem.Name = "afegirToolStripMenuItem";
            this.afegirToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.afegirToolStripMenuItem.Text = "Afegir";
            this.afegirToolStripMenuItem.Click += new System.EventHandler(this.afegirToolStripMenuItem_Click);
            // 
            // esborrarToolStripMenuItem
            // 
            this.esborrarToolStripMenuItem.Image = global::SEGURETAT_Aimad_Aisa_Driouchi.Properties.Resources.eliminarr;
            this.esborrarToolStripMenuItem.Name = "esborrarToolStripMenuItem";
            this.esborrarToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.esborrarToolStripMenuItem.Text = "Esborrar";
            this.esborrarToolStripMenuItem.Click += new System.EventHandler(this.esborrarToolStripMenuItem_Click);
            // 
            // sortirToolStripMenuItem
            // 
            this.sortirToolStripMenuItem.Image = global::SEGURETAT_Aimad_Aisa_Driouchi.Properties.Resources.salir;
            this.sortirToolStripMenuItem.Name = "sortirToolStripMenuItem";
            this.sortirToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.sortirToolStripMenuItem.Text = "Sortir";
            this.sortirToolStripMenuItem.Click += new System.EventHandler(this.sortirToolStripMenuItem_Click);
            // 
            // correu
            // 
            this.correu.DataPropertyName = "correu";
            this.correu.HeaderText = "Correu";
            this.correu.Name = "correu";
            this.correu.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // id1
            // 
            this.id1.DataPropertyName = "id1";
            this.id1.HeaderText = "id1";
            this.id1.Name = "id1";
            this.id1.ReadOnly = true;
            this.id1.Visible = false;
            // 
            // nom
            // 
            this.nom.DataPropertyName = "nom";
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // cognoms
            // 
            this.cognoms.DataPropertyName = "cognoms";
            this.cognoms.HeaderText = "Cognoms";
            this.cognoms.Name = "cognoms";
            this.cognoms.ReadOnly = true;
            this.cognoms.Width = 150;
            // 
            // actiu
            // 
            this.actiu.DataPropertyName = "actiu";
            this.actiu.HeaderText = "Actiu";
            this.actiu.Name = "actiu";
            this.actiu.ReadOnly = true;
            // 
            // nomRol
            // 
            this.nomRol.DataPropertyName = "nomRol";
            this.nomRol.HeaderText = "Rol";
            this.nomRol.Name = "nomRol";
            this.nomRol.ReadOnly = true;
            // 
            // FormMostrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.agregarUsuario);
            this.Controls.Add(this.usuariosGridView);
            this.Name = "FormMostrarUsuario";
            this.Text = "FormMostrarUsuario";
            this.Load += new System.EventHandler(this.FormMostrarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosGridView)).EndInit();
            this.agregarUsuario.ResumeLayout(false);
            this.agregarUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView usuariosGridView;
        private System.Windows.Forms.MenuStrip agregarUsuario;
        private System.Windows.Forms.ToolStripMenuItem afegirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esborrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortirToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn correu;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn id1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognoms;
        private System.Windows.Forms.DataGridViewCheckBoxColumn actiu;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomRol;
    }
}