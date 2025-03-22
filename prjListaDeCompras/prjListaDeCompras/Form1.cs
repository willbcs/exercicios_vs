namespace prjListaDeCompras
{
    public partial class Form1 : Form
    {
        private Compras compras = new Compras(); 

        public Form1()
        {
            InitializeComponent();
            lbTotal.Text = string.Empty;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (txtProduto.Text.Trim() == String.Empty)
            {
                MessageBox.Show("� obrigat�rio digitar o nome do produto", "Erro Cr�tico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            float preco;
            if (!float.TryParse(txtPreco.Text, out preco))
            {
                MessageBox.Show("O Pre�o � inv�lido!", "Erro Cr�tico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int quantidade;
            if (!int.TryParse(txtQuantidade.Text, out quantidade))
            {
                MessageBox.Show("A Quantidade � inv�lida!", "Erro Cr�tico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ItemDeCompra novoItem = new ItemDeCompra(txtProduto.Text, quantidade, preco);
            compras.Add(novoItem);

            txtLista.Text = compras.relatorio();

            MessageBox.Show("Produto adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpatela();
        }

        public void limpatela()
        {
            txtPreco.Text = 
            txtQuantidade.Text = 
            txtProduto.Text = 
            lbTotal.Text = string.Empty;
        }

        private void btTotal_Click(object sender, EventArgs e)
        {            
            lbTotal.Text = String.Format("Total: R$ {0:###,###,##0,00}", compras.Total());
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            limpatela();
        }
    }
}
