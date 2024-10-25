namespace PrjClinicaIMC
{
    partial class CadUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitulo = new System.Windows.Forms.Label();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.rbOutros = new System.Windows.Forms.RadioButton();
            this.rbMasc = new System.Windows.Forms.RadioButton();
            this.rbFem = new System.Windows.Forms.RadioButton();
            this.txCPF = new System.Windows.Forms.TextBox();
            this.lbCPF = new System.Windows.Forms.Label();
            this.txDataNacimento = new System.Windows.Forms.TextBox();
            this.lbDataNacimento = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.txlogin = new System.Windows.Forms.TextBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.gbPerfil = new System.Windows.Forms.GroupBox();
            this.rbadm = new System.Windows.Forms.RadioButton();
            this.rbfuncionario = new System.Windows.Forms.RadioButton();
            this.txRelatorio = new System.Windows.Forms.TextBox();
            this.btbuscar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnvoltar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnClinica = new System.Windows.Forms.ToolStripMenuItem();
            this.gbPerfil.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTitulo.Location = new System.Drawing.Point(270, 23);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(209, 27);
            this.lbTitulo.TabIndex = 1;
            this.lbTitulo.Text = "Cadastro de Usuários";
            // 
            // txEmail
            // 
            this.txEmail.Location = new System.Drawing.Point(29, 326);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(265, 23);
            this.txEmail.TabIndex = 33;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbEmail.Location = new System.Drawing.Point(29, 303);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(53, 20);
            this.lbEmail.TabIndex = 32;
            this.lbEmail.Text = "E-mail";
            // 
            // rbOutros
            // 
            this.rbOutros.AutoSize = true;
            this.rbOutros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbOutros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbOutros.Location = new System.Drawing.Point(29, 417);
            this.rbOutros.Name = "rbOutros";
            this.rbOutros.Size = new System.Drawing.Size(79, 25);
            this.rbOutros.TabIndex = 31;
            this.rbOutros.TabStop = true;
            this.rbOutros.Text = "Outros";
            this.rbOutros.UseVisualStyleBackColor = true;
            // 
            // rbMasc
            // 
            this.rbMasc.AutoSize = true;
            this.rbMasc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbMasc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbMasc.Location = new System.Drawing.Point(29, 386);
            this.rbMasc.Name = "rbMasc";
            this.rbMasc.Size = new System.Drawing.Size(107, 25);
            this.rbMasc.TabIndex = 30;
            this.rbMasc.TabStop = true;
            this.rbMasc.Text = "Masculino";
            this.rbMasc.UseVisualStyleBackColor = true;
            // 
            // rbFem
            // 
            this.rbFem.AutoSize = true;
            this.rbFem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbFem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbFem.Location = new System.Drawing.Point(29, 355);
            this.rbFem.Name = "rbFem";
            this.rbFem.Size = new System.Drawing.Size(100, 25);
            this.rbFem.TabIndex = 29;
            this.rbFem.TabStop = true;
            this.rbFem.Text = "Feminino";
            this.rbFem.UseVisualStyleBackColor = true;
            // 
            // txCPF
            // 
            this.txCPF.Location = new System.Drawing.Point(29, 277);
            this.txCPF.Name = "txCPF";
            this.txCPF.Size = new System.Drawing.Size(100, 23);
            this.txCPF.TabIndex = 28;
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbCPF.Location = new System.Drawing.Point(29, 254);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(35, 20);
            this.lbCPF.TabIndex = 27;
            this.lbCPF.Text = "CPF";
            // 
            // txDataNacimento
            // 
            this.txDataNacimento.Location = new System.Drawing.Point(29, 226);
            this.txDataNacimento.Name = "txDataNacimento";
            this.txDataNacimento.Size = new System.Drawing.Size(100, 23);
            this.txDataNacimento.TabIndex = 26;
            // 
            // lbDataNacimento
            // 
            this.lbDataNacimento.AutoSize = true;
            this.lbDataNacimento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDataNacimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbDataNacimento.Location = new System.Drawing.Point(29, 203);
            this.lbDataNacimento.Name = "lbDataNacimento";
            this.lbDataNacimento.Size = new System.Drawing.Size(148, 20);
            this.lbDataNacimento.TabIndex = 25;
            this.lbDataNacimento.Text = "Data de nascimento";
            // 
            // txNome
            // 
            this.txNome.Location = new System.Drawing.Point(29, 177);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(265, 23);
            this.txNome.TabIndex = 24;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbNome.Location = new System.Drawing.Point(29, 154);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(52, 20);
            this.lbNome.TabIndex = 23;
            this.lbNome.Text = "Nome";
            // 
            // txlogin
            // 
            this.txlogin.Location = new System.Drawing.Point(29, 53);
            this.txlogin.Name = "txlogin";
            this.txlogin.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txlogin.Size = new System.Drawing.Size(100, 23);
            this.txlogin.TabIndex = 22;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbLogin.Location = new System.Drawing.Point(29, 30);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(48, 20);
            this.lbLogin.TabIndex = 21;
            this.lbLogin.Text = "Login";
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(29, 112);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtsenha.Size = new System.Drawing.Size(116, 23);
            this.txtsenha.TabIndex = 35;
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbSenha.Location = new System.Drawing.Point(29, 89);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(51, 20);
            this.lbSenha.TabIndex = 34;
            this.lbSenha.Text = "Senha";
            // 
            // btSalvar
            // 
            this.btSalvar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btSalvar.ForeColor = System.Drawing.Color.Black;
            this.btSalvar.Location = new System.Drawing.Point(219, 386);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 36;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // gbPerfil
            // 
            this.gbPerfil.Controls.Add(this.rbadm);
            this.gbPerfil.Controls.Add(this.rbfuncionario);
            this.gbPerfil.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbPerfil.Location = new System.Drawing.Point(178, 206);
            this.gbPerfil.Name = "gbPerfil";
            this.gbPerfil.Size = new System.Drawing.Size(116, 114);
            this.gbPerfil.TabIndex = 37;
            this.gbPerfil.TabStop = false;
            this.gbPerfil.Text = "Perfil";
            // 
            // rbadm
            // 
            this.rbadm.AutoSize = true;
            this.rbadm.Location = new System.Drawing.Point(6, 22);
            this.rbadm.Name = "rbadm";
            this.rbadm.Size = new System.Drawing.Size(61, 24);
            this.rbadm.TabIndex = 1;
            this.rbadm.TabStop = true;
            this.rbadm.Text = "Adm";
            this.rbadm.UseVisualStyleBackColor = true;
            // 
            // rbfuncionario
            // 
            this.rbfuncionario.AutoSize = true;
            this.rbfuncionario.Location = new System.Drawing.Point(6, 47);
            this.rbfuncionario.Name = "rbfuncionario";
            this.rbfuncionario.Size = new System.Drawing.Size(109, 24);
            this.rbfuncionario.TabIndex = 0;
            this.rbfuncionario.TabStop = true;
            this.rbfuncionario.Text = "Funcionário";
            this.rbfuncionario.UseVisualStyleBackColor = true;
            // 
            // txRelatorio
            // 
            this.txRelatorio.Location = new System.Drawing.Point(363, 101);
            this.txRelatorio.Multiline = true;
            this.txRelatorio.Name = "txRelatorio";
            this.txRelatorio.ReadOnly = true;
            this.txRelatorio.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txRelatorio.Size = new System.Drawing.Size(425, 314);
            this.txRelatorio.TabIndex = 38;
            this.txRelatorio.WordWrap = false;
            // 
            // btbuscar
            // 
            this.btbuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btbuscar.Location = new System.Drawing.Point(144, 53);
            this.btbuscar.Name = "btbuscar";
            this.btbuscar.Size = new System.Drawing.Size(75, 23);
            this.btbuscar.TabIndex = 39;
            this.btbuscar.Text = "Buscar";
            this.btbuscar.UseVisualStyleBackColor = true;
            this.btbuscar.Click += new System.EventHandler(this.btbuscar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Enabled = false;
            this.btExcluir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btExcluir.Location = new System.Drawing.Point(241, 53);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 40;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btLimpar.Location = new System.Drawing.Point(194, 112);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 41;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnvoltar,
            this.mnClinica});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 42;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnvoltar
            // 
            this.mnvoltar.Name = "mnvoltar";
            this.mnvoltar.Size = new System.Drawing.Size(49, 20);
            this.mnvoltar.Text = "Voltar";
            this.mnvoltar.Click += new System.EventHandler(this.mnvoltar_Click);
            // 
            // mnClinica
            // 
            this.mnClinica.Name = "mnClinica";
            this.mnClinica.Size = new System.Drawing.Size(55, 20);
            this.mnClinica.Text = "Clinica";
            this.mnClinica.Click += new System.EventHandler(this.mnClinica_Click);
            // 
            // CadUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btbuscar);
            this.Controls.Add(this.txRelatorio);
            this.Controls.Add(this.gbPerfil);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.txEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.rbOutros);
            this.Controls.Add(this.rbMasc);
            this.Controls.Add(this.rbFem);
            this.Controls.Add(this.txCPF);
            this.Controls.Add(this.lbCPF);
            this.Controls.Add(this.txDataNacimento);
            this.Controls.Add(this.lbDataNacimento);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txlogin);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.menuStrip1);
            this.Name = "CadUser";
            this.Text = "Cadastro de Usuário";
            this.Load += new System.EventHandler(this.CadUser_Load);
            this.gbPerfil.ResumeLayout(false);
            this.gbPerfil.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbTitulo;
        private TextBox txEmail;
        private Label lbEmail;
        private RadioButton rbOutros;
        private RadioButton rbMasc;
        private RadioButton rbFem;
        private TextBox txCPF;
        private Label lbCPF;
        private TextBox txDataNacimento;
        private Label lbDataNacimento;
        private TextBox txNome;
        private Label lbNome;
        private TextBox txlogin;
        private Label lbLogin;
        private TextBox txtsenha;
        private Label lbSenha;
        private Button btSalvar;
        private GroupBox gbPerfil;
        private RadioButton rbadm;
        private RadioButton rbfuncionario;
        private TextBox txRelatorio;
        private Button btbuscar;
        private Button btExcluir;
        private Button btLimpar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem mnClinica;
        private ToolStripMenuItem mnvoltar;
    }
}