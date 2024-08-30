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
            lbRetangulo = new Label();
            lbQuadrado = new Label();
            lbCirculo = new Label();
            txladoA = new TextBox();
            txladoB = new TextBox();
            txLado = new TextBox();
            txRaio = new TextBox();
            btOkQuadrado = new Button();
            btOkRetangulo = new Button();
            btOkCirculo = new Button();
            lbResultado = new Label();
            lbLadoA = new Label();
            lbLadoB = new Label();
            lbLado = new Label();
            lbRaio = new Label();
            lbAltura = new Label();
            lbBase = new Label();
            btOkTrianguloRet = new Button();
            txAltura = new TextBox();
            txBase = new TextBox();
            lbTrianguloRet = new Label();
            SuspendLayout();
            // 
            // lbRetangulo
            // 
            lbRetangulo.AutoSize = true;
            lbRetangulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbRetangulo.ForeColor = SystemColors.ControlLightLight;
            lbRetangulo.Location = new Point(41, 24);
            lbRetangulo.Name = "lbRetangulo";
            lbRetangulo.Size = new Size(104, 25);
            lbRetangulo.TabIndex = 1;
            lbRetangulo.Text = "Retângulo";
            // 
            // lbQuadrado
            // 
            lbQuadrado.AutoSize = true;
            lbQuadrado.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbQuadrado.ForeColor = SystemColors.ControlLightLight;
            lbQuadrado.Location = new Point(216, 24);
            lbQuadrado.Name = "lbQuadrado";
            lbQuadrado.Size = new Size(102, 25);
            lbQuadrado.TabIndex = 2;
            lbQuadrado.Text = "Quadrado";
            // 
            // lbCirculo
            // 
            lbCirculo.AutoSize = true;
            lbCirculo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbCirculo.ForeColor = SystemColors.ControlLightLight;
            lbCirculo.Location = new Point(405, 24);
            lbCirculo.Name = "lbCirculo";
            lbCirculo.Size = new Size(75, 25);
            lbCirculo.TabIndex = 3;
            lbCirculo.Text = "Círculo";
            // 
            // txladoA
            // 
            txladoA.Location = new Point(41, 102);
            txladoA.Name = "txladoA";
            txladoA.Size = new Size(100, 23);
            txladoA.TabIndex = 4;
            // 
            // txladoB
            // 
            txladoB.Location = new Point(41, 169);
            txladoB.Name = "txladoB";
            txladoB.Size = new Size(100, 23);
            txladoB.TabIndex = 5;
            // 
            // txLado
            // 
            txLado.Location = new Point(216, 102);
            txLado.Name = "txLado";
            txLado.Size = new Size(100, 23);
            txLado.TabIndex = 6;
            // 
            // txRaio
            // 
            txRaio.Location = new Point(392, 102);
            txRaio.Name = "txRaio";
            txRaio.Size = new Size(100, 23);
            txRaio.TabIndex = 7;
            // 
            // btOkQuadrado
            // 
            btOkQuadrado.Location = new Point(229, 238);
            btOkQuadrado.Name = "btOkQuadrado";
            btOkQuadrado.Size = new Size(75, 23);
            btOkQuadrado.TabIndex = 8;
            btOkQuadrado.Text = "OK";
            btOkQuadrado.UseVisualStyleBackColor = true;
            btOkQuadrado.Click += btOkQuadrado_Click;
            // 
            // btOkRetangulo
            // 
            btOkRetangulo.Location = new Point(53, 238);
            btOkRetangulo.Name = "btOkRetangulo";
            btOkRetangulo.Size = new Size(75, 23);
            btOkRetangulo.TabIndex = 9;
            btOkRetangulo.Text = "OK";
            btOkRetangulo.UseVisualStyleBackColor = true;
            btOkRetangulo.Click += btOkRetangulo_Click;
            // 
            // btOkCirculo
            // 
            btOkCirculo.Location = new Point(405, 238);
            btOkCirculo.Name = "btOkCirculo";
            btOkCirculo.Size = new Size(75, 23);
            btOkCirculo.TabIndex = 10;
            btOkCirculo.Text = "OK";
            btOkCirculo.UseVisualStyleBackColor = true;
            btOkCirculo.Click += btOkCirculo_Click;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbResultado.ForeColor = SystemColors.ControlLightLight;
            lbResultado.Location = new Point(83, 369);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(0, 25);
            lbResultado.TabIndex = 11;
            // 
            // lbLadoA
            // 
            lbLadoA.AutoSize = true;
            lbLadoA.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbLadoA.ForeColor = SystemColors.ControlLightLight;
            lbLadoA.Location = new Point(41, 80);
            lbLadoA.Name = "lbLadoA";
            lbLadoA.Size = new Size(60, 19);
            lbLadoA.TabIndex = 12;
            lbLadoA.Text = "Lado A:";
            // 
            // lbLadoB
            // 
            lbLadoB.AutoSize = true;
            lbLadoB.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbLadoB.ForeColor = SystemColors.ControlLightLight;
            lbLadoB.Location = new Point(41, 147);
            lbLadoB.Name = "lbLadoB";
            lbLadoB.Size = new Size(59, 19);
            lbLadoB.TabIndex = 13;
            lbLadoB.Text = "Lado B:";
            // 
            // lbLado
            // 
            lbLado.AutoSize = true;
            lbLado.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbLado.ForeColor = SystemColors.ControlLightLight;
            lbLado.Location = new Point(216, 80);
            lbLado.Name = "lbLado";
            lbLado.Size = new Size(46, 19);
            lbLado.TabIndex = 14;
            lbLado.Text = "Lado:";
            // 
            // lbRaio
            // 
            lbRaio.AutoSize = true;
            lbRaio.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbRaio.ForeColor = SystemColors.ControlLightLight;
            lbRaio.Location = new Point(392, 80);
            lbRaio.Name = "lbRaio";
            lbRaio.Size = new Size(43, 19);
            lbRaio.TabIndex = 15;
            lbRaio.Text = "Raio:";
            // 
            // lbAltura
            // 
            lbAltura.AutoSize = true;
            lbAltura.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbAltura.ForeColor = SystemColors.ControlLightLight;
            lbAltura.Location = new Point(573, 147);
            lbAltura.Name = "lbAltura";
            lbAltura.Size = new Size(54, 19);
            lbAltura.TabIndex = 21;
            lbAltura.Text = "Altura:";
            // 
            // lbBase
            // 
            lbBase.AutoSize = true;
            lbBase.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbBase.ForeColor = SystemColors.ControlLightLight;
            lbBase.Location = new Point(573, 80);
            lbBase.Name = "lbBase";
            lbBase.Size = new Size(44, 19);
            lbBase.TabIndex = 20;
            lbBase.Text = "Base:";
            // 
            // btOkTrianguloRet
            // 
            btOkTrianguloRet.Location = new Point(585, 238);
            btOkTrianguloRet.Name = "btOkTrianguloRet";
            btOkTrianguloRet.Size = new Size(75, 23);
            btOkTrianguloRet.TabIndex = 19;
            btOkTrianguloRet.Text = "OK";
            btOkTrianguloRet.UseVisualStyleBackColor = true;
            btOkTrianguloRet.Click += btOkTrianguloRet_Click;
            // 
            // txAltura
            // 
            txAltura.Location = new Point(573, 169);
            txAltura.Name = "txAltura";
            txAltura.Size = new Size(100, 23);
            txAltura.TabIndex = 18;
            // 
            // txBase
            // 
            txBase.Location = new Point(573, 102);
            txBase.Name = "txBase";
            txBase.Size = new Size(100, 23);
            txBase.TabIndex = 17;
            // 
            // lbTrianguloRet
            // 
            lbTrianguloRet.AutoSize = true;
            lbTrianguloRet.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbTrianguloRet.ForeColor = SystemColors.ControlLightLight;
            lbTrianguloRet.Location = new Point(541, 24);
            lbTrianguloRet.Name = "lbTrianguloRet";
            lbTrianguloRet.Size = new Size(195, 25);
            lbTrianguloRet.TabIndex = 16;
            lbTrianguloRet.Text = "Triângulo Retângulo";
            // 
            // frmfiguras2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(800, 450);
            Controls.Add(lbAltura);
            Controls.Add(lbBase);
            Controls.Add(btOkTrianguloRet);
            Controls.Add(txAltura);
            Controls.Add(txBase);
            Controls.Add(lbTrianguloRet);
            Controls.Add(lbRaio);
            Controls.Add(lbLado);
            Controls.Add(lbLadoB);
            Controls.Add(lbLadoA);
            Controls.Add(lbResultado);
            Controls.Add(btOkCirculo);
            Controls.Add(btOkRetangulo);
            Controls.Add(btOkQuadrado);
            Controls.Add(txRaio);
            Controls.Add(txLado);
            Controls.Add(txladoB);
            Controls.Add(txladoA);
            Controls.Add(lbCirculo);
            Controls.Add(lbQuadrado);
            Controls.Add(lbRetangulo);
            Name = "frmfiguras2";
            Text = "Trabalhando Com figuras Planas";
            ResumeLayout(false);
            PerformLayout();
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
        private Label lbLadoA;
        private Label lbLadoB;
        private Label lbLado;
        private Label lbRaio;
        private Label lbAltura;
        private Label lbBase;
        private Button btOkTrianguloRet;
        private TextBox txAltura;
        private TextBox txBase;
        private Label lbTrianguloRet;
    }
}