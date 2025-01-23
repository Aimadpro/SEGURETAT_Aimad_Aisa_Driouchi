using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace SEGURETAT_Aimad_Aisa_Driouchi
{
    public partial class FormCrearUsuario : Form
    {
        public FormCrearUsuario()
        {
            InitializeComponent();
        }

        private void FormCrearUsuario_Load(object sender, EventArgs e)
        {
            rolCombo.DataSource = SeguretatDb.selectRols();
            rolCombo.DisplayMember = "nom";
            rolCombo.ValueMember = "id";
        }

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            if (correoText.Text!="" && nomText.Text !="" && cognomText.Text != "" && contrasenyaText.Text != "" && confContrasenyaText.Text != "" && contrasenyaText.Text == confContrasenyaText.Text)
            {

                Boolean isChecked = actiuCheckBox.Checked;
                int selectedRoleId = Convert.ToInt32(rolCombo.SelectedValue); // Conversión a int

                string hashedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(contrasenyaText.Text, HashType.SHA512);

                SeguretatDb.insertarNuevosUsuarios(correoText.Text, nomText.Text, cognomText.Text, hashedPassword, selectedRoleId, isChecked);
                MessageBox.Show("Se han insertado los datos exitosamente");

            }
            else if(contrasenyaText.Text== confContrasenyaText.Text)
            {
                MessageBox.Show("Hay algún campo vacío");
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
