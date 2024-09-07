namespace PrjClinicaIMC
{
    partial class frnClinicaImc
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
            lbTitulo = new Label();
            lbMensagem = new Label();
            lbMatricula = new Label();
            txMatricula = new TextBox();
            txNome = new TextBox();
            lbNome = new Label();
            txDataNacimento = new TextBox();
            lbDataNacimento = new Label();
            txCPF = new TextBox();
            lbCPF = new Label();
            rbFem = new RadioButton();
            rbMasc = new RadioButton();
            rbOutros = new RadioButton();
            txPeso = new TextBox();
            lbPeso = new Label();
            txAltura = new TextBox();
            lbAltura = new Label();
            btOk = new Button();
            txEmail = new TextBox();
            lbEmail = new Label();
            txRelatorio = new TextBox();
            SuspendLayout();
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Corbel", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitulo.Location = new Point(240, 9);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(311, 27);
            lbTitulo.TabIndex = 0;
            lbTitulo.Text = "CLÍNICA DE EMAGRECIMENTO";
            // 
            // lbMensagem
            // 
            lbMensagem.AutoSize = true;
            lbMensagem.Font = new Font("Corbel", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbMensagem.ForeColor = Color.FromArgb(192, 0, 0);
            lbMensagem.Location = new Point(22, 415);
            lbMensagem.Name = "lbMensagem";
            lbMensagem.Size = new Size(0, 26);
            lbMensagem.TabIndex = 1;
            // 
            // lbMatricula
            // 
            lbMatricula.AutoSize = true;
            lbMatricula.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbMatricula.ForeColor = Color.FromArgb(192, 0, 0);
            lbMatricula.Location = new Point(22, 54);
            lbMatricula.Name = "lbMatricula";
            lbMatricula.Size = new Size(75, 20);
            lbMatricula.TabIndex = 2;
            lbMatricula.Text = "Matricula";
            // 
            // txMatricula
            // 
            txMatricula.Location = new Point(22, 77);
            txMatricula.Name = "txMatricula";
            txMatricula.Size = new Size(100, 23);
            txMatricula.TabIndex = 3;
            // 
            // txNome
            // 
            txNome.Location = new Point(22, 126);
            txNome.Name = "txNome";
            txNome.Size = new Size(249, 23);
            txNome.TabIndex = 5;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbNome.ForeColor = Color.FromArgb(192, 0, 0);
            lbNome.Location = new Point(22, 103);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(52, 20);
            lbNome.TabIndex = 4;
            lbNome.Text = "Nome";
            // 
            // txDataNacimento
            // 
            txDataNacimento.Location = new Point(22, 175);
            txDataNacimento.Name = "txDataNacimento";
            txDataNacimento.Size = new Size(100, 23);
            txDataNacimento.TabIndex = 7;
            // 
            // lbDataNacimento
            // 
            lbDataNacimento.AutoSize = true;
            lbDataNacimento.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbDataNacimento.ForeColor = Color.FromArgb(192, 0, 0);
            lbDataNacimento.Location = new Point(22, 152);
            lbDataNacimento.Name = "lbDataNacimento";
            lbDataNacimento.Size = new Size(141, 20);
            lbDataNacimento.TabIndex = 6;
            lbDataNacimento.Text = "Data de nacimento";
            // 
            // txCPF
            // 
            txCPF.Location = new Point(22, 226);
            txCPF.Name = "txCPF";
            txCPF.Size = new Size(100, 23);
            txCPF.TabIndex = 9;
            txCPF.TextChanged += textBox1_TextChanged;
            // 
            // lbCPF
            // 
            lbCPF.AutoSize = true;
            lbCPF.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbCPF.ForeColor = Color.FromArgb(192, 0, 0);
            lbCPF.Location = new Point(22, 203);
            lbCPF.Name = "lbCPF";
            lbCPF.Size = new Size(35, 20);
            lbCPF.TabIndex = 8;
            lbCPF.Text = "CPF";
            lbCPF.Click += label1_Click;
            // 
            // rbFem
            // 
            rbFem.AutoSize = true;
            rbFem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rbFem.ForeColor = Color.FromArgb(192, 0, 0);
            rbFem.Location = new Point(22, 304);
            rbFem.Name = "rbFem";
            rbFem.Size = new Size(100, 25);
            rbFem.TabIndex = 11;
            rbFem.TabStop = true;
            rbFem.Text = "Feminino";
            rbFem.UseVisualStyleBackColor = true;
            // 
            // rbMasc
            // 
            rbMasc.AutoSize = true;
            rbMasc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rbMasc.ForeColor = Color.FromArgb(192, 0, 0);
            rbMasc.Location = new Point(22, 335);
            rbMasc.Name = "rbMasc";
            rbMasc.Size = new Size(107, 25);
            rbMasc.TabIndex = 12;
            rbMasc.TabStop = true;
            rbMasc.Text = "Masculino";
            rbMasc.UseVisualStyleBackColor = true;
            // 
            // rbOutros
            // 
            rbOutros.AutoSize = true;
            rbOutros.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rbOutros.ForeColor = Color.FromArgb(192, 0, 0);
            rbOutros.Location = new Point(22, 366);
            rbOutros.Name = "rbOutros";
            rbOutros.Size = new Size(79, 25);
            rbOutros.TabIndex = 13;
            rbOutros.TabStop = true;
            rbOutros.Text = "Outros";
            rbOutros.UseVisualStyleBackColor = true;
            // 
            // txPeso
            // 
            txPeso.Location = new Point(171, 175);
            txPeso.Name = "txPeso";
            txPeso.Size = new Size(100, 23);
            txPeso.TabIndex = 15;
            // 
            // lbPeso
            // 
            lbPeso.AutoSize = true;
            lbPeso.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbPeso.ForeColor = Color.FromArgb(192, 0, 0);
            lbPeso.Location = new Point(171, 152);
            lbPeso.Name = "lbPeso";
            lbPeso.Size = new Size(42, 20);
            lbPeso.TabIndex = 14;
            lbPeso.Text = "Peso";
            // 
            // txAltura
            // 
            txAltura.Location = new Point(171, 226);
            txAltura.Name = "txAltura";
            txAltura.Size = new Size(100, 23);
            txAltura.TabIndex = 17;
            // 
            // lbAltura
            // 
            lbAltura.AutoSize = true;
            lbAltura.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbAltura.ForeColor = Color.FromArgb(192, 0, 0);
            lbAltura.Location = new Point(171, 203);
            lbAltura.Name = "lbAltura";
            lbAltura.Size = new Size(53, 20);
            lbAltura.TabIndex = 16;
            lbAltura.Text = "Altura";
            // 
            // btOk
            // 
            btOk.ForeColor = Color.Black;
            btOk.Location = new Point(196, 307);
            btOk.Name = "btOk";
            btOk.Size = new Size(75, 23);
            btOk.TabIndex = 18;
            btOk.Text = "OK";
            btOk.UseVisualStyleBackColor = true;
            btOk.Click += btOk_Click;
            // 
            // txEmail
            // 
            txEmail.Location = new Point(22, 275);
            txEmail.Name = "txEmail";
            txEmail.Size = new Size(249, 23);
            txEmail.TabIndex = 20;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbEmail.ForeColor = Color.FromArgb(192, 0, 0);
            lbEmail.Location = new Point(22, 252);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(53, 20);
            lbEmail.TabIndex = 19;
            lbEmail.Text = "E-mail";
            // 
            // txRelatorio
            // 
            txRelatorio.Location = new Point(303, 73);
            txRelatorio.Multiline = true;
            txRelatorio.Name = "txRelatorio";
            txRelatorio.ScrollBars = ScrollBars.Vertical;
            txRelatorio.Size = new Size(459, 342);
            txRelatorio.TabIndex = 21;
            // 
            // frnClinicaImc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(txRelatorio);
            Controls.Add(txEmail);
            Controls.Add(lbEmail);
            Controls.Add(btOk);
            Controls.Add(txAltura);
            Controls.Add(lbAltura);
            Controls.Add(txPeso);
            Controls.Add(lbPeso);
            Controls.Add(rbOutros);
            Controls.Add(rbMasc);
            Controls.Add(rbFem);
            Controls.Add(txCPF);
            Controls.Add(lbCPF);
            Controls.Add(txDataNacimento);
            Controls.Add(lbDataNacimento);
            Controls.Add(txNome);
            Controls.Add(lbNome);
            Controls.Add(txMatricula);
            Controls.Add(lbMatricula);
            Controls.Add(lbMensagem);
            Controls.Add(lbTitulo);
            Name = "frnClinicaImc";
            Text = "Clinica de emagrecimento";
            Load += frnClinicaImc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitulo;
        private Label lbMensagem;
        private Label lbMatricula;
        private TextBox txMatricula;
        private TextBox txNome;
        private Label lbNome;
        private TextBox txDataNacimento;
        private Label lbDataNacimento;
        private TextBox txCPF;
        private Label lbCPF;
        private RadioButton rbFem;
        private RadioButton rbMasc;
        private RadioButton rbOutros;
        private TextBox txPeso;
        private Label lbPeso;
        private TextBox txAltura;
        private Label lbAltura;
        private Button btOk;
        private TextBox txEmail;
        private Label lbEmail;
        private TextBox txRelatorio;
    }
}