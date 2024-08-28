namespace trjfiguras2
{
    partial class frmfiguras2
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
            this.lbRetangulo = new System.Windows.Forms.Label();
            this.lbQuadrado = new System.Windows.Forms.Label();
            this.lbCirculo = new System.Windows.Forms.Label();
            this.txladoA = new System.Windows.Forms.TextBox();
            this.txladoB = new System.Windows.Forms.TextBox();
            this.txLado = new System.Windows.Forms.TextBox();
            this.txRaio = new System.Windows.Forms.TextBox();
            this.btOkQuadrado = new System.Windows.Forms.Button();
            this.btOkRetangulo = new System.Windows.Forms.Button();
            this.btOkCirculo = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbRetangulo
            // 
            this.lbRetangulo.AutoSize = true;
            this.lbRetangulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbRetangulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbRetangulo.Location = new System.Drawing.Point(83, 46);
            this.lbRetangulo.Name = "lbRetangulo";
            this.lbRetangulo.Size = new System.Drawing.Size(104, 25);
            this.lbRetangulo.TabIndex = 1;
            this.lbRetangulo.Text = "Retângulo";
            // 
            // lbQuadrado
            // 
            this.lbQuadrado.AutoSize = true;
            this.lbQuadrado.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbQuadrado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbQuadrado.Location = new System.Drawing.Point(342, 46);
            this.lbQuadrado.Name = "lbQuadrado";
            this.lbQuadrado.Size = new System.Drawing.Size(102, 25);
            this.lbQuadrado.TabIndex = 2;
            this.lbQuadrado.Text = "Quadrado";
            // 
            // lbCirculo
            // 
            this.lbCirculo.AutoSize = true;
            this.lbCirculo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCirculo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCirculo.Location = new System.Drawing.Point(636, 46);
            this.lbCirculo.Name = "lbCirculo";
            this.lbCirculo.Size = new System.Drawing.Size(75, 25);
            this.lbCirculo.TabIndex = 3;
            this.lbCirculo.Text = "Círculo";
            // 
            // txladoA
            // 
            this.txladoA.Location = new System.Drawing.Point(83, 101);
            this.txladoA.Name = "txladoA";
            this.txladoA.Size = new System.Drawing.Size(100, 23);
            this.txladoA.TabIndex = 4;
            // 
            // txladoB
            // 
            this.txladoB.Location = new System.Drawing.Point(83, 168);
            this.txladoB.Name = "txladoB";
            this.txladoB.Size = new System.Drawing.Size(100, 23);
            this.txladoB.TabIndex = 5;
            // 
            // txLado
            // 
            this.txLado.Location = new System.Drawing.Point(342, 101);
            this.txLado.Name = "txLado";
            this.txLado.Size = new System.Drawing.Size(100, 23);
            this.txLado.TabIndex = 6;
            // 
            // txRaio
            // 
            this.txRaio.Location = new System.Drawing.Point(623, 101);
            this.txRaio.Name = "txRaio";
            this.txRaio.Size = new System.Drawing.Size(100, 23);
            this.txRaio.TabIndex = 7;
            // 
            // btOkQuadrado
            // 
            this.btOkQuadrado.Location = new System.Drawing.Point(352, 237);
            this.btOkQuadrado.Name = "btOkQuadrado";
            this.btOkQuadrado.Size = new System.Drawing.Size(75, 23);
            this.btOkQuadrado.TabIndex = 8;
            this.btOkQuadrado.Text = "OK";
            this.btOkQuadrado.UseVisualStyleBackColor = true;
            this.btOkQuadrado.Click += new System.EventHandler(this.btOkQuadrado_Click);
            // 
            // btOkRetangulo
            // 
            this.btOkRetangulo.Location = new System.Drawing.Point(95, 237);
            this.btOkRetangulo.Name = "btOkRetangulo";
            this.btOkRetangulo.Size = new System.Drawing.Size(75, 23);
            this.btOkRetangulo.TabIndex = 9;
            this.btOkRetangulo.Text = "OK";
            this.btOkRetangulo.UseVisualStyleBackColor = true;
            this.btOkRetangulo.Click += new System.EventHandler(this.btOkRetangulo_Click);
            // 
            // btOkCirculo
            // 
            this.btOkCirculo.Location = new System.Drawing.Point(636, 237);
            this.btOkCirculo.Name = "btOkCirculo";
            this.btOkCirculo.Size = new System.Drawing.Size(75, 23);
            this.btOkCirculo.TabIndex = 10;
            this.btOkCirculo.Text = "OK";
            this.btOkCirculo.UseVisualStyleBackColor = true;
            this.btOkCirculo.Click += new System.EventHandler(this.btOkCirculo_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbResultado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbResultado.Location = new System.Drawing.Point(83, 369);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(17, 25);
            this.lbResultado.TabIndex = 11;
            this.lbResultado.Text = ".";
            // 
            // frmfiguras2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btOkCirculo);
            this.Controls.Add(this.btOkRetangulo);
            this.Controls.Add(this.btOkQuadrado);
            this.Controls.Add(this.txRaio);
            this.Controls.Add(this.txLado);
            this.Controls.Add(this.txladoB);
            this.Controls.Add(this.txladoA);
            this.Controls.Add(this.lbCirculo);
            this.Controls.Add(this.lbQuadrado);
            this.Controls.Add(this.lbRetangulo);
            this.Name = "frmfiguras2";
            this.Text = "Trabalhando Com figuras Planas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbRetangulo;
        private Label lbQuadrado;
        private Label lbCirculo;
        private TextBox txladoA;
        private TextBox txladoB;
        private TextBox txLado;
        private TextBox txRaio;
        private Button btOkQuadrado;
        private Button btOkRetangulo;
        private Button btOkCirculo;
        private Label lbResultado;
    }
}