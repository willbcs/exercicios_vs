using System.Text;

namespace PrjClinicaIMC
{
    public partial class frnClinicaImc : Form
    {
        static private List<Paciente> listaPacientes = new List<Paciente>();
        public frnClinicaImc()
        {
            InitializeComponent();
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

        private void btOk_Click(object sender, EventArgs e)
        {
            if(txMatricula.Text.Trim().Length != 6)
            {
                lbMensagem.Text = "A Matrícula deve ter 6 digitos!";
                return;
            }
            if(txNome.Text.Trim()==String.Empty)
            {
                lbMensagem.Text = "É obrigatório digitar o nome do paciente";
                return ;
            }
            if(txCPF.Text.Trim().Length != 11)
            {
                lbMensagem.Text = "O CPF digitado é invalido";
                return;
            }
            DateTime dataNacimennto;
            DateTime dataHoje = DateTime.Today;
            DateTime dateTime = DateTime.Now;
            DateTime dataMinima = dataHoje.AddDays(-16);
            if (!DateTime.TryParse(txDataNacimento.Text, out dataNacimennto))
            {
                lbMensagem.Text = "data de nacimento é invalida";
                return;
            }
            else
            {
                if(dataNacimennto > dataMinima)
                {
                    lbMensagem.Text = "É necessário ter mais de 16 anos";
                }
            }

            float peso,altura;
            if(!float.TryParse(txPeso.Text,out peso) || peso < 40 || peso > 180)
            {
                lbMensagem.Text = " Peso do paciente é invalido";
                return;
            }

            if(!float.TryParse(txAltura.Text, out altura) || altura < 1.2 || altura > 2.2)
            {
                lbMensagem.Text = " Altura do paciente é invalido";
                return;
            }

            char sexo = 'O';
            if (rbFem.Checked) sexo = 'F';
            if (rbMasc.Checked) sexo = 'M';
            if(!rbFem.Checked&& rbMasc.Checked&&rbOutros.Checked)
            {
                lbMensagem.Text = "Selecione o sexo!";
                return;
            }

            Paciente p = new Paciente(txNome.Text, dataNacimennto, txCPF.Text, sexo, peso, altura, txMatricula.Text);
            //lbMensagem.Text = " Paciente " + p.nome + "tem o IMC: " + p.valorImc();
            p.email = txEmail.Text;
            limpatela();
                        
            listaPacientes.Add(p);
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
    }
}