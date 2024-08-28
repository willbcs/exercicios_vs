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
            lbArea.Text = "�rea : ";
            lbPerimetro.Text = "Per�metro : ";
            lbDiagonal.Text = "Diagonal : ";
            lbHipotenusaTR.Text = "Hipotenusa : ";
            lbAreaTR.Text = "�rea : ";
            lbPerimetroTR.Text = "Per�metro : ";
            lbAreaQ.Text = "�rea : ";
            lbDiagonalQ.Text = "Diagonal : ";
            lbPerimetroQ.Text = "Per�metro: ";


            float ladoA, ladoB;

            //lbMensagem.Text = String.Empty; 

            if (!float.TryParse(txLadoA.Text, out ladoA) || ladoA <= 0)
            {
                //    lbMensagem.Text = "Digita��o inv�lida do Lado A";
                //    txLadoA.Focus();
                //    return;
                MessageBox.Show("Digita��o inv�lida do Lado A", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txLadoA.Focus();
                return;
            }

            if (!float.TryParse(txLadoB.Text, out ladoB) || ladoB <= 0)
            {
                //    lbMensagem.Text = "Digita��o inv�lida do Lado B";
                //    txLadoB.Focus();
                //    return;
                MessageBox.Show("Digita��o inv�lida do Lado B", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txLadoB.Focus();
                return;

            }

            Retangulo r = new Retangulo(ladoA, ladoB);

            // r.ladoA = 10; // isso � o set do ladoA

            lbArea.Text = $"�rea: {r.calculaArea()}";
            lbPerimetro.Text = $"Per�metro: {r.calculaPerimetro()}";
            lbDiagonal.Text = $"Diagonal: {r.calculaDiagonal()}";

            TrianguloRetangulo tr = new TrianguloRetangulo(ladoA, ladoB);


            lbAreaTR.Text = $"�rea : {tr.calculaArea()}";
            lbPerimetroTR.Text = $"Per�metro : {tr.calculaPerimetro()}";
            lbHipotenusaTR.Text = $"Hipotenusa : { tr.hipotenusa()}";

            Quadrado q = new Quadrado(ladoA);

            lbAreaQ.Text = $"�rea : {q.calculaArea()}";
            lbPerimetroQ.Text = $"Per�metro : {q.calculaPerimetro()}";
            lbDiagonalQ.Text = $"Hipotenusa : {q.calculaDiagonal()}";

        }

        private void lbMensagem_Click(object sender, EventArgs e)
        {

        }
    }
}