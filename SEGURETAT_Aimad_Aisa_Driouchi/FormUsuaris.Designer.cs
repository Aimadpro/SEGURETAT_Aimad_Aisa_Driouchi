namespace SEGURETAT_Aimad_Aisa_Driouchi
{
    partial class FormUsuaris
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
            this.label1 = new System.Windows.Forms.Label();
            this.correoTextBox1 = new System.Windows.Forms.TextBox();
            this.ContrasenyaTextBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Acceptarbutton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correu";
            // 
            // correoTextBox1
            // 
            this.correoTextBox1.Location = new System.Drawing.Point(113, 34);
            this.correoTextBox1.Name = "correoTextBox1";
            this.correoTextBox1.Size = new System.Drawing.Size(585, 20);
            this.correoTextBox1.TabIndex = 1;
            // 
            // ContrasenyaTextBox2
            // 
            this.ContrasenyaTextBox2.Location = new System.Drawing.Point(113, 82);
            this.ContrasenyaTextBox2.Name = "ContrasenyaTextBox2";
            this.ContrasenyaTextBox2.PasswordChar = '·';
            this.ContrasenyaTextBox2.Size = new System.Drawing.Size(585, 20);
            this.ContrasenyaTextBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contrasenya";
            // 
            // Acceptarbutton
            // 
            this.Acceptarbutton.Location = new System.Drawing.Point(410, 137);
            this.Acceptarbutton.Name = "Acceptarbutton";
            this.Acceptarbutton.Size = new System.Drawing.Size(93, 44);
            this.Acceptarbutton.TabIndex = 5;
            this.Acceptarbutton.Text = "Acceptar";
            this.Acceptarbutton.UseVisualStyleBackColor = true;
            this.Acceptarbutton.Click += new System.EventHandler(this.Acceptarbutton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(556, 137);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(93, 44);
            this.CancelarButton.TabIndex = 6;
            this.CancelarButton.Text = "Cancel·lar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // FormUsuaris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 193);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.Acceptarbutton);
            this.Controls.Add(this.ContrasenyaTextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.correoTextBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormUsuaris";
            this.Text = "FormUsuaris";
            this.Load += new System.EventHandler(this.FormUsuaris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox correoTextBox1;
        private System.Windows.Forms.TextBox ContrasenyaTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Acceptarbutton;
        private System.Windows.Forms.Button CancelarButton;
    }
}