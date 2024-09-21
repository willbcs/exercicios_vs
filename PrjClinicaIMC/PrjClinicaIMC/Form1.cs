using System.Text;

namespace PrjClinicaIMC
{
    public partial class frnClinicaImc : Form
    {
        static private List<Paciente> listaPacientes = new List<Paciente>();
        public frnClinicaImc()
        {
            InitializeComponent();
            txMatricula.MaxLength = 6;
            txCPF.MaxLength = 11;
            lbMensagem.Text = string.Empty;
        }

        private void frnClinicaImc_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mostraPciente(Paciente p)
        {
            txMatricula.Text = p.matricula;
            txAltura.Text = p.altura().ToString();
            txCPF.Text = p.cpf;
            txDataNacimento.Text = p.dataDeNascimento.ToString("dd/MM/yyyy");
            txEmail.Text = p.email;
            txNome.Text = p.nome;
            txPeso.Text = p.peso().ToString();
            rbFem.Checked = p.sexo == 'F';
            rbMasc.Checked = p.sexo == 'M';
            rbOutros.Checked = p.sexo == 'O';

        }

        private static bool editando = false;

        private void btOk_Click(object sender, EventArgs e)
        {
            if(txMatricula.Text.Trim().Length != 6)
            {
                MessageBox.Show("A Matrícula deve ter 6 digitos!", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!editando)
            {

                foreach (Paciente pc in listaPacientes)
                {
                    if (txMatricula.Text.Trim() == pc.matricula)
                    {
                        mostraPciente(pc);
                        txMatricula.ReadOnly = true;
                        editando = true;
                        return;
                    }

                }

            }
            if(txNome.Text.Trim()==String.Empty)
            {
                MessageBox.Show("É obrigatório digitar o nome do paciente", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ;
            }
            if(txCPF.Text.Trim().Length != 11)
            {
                MessageBox.Show("O CPF digitado é invalido", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime dataNascimento;
            if (!DateTime.TryParse(txDataNacimento.Text, out dataNascimento))
            {
                MessageBox.Show("Digite uma data de nascimento válida", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idade = DateTime.Now.Year - dataNascimento.Year;
            if (dataNascimento > DateTime.Now.AddYears(-idade)) idade--; // Ajuste se a data de aniversário ainda não ocorreu este ano

            // Verificação de idade mínima
            if (idade < 16)
            {
                MessageBox.Show("Pacientes menores de 16 anos não podem ser validados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            float peso,altura;
            if(!float.TryParse(txPeso.Text,out peso) || peso < 40 || peso > 180)
            {
                MessageBox.Show("Peso do paciente é invalido", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(!float.TryParse(txAltura.Text, out altura) || altura < 1.2 || altura > 2.2)
            {
                MessageBox.Show("Altura do paciente é invalido", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            char sexo = 'O';
            if (rbFem.Checked) sexo = 'F';
            if (rbMasc.Checked) sexo = 'M';
            if(!rbFem.Checked&& rbMasc.Checked&&rbOutros.Checked)
            {
                MessageBox.Show("Selecione o sexo!", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Paciente p = new Paciente(txNome.Text, dataNascimento, txCPF.Text, sexo, peso, altura, txMatricula.Text);
            //lbMensagem.Text = " Paciente " + p.nome + "tem o IMC: " + p.valorImc();
            p.email = txEmail.Text;
            if (editando)
            {
                for (int i = 0; i < listaPacientes.Count; i++)
                {
                    if (txMatricula.Text == listaPacientes[i].matricula)
                    {

                        listaPacientes[i] = p;
                        txMatricula.ReadOnly = false;
                        editando = false;
                        break;

                    }
                }
            }

            else
            {
                //aqui estamos inserindo(não é novo)
                listaPacientes.Add(p);
               
            }

            limpatela();                        
            txRelatorio.Text = relatorio();
        }   

        private string relatorio()
        {
            StringBuilder ret = new StringBuilder();

            foreach(Paciente p in listaPacientes)
            {
                ret.AppendLine(p.ToString());
            }
            return ret.ToString();
        }
       
        private void limpatela()
        {

            txAltura.Text =
            txCPF.Text =
            txDataNacimento.Text =
            txEmail.Text =
            txMatricula.Text =
            txNome.Text =
            txPeso.Text = String.Empty;
            rbFem.Checked =
            rbMasc.Checked =
            rbOutros.Checked = false;

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {

            limpatela();
            txMatricula.ReadOnly = false;
            editando = false;

        }

        private void lbDataNacimento_Click(object sender, EventArgs e)
        {

        }
    }
}