namespace PrjClinicaIMC
{
    partial class Login
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
            this.lbusuario = new System.Windows.Forms.Label();
            this.txusuario = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.btok = new System.Windows.Forms.Button();
            this.txSenha = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnClinica = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbusuario
            // 
            this.lbusuario.AutoSize = true;
            this.lbusuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbusuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbusuario.Location = new System.Drawing.Point(67, 110);
            this.lbusuario.Name = "lbusuario";
            this.lbusuario.Size = new System.Drawing.Size(63, 20);
            this.lbusuario.TabIndex = 22;
            this.lbusuario.Text = "Usuário";
            // 
            // txusuario
            // 
            this.txusuario.Location = new System.Drawing.Point(67, 133);
            this.txusuario.Name = "txusuario";
            this.txusuario.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txusuario.Size = new System.Drawing.Size(116, 23);
            this.txusuario.TabIndex = 23;
            this.txusuario.TextChanged += new System.EventHandler(this.txusuario_TextChanged);
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbSenha.Location = new System.Drawing.Point(67, 199);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(51, 20);
            this.lbSenha.TabIndex = 35;
            this.lbSenha.Text = "Senha";
            // 
            // btok
            // 
            this.btok.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btok.ForeColor = System.Drawing.Color.Black;
            this.btok.Location = new System.Drawing.Point(82, 288);
            this.btok.Name = "btok";
            this.btok.Size = new System.Drawing.Size(75, 23);
            this.btok.TabIndex = 37;
            this.btok.Text = "Ok";
            this.btok.UseVisualStyleBackColor = true;
            this.btok.Click += new System.EventHandler(this.btok_Click);
            // 
            // txSenha
            // 
            this.txSenha.Location = new System.Drawing.Point(67, 222);
            this.txSenha.Name = "txSenha";
            this.txSenha.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txSenha.Size = new System.Drawing.Size(116, 23);
            this.txSenha.TabIndex = 38;
            this.txSenha.TextChanged += new System.EventHandler(this.txSenha_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.mnClinica});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(255, 24);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Visible = false;
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // mnClinica
            // 
            this.mnClinica.Name = "mnClinica";
            this.mnClinica.Size = new System.Drawing.Size(55, 20);
            this.mnClinica.Text = "Clinica";
            this.mnClinica.Visible = false;
            this.mnClinica.Click += new System.EventHandler(this.mnClinica_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 450);
            this.Controls.Add(this.txSenha);
            this.Controls.Add(this.btok);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.txusuario);
            this.Controls.Add(this.lbusuario);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbusuario;
        private TextBox txusuario;
        private Label lbSenha;
        private Button btok;
        private TextBox txSenha;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem mnClinica;
    }
}