namespace prjListaDeCompras
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbProduto = new System.Windows.Forms.Label();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.lbPreco = new System.Windows.Forms.Label();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.btOk = new System.Windows.Forms.Button();
            this.btTotal = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(36, 99);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(145, 23);
            this.txtProduto.TabIndex = 1;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(36, 209);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(145, 23);
            this.txtQuantidade.TabIndex = 2;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(36, 333);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(145, 23);
            this.txtPreco.TabIndex = 3;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Swis721 Blk BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTitulo.Location = new System.Drawing.Point(321, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(275, 32);
            this.lbTitulo.TabIndex = 4;
            this.lbTitulo.Text = "Lista de Compras";
            // 
            // lbProduto
            // 
            this.lbProduto.AutoSize = true;
            this.lbProduto.Font = new System.Drawing.Font("Swis721 Blk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbProduto.Location = new System.Drawing.Point(36, 74);
            this.lbProduto.Name = "lbProduto";
            this.lbProduto.Size = new System.Drawing.Size(100, 22);
            this.lbProduto.TabIndex = 5;
            this.lbProduto.Text = "Produto:";
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Font = new System.Drawing.Font("Swis721 Blk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbQuantidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbQuantidade.Location = new System.Drawing.Point(36, 184);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(138, 22);
            this.lbQuantidade.TabIndex = 6;
            this.lbQuantidade.Text = "Quantidade:";
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.Font = new System.Drawing.Font("Swis721 Blk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPreco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbPreco.Location = new System.Drawing.Point(36, 308);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(78, 22);
            this.lbPreco.TabIndex = 7;
            this.lbPreco.Text = "Preço:";
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(355, 61);
            this.txtLista.Multiline = true;
            this.txtLista.Name = "txtLista";
            this.txtLista.ReadOnly = true;
            this.txtLista.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLista.Size = new System.Drawing.Size(539, 489);
            this.txtLista.TabIndex = 8;
            // 
            // btOk
            // 
            this.btOk.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btOk.Location = new System.Drawing.Point(36, 425);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 35);
            this.btOk.TabIndex = 9;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btTotal
            // 
            this.btTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btTotal.Location = new System.Drawing.Point(245, 425);
            this.btTotal.Name = "btTotal";
            this.btTotal.Size = new System.Drawing.Size(75, 35);
            this.btTotal.TabIndex = 10;
            this.btTotal.Text = "Total";
            this.btTotal.UseVisualStyleBackColor = true;
            this.btTotal.Click += new System.EventHandler(this.btTotal_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Swis721 Blk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTotal.Location = new System.Drawing.Point(36, 518);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(0, 22);
            this.lbTotal.TabIndex = 11;
            // 
            // btLimpar
            // 
            this.btLimpar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btLimpar.Location = new System.Drawing.Point(142, 425);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 35);
            this.btLimpar.TabIndex = 12;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 562);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.btTotal);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.lbPreco);
            this.Controls.Add(this.lbQuantidade);
            this.Controls.Add(this.lbProduto);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtProduto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtProduto;
        private TextBox txtQuantidade;
        private TextBox txtPreco;
        private Label lbTitulo;
        private Label lbProduto;
        private Label lbQuantidade;
        private Label lbPreco;
        private TextBox txtLista;
        private Button btOk;
        private Button btTotal;
        private Label lbTotal;
        private Button btLimpar;
    }
}