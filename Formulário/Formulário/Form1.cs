namespace Formulário
{
    public partial class PRJFomulario : Form
    {
        public PRJFomulario()
        {

            InitializeComponent();
            lbmensagem.Text = String.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbmensagem_Click(object sender, EventArgs e)
        {

        }

        private void matricula_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
                
        private void textMatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textMatricula.Text.Trim().Length != 6)
            {
                MessageBox.Show("Digite uma matrícula válida!", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textNome.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Digite um nome válido!", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textCPF.Text.Trim().Length != 11)
            {
                MessageBox.Show("Digite um CPF válido!", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime dataNascimento;
            if (!DateTime.TryParse(textDataNascimento.Text, out dataNascimento))
            {
                MessageBox.Show("Digite uma data de nascimento válida", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            float peso, altura;
            if (!float.TryParse(textPeso.Text, out peso) || peso < 40 || peso > 180)
            {
                MessageBox.Show("Digite um peso válido!", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!float.TryParse(textAltura.Text, out altura) || altura < 1.2 || altura > 2.2)
            {
                MessageBox.Show("Digite uma altura válida!", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (!rbFem.Checked && !rbMasc.Checked && !rbOutros.Checked)
            {
                MessageBox.Show("Marque uma opção de sexo!", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            char sexo = 'O';
            if (rbFem.Checked) sexo = 'F';
            if (rbMasc.Checked) sexo = 'M';

            Paciente p = new Paciente(textNome.Text, dataNascimento, textCPF.Text, sexo, peso, altura, textMatricula.Text);
            lbmensagem.Text = $"O paciente {p.nome} tem o IMC igual a {p.valorImc()}";

        }
       
    }

}
