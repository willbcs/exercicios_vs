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
                MessageBox.Show("Raio Inválido", "Erro crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Circulo c = new Circulo(raio);
            lbResultado.Text = $"Área: {c.area}, Perímetro: {c.perimetro}";

        }

        private void btOkQuadrado_Click(object sender, EventArgs e)
        {
            float lado;

            if (!float.TryParse(txLado.Text, out lado) || lado <= 0)
            {
                MessageBox.Show("Lado com valor inválido", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Quadrado q = new Quadrado(lado);
            lbResultado.Text = $"Área: {q.area}, Perímetro: {q.perimetro}";
        }

        private void btOkRetangulo_Click(object sender, EventArgs e)
        {
            float ladoA, ladoB;

            if (!float.TryParse(txladoA.Text, out ladoA) || ladoA <= 0)
            {
                MessageBox.Show("Lado A com valor inválido", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!float.TryParse(txladoB.Text, out ladoB) || ladoB <= 0)
            {
                MessageBox.Show("Lado B com valor inválido", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Retangulo r = new Retangulo(ladoA, ladoB);
            lbResultado.Text = $"Área: {r.area}, Perímetro: {r.perimetro}";
        }
    }
}