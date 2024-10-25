using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjClinicaIMC
{

    
    public partial class Login : Form
    {
        public static List<Usuario> usuarios = new List<Usuario>();

        public string arquivo = "dadosUser.dat";
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (File.Exists(arquivo))
            {

                usuarios = Utilitarios.loadUsuario(arquivo);

                if (usuarios == null)
                {
                    MessageBox.Show("Lista de usuários vazia!");
                }

            } 
            else
            {
                MessageBox.Show("Lista de usuários vazia!");
            }

        }

        private void btok_Click(object sender, EventArgs e)
        {
            if (usuarios != null && usuarios.Count > 0)
            {
                usuarios.Sort();
                Usuario u = new Usuario(txusuario.Text);
                int pos = usuarios.BinarySearch(u);

                if (pos < 0)
                {
                    MessageBox.Show("Usuário não cadastrado!");
                    return;
                }

                Usuario logado = usuarios[pos];

                if(logado.hashsenha != Utilitarios.myHash(txSenha.Text, ""))
                {
                    MessageBox.Show("Senha não confere!");
                    return;
                }

                if(logado.perfil != 'A')
                {
                    Visible = false;
                    Form form = new frnClinicaImc();
                    form.Visible = true;
                }

                else
                {
                    usuarioToolStripMenuItem.Visible = true;
                    mnClinica.Visible = true;
                }
            }
        }

        private void txusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txSenha_TextChanged(object sender, EventArgs e)
        {

        }
        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            Form form = new CadUser();
            form.Visible = true;
        }

        private void mnClinica_Click_1(object sender, EventArgs e)
        {
            Visible = false;
            Form form = new frnClinicaImc();
            form.Visible = true;
        }
    }
}
