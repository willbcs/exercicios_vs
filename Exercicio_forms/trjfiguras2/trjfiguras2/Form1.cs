namespace trjfiguras2
{
    public partial class frmfiguras2 : Form
    {
        public frmfiguras2()
        {
            InitializeComponent();
        }

        private void btOkCirculo_Click(object sender, EventArgs e)
        {
            float raio;

            if(!float.TryParse(txRaio.Text, out raio) || raio <= 0)
            {
                MessageBox.Show("Raio Inv�lido", "Erro cr�tico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Circulo c = new Circulo(raio);
            lbResultado.Text = $"�rea: {c.area}, Per�metro: {c.perimetro}";

        }

        private void btOkQuadrado_Click(object sender, EventArgs e)
        {
            float lado;

            if (!float.TryParse(txLado.Text, out lado) || lado <= 0)
            {
                MessageBox.Show("Lado com valor inv�lido", "Erro Cr�tico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Quadrado q = new Quadrado(lado);
            lbResultado.Text = $"�rea: {q.area}, Per�metro: {q.perimetro}";
        }

        private void btOkRetangulo_Click(object sender, EventArgs e)
        {
            float ladoA, ladoB;

            if (!float.TryParse(txladoA.Text, out ladoA) || ladoA <= 0)
            {
                MessageBox.Show("Lado A com valor inv�lido", "Erro Cr�tico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!float.TryParse(txladoB.Text, out ladoB) || ladoB <= 0)
            {
                MessageBox.Show("Lado B com valor inv�lido", "Erro Cr�tico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Retangulo r = new Retangulo(ladoA, ladoB);
            lbResultado.Text = $"�rea: {r.area}, Per�metro: {r.perimetro}";
        }
    }
}