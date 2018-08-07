using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usuario
{
    public partial class frmLogin : Form
    {
        Login login = new Login();

     
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            login.setUsuario(txtUsuario.Text);
            login.setSenha(txtSenha.Text);

            if (login.validarUsuario())
            {
                MessageBox.Show("Acesso permitido", "Permissão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {
                MessageBox.Show("Acesso negado", "Permissão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
