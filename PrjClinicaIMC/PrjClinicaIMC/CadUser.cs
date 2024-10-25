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
    public partial class CadUser : Form
    {
        public static List<Usuario> usuarios = new List<Usuario>();

        public String arquivo = "dadosUser.dat";

        public CadUser()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {

            if (txtsenha.Text.Trim().Length < 6)
            {
                MessageBox.Show("A Senha deve ter 6 digitos no mínimo!", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txlogin.Text.Trim().Length < 6)
            {
                MessageBox.Show("O Login deve ter 6 digitos no mínimo!", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (rbadm.Checked == false && rbfuncionario.Checked == false)
            {
                MessageBox.Show("Selecione um tipo de Perfil!", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            char perfil = rbfuncionario.Checked ? 'U' : 'A';

            if (txNome.Text.Trim() == String.Empty)
            {
                MessageBox.Show("É obrigatório digitar o nome do paciente", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Utilitarios.ValidaCpf(txCPF.Text))
            {
                MessageBox.Show("O CPF digitado é invalido", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //DateTime dataNascimento;
            //if (!DateTime.TryParse(txDataNacimento.Text, out dataNascimento))
            //{
            //    MessageBox.Show("Digite uma data de nascimento válida", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //int idade = DateTime.Now.Year - dataNascimento.Year;
            //if (dataNascimento > DateTime.Now.AddYears(-idade)) idade--; // Ajuste se a data de aniversário ainda não ocorreu este ano

            //// Verificação de idade mínima
            //if (idade < 16)
            //{
            //    MessageBox.Show("Pacientes menores de 16 anos não podem ser validados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            
            DateTime dataNacimento;
            if (!DateTime.TryParse(txDataNacimento.Text, out dataNacimento) || dataNacimento.CompareTo(DateTime.Now.AddYears(-18)) > 0)
            {
                MessageBox.Show("Digite uma data de nascimento válida", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            char sexo = 'O';
            if (rbFem.Checked) sexo = 'F';
            if (rbMasc.Checked) sexo = 'M';
            if (!rbFem.Checked && !rbMasc.Checked && !rbOutros.Checked)
            {
                MessageBox.Show("Selecione o sexo!", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Usuario u = new Usuario(txNome.Text, dataNacimento, txCPF.Text, sexo, txtsenha.Text, txlogin.Text, perfil);


            
            u.email = txEmail.Text;

            usuarios.Sort();

            int pos = usuarios.BinarySearch(u);

            if (pos == 0)
            {
                MessageBox.Show("Usuário editado com sucesso!");
                usuarios[pos] = u;
            }
            else
            {
                MessageBox.Show("Usuário Cadastrado com Sucesso");
                usuarios.Add(u);
            }

            
            limpatela();
            txRelatorio.Text = relatorio();
            Utilitarios.saveUsuario(usuarios, arquivo);

            }

        public void limpatela()
        {

            txCPF.Text =
            txDataNacimento.Text =
            txEmail.Text =
            txlogin.Text =
            txtsenha.Text =
            txNome.Text = String.Empty;

            rbadm.Checked =
            rbfuncionario.Checked =
            rbFem.Checked =
            rbMasc.Checked =
            rbOutros.Checked = false;

            txlogin.ReadOnly = false;
            btExcluir.Enabled = false;

        }
        private String relatorio()
        {


            StringBuilder ret = new StringBuilder();

            usuarios.Sort();


            foreach (Usuario p in usuarios)
            {
                ret.AppendLine(p.ToString());
            }
            return ret.ToString();


        }

        private void CadUser_Load(object sender, EventArgs e)
        {
            if (File.Exists(arquivo))
            {

                usuarios = Utilitarios.loadUsuario(arquivo);
                
                if (usuarios != null)
                {
                    txRelatorio.Text = relatorio();
                }
                
                else
                {

                    usuarios = new List<Usuario>();

                }
               
            }
        }

        private void mostra(Usuario u)
        {
            txCPF.Text = u.cpf;
            txDataNacimento.Text = u.dataDeNascimento.ToString();
            txEmail.Text = u.email;
            txlogin.Text = u.login;
            
            txNome.Text = u.nome;

            rbadm.Checked = u.perfil == 'A';
            rbfuncionario.Checked = u.perfil == 'U';
            rbFem.Checked = u.sexo == 'F';
            rbMasc.Checked = u.sexo == 'M';
            rbOutros.Checked = u.sexo == 'O';
        }

        private void btbuscar_Click(object sender, EventArgs e)
        {
            txlogin.ReadOnly = false;

            btExcluir.Enabled = false;
            usuarios.Sort();

            Usuario busca = new Usuario(txlogin.Text);
            int pos = usuarios.BinarySearch(busca);
            if (pos < 0)
            {
                MessageBox.Show("Usuário não encontrado!");
                return;
            }

            txlogin.ReadOnly = true;
            btExcluir.Enabled = true;
            mostra(usuarios[pos]);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            usuarios.Sort();
            Usuario busca = new Usuario(txlogin.Text);
            int pos = usuarios.BinarySearch(busca);
            if (pos < 0)
            {
                MessageBox.Show("Algo deu errado!");
                return;
            }

            usuarios.RemoveAt(pos);

            limpatela();
            txRelatorio.Text = relatorio();
            Utilitarios.saveUsuario(usuarios, arquivo);
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            limpatela();
            txRelatorio.Text = relatorio();
            Utilitarios.saveUsuario(usuarios, arquivo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpatela();
            
        }

        private void mnvoltar_Click(object sender, EventArgs e)
        {
            Visible = false;
            Form form = new Login();
            form.Visible = true;
        }

        private void mnClinica_Click(object sender, EventArgs e)
        {
            Visible = false;
            Form form = new frnClinicaImc();
            form.Visible = true;
        }
    }
}
