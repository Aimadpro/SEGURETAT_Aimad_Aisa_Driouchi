using System;
using System.Windows.Forms;


namespace SEGURETAT_Aimad_Aisa_Driouchi
{
    public partial class FormUsuaris : Form
    {
        public FormUsuaris()
        {
            InitializeComponent();
        }

        private void FormUsuaris_Load(object sender, EventArgs e)
        {

        }

        private void Acceptarbutton_Click(object sender, EventArgs e)
        {
            if (correoTextBox1 != null && ContrasenyaTextBox2 != null )
            {

               
                if (SeguretatDb.buscarUsuario(correoTextBox1.Text, ContrasenyaTextBox2.Text) == true)
                {
                    MessageBox.Show("ES CORRECTE");
                    FormMostrarUsuario newForm = new FormMostrarUsuario();
                    newForm.Show();

                }
                else
                {
                    MessageBox.Show("La contraseña o el usuario no son válidos");
                }


            }
            else {
                MessageBox.Show("S'ha d'introduit alguna dada");
                }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
