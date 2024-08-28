namespace prjFigurasManha
{
    public partial class formFiguras : Form
    {
        public formFiguras()
        {
            InitializeComponent();
            lbMensagem.Text = String.Empty;
        }
        private void btOk_Click(object sender, EventArgs e)
        {
            //lbMensagem.Text =
            lbArea.Text = "Área : ";
            lbPerimetro.Text = "Perímetro : ";
            lbDiagonal.Text = "Diagonal : ";
            lbHipotenusaTR.Text = "Hipotenusa : ";
            lbAreaTR.Text = "Área : ";
            lbPerimetroTR.Text = "Perímetro : ";
            lbAreaQ.Text = "Área : ";
            lbDiagonalQ.Text = "Diagonal : ";
            lbPerimetroQ.Text = "Perímetro: ";


            float ladoA, ladoB;

            //lbMensagem.Text = String.Empty; 

            if (!float.TryParse(txLadoA.Text, out ladoA) || ladoA <= 0)
            {
                //    lbMensagem.Text = "Digitação inválida do Lado A";
                //    txLadoA.Focus();
                //    return;
                MessageBox.Show("Digitação inválida do Lado A", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txLadoA.Focus();
                return;
            }

            if (!float.TryParse(txLadoB.Text, out ladoB) || ladoB <= 0)
            {
                //    lbMensagem.Text = "Digitação inválida do Lado B";
                //    txLadoB.Focus();
                //    return;
                MessageBox.Show("Digitação inválida do Lado B", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txLadoB.Focus();
                return;

            }

            Retangulo r = new Retangulo(ladoA, ladoB);

            // r.ladoA = 10; // isso é o set do ladoA

            lbArea.Text = $"Área: {r.calculaArea()}";
            lbPerimetro.Text = $"Perímetro: {r.calculaPerimetro()}";
            lbDiagonal.Text = $"Diagonal: {r.calculaDiagonal()}";

            TrianguloRetangulo tr = new TrianguloRetangulo(ladoA, ladoB);


            lbAreaTR.Text = $"Área : {tr.calculaArea()}";
            lbPerimetroTR.Text = $"Perímetro : {tr.calculaPerimetro()}";
            lbHipotenusaTR.Text = $"Hipotenusa : { tr.hipotenusa()}";

            Quadrado q = new Quadrado(ladoA);

            lbAreaQ.Text = $"Área : {q.calculaArea()}";
            lbPerimetroQ.Text = $"Perímetro : {q.calculaPerimetro()}";
            lbDiagonalQ.Text = $"Hipotenusa : {q.calculaDiagonal()}";

        }

        private void lbMensagem_Click(object sender, EventArgs e)
        {

        }
    }
}