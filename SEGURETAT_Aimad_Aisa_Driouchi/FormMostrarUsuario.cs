using Org.BouncyCastle.Asn1.X509.SigI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SEGURETAT_Aimad_Aisa_Driouchi
{
    public partial class FormMostrarUsuario : Form
    {
        public FormMostrarUsuario()
        {
            InitializeComponent();

        }

        private void FormMostrarUsuario_Load(object sender, EventArgs e)
        {
            usuariosGridView.DataSource = SeguretatDb.selectDataGrid();

        }

        private void afegirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCrearUsuario frm = new FormCrearUsuario();
            this.Close();
            frm.Show();

        }

        private void esborrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if (usuariosGridView.SelectedRows.Count > 0) // Verificar que hay una fila seleccionada
            {
                int id = (int)usuariosGridView.SelectedRows[0].Cells["id1"].Value;
                SeguretatDb.deleteUser(id);
                usuariosGridView.DataSource = SeguretatDb.selectDataGrid();
            } 
        }

        private void sortirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}