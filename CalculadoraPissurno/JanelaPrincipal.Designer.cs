namespace CalculadoraPissurno
{
    partial class JanelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaPrincipal));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.equalButton = new System.Windows.Forms.Button();
            this.botao7 = new System.Windows.Forms.Button();
            this.botao8 = new System.Windows.Forms.Button();
            this.botao9 = new System.Windows.Forms.Button();
            this.botao6 = new System.Windows.Forms.Button();
            this.botao5 = new System.Windows.Forms.Button();
            this.botao4 = new System.Windows.Forms.Button();
            this.botao3 = new System.Windows.Forms.Button();
            this.botao2 = new System.Windows.Forms.Button();
            this.botao1 = new System.Windows.Forms.Button();
            this.botao0 = new System.Windows.Forms.Button();
            this.virgula = new System.Windows.Forms.Button();
            this.soma = new System.Windows.Forms.Button();
            this.subtracao = new System.Windows.Forms.Button();
            this.multiplicacao = new System.Windows.Forms.Button();
            this.divisao = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.sen = new System.Windows.Forms.Button();
            this.potencia = new System.Windows.Forms.Button();
            this.raiz = new System.Windows.Forms.Button();
            this.porcentagem = new System.Windows.Forms.Button();
            this.resto = new System.Windows.Forms.Button();
            this.tg = new System.Windows.Forms.Button();
            this.limpar = new System.Windows.Forms.Button();
            this.fibonnaciR = new System.Windows.Forms.Button();
            this.fibonacciI = new System.Windows.Forms.Button();
            this.fatorialIterativo = new System.Windows.Forms.Button();
            this.fatorialRecursivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.MaxLength = 25;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(298, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // equalButton
            // 
            this.equalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalButton.Location = new System.Drawing.Point(239, 76);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(32, 108);
            this.equalButton.TabIndex = 1;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // botao7
            // 
            this.botao7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao7.Location = new System.Drawing.Point(12, 38);
            this.botao7.Name = "botao7";
            this.botao7.Size = new System.Drawing.Size(32, 32);
            this.botao7.TabIndex = 2;
            this.botao7.Text = "7";
            this.botao7.UseVisualStyleBackColor = true;
            this.botao7.Click += new System.EventHandler(this.numero_Click);
            // 
            // botao8
            // 
            this.botao8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao8.Location = new System.Drawing.Point(50, 38);
            this.botao8.Name = "botao8";
            this.botao8.Size = new System.Drawing.Size(32, 32);
            this.botao8.TabIndex = 3;
            this.botao8.Text = "8";
            this.botao8.UseVisualStyleBackColor = true;
            this.botao8.Click += new System.EventHandler(this.numero_Click);
            // 
            // botao9
            // 
            this.botao9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao9.Location = new System.Drawing.Point(88, 38);
            this.botao9.Name = "botao9";
            this.botao9.Size = new System.Drawing.Size(32, 32);
            this.botao9.TabIndex = 4;
            this.botao9.Text = "9";
            this.botao9.UseVisualStyleBackColor = true;
            this.botao9.Click += new System.EventHandler(this.numero_Click);
            // 
            // botao6
            // 
            this.botao6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao6.Location = new System.Drawing.Point(88, 76);
            this.botao6.Name = "botao6";
            this.botao6.Size = new System.Drawing.Size(32, 32);
            this.botao6.TabIndex = 7;
            this.botao6.Text = "6";
            this.botao6.UseVisualStyleBackColor = true;
            this.botao6.Click += new System.EventHandler(this.numero_Click);
            // 
            // botao5
            // 
            this.botao5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao5.Location = new System.Drawing.Point(50, 76);
            this.botao5.Name = "botao5";
            this.botao5.Size = new System.Drawing.Size(32, 32);
            this.botao5.TabIndex = 6;
            this.botao5.Text = "5";
            this.botao5.UseVisualStyleBackColor = true;
            this.botao5.Click += new System.EventHandler(this.numero_Click);
            // 
            // botao4
            // 
            this.botao4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao4.Location = new System.Drawing.Point(12, 76);
            this.botao4.Name = "botao4";
            this.botao4.Size = new System.Drawing.Size(32, 32);
            this.botao4.TabIndex = 5;
            this.botao4.Text = "4";
            this.botao4.UseVisualStyleBackColor = true;
            this.botao4.Click += new System.EventHandler(this.numero_Click);
            // 
            // botao3
            // 
            this.botao3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao3.Location = new System.Drawing.Point(88, 114);
            this.botao3.Name = "botao3";
            this.botao3.Size = new System.Drawing.Size(32, 32);
            this.botao3.TabIndex = 10;
            this.botao3.Text = "3";
            this.botao3.UseVisualStyleBackColor = true;
            this.botao3.Click += new System.EventHandler(this.numero_Click);
            // 
            // botao2
            // 
            this.botao2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao2.Location = new System.Drawing.Point(50, 114);
            this.botao2.Name = "botao2";
            this.botao2.Size = new System.Drawing.Size(32, 32);
            this.botao2.TabIndex = 9;
            this.botao2.Text = "2";
            this.botao2.UseVisualStyleBackColor = true;
            this.botao2.Click += new System.EventHandler(this.numero_Click);
            // 
            // botao1
            // 
            this.botao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao1.Location = new System.Drawing.Point(12, 114);
            this.botao1.Name = "botao1";
            this.botao1.Size = new System.Drawing.Size(32, 32);
            this.botao1.TabIndex = 8;
            this.botao1.Text = "1";
            this.botao1.UseVisualStyleBackColor = true;
            this.botao1.Click += new System.EventHandler(this.numero_Click);
            // 
            // botao0
            // 
            this.botao0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao0.Location = new System.Drawing.Point(12, 152);
            this.botao0.Name = "botao0";
            this.botao0.Size = new System.Drawing.Size(70, 32);
            this.botao0.TabIndex = 11;
            this.botao0.Text = "0";
            this.botao0.UseVisualStyleBackColor = true;
            this.botao0.Click += new System.EventHandler(this.botao0_Click);
            // 
            // virgula
            // 
            this.virgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.virgula.Location = new System.Drawing.Point(88, 152);
            this.virgula.Name = "virgula";
            this.virgula.Size = new System.Drawing.Size(32, 32);
            this.virgula.TabIndex = 12;
            this.virgula.Text = ",";
            this.virgula.UseVisualStyleBackColor = true;
            this.virgula.Click += new System.EventHandler(this.virgula_Click);
            // 
            // soma
            // 
            this.soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soma.Location = new System.Drawing.Point(126, 152);
            this.soma.Name = "soma";
            this.soma.Size = new System.Drawing.Size(32, 32);
            this.soma.TabIndex = 16;
            this.soma.Text = "+";
            this.soma.UseVisualStyleBackColor = true;
            this.soma.Click += new System.EventHandler(this.soma_Click);
            // 
            // subtracao
            // 
            this.subtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtracao.Location = new System.Drawing.Point(126, 114);
            this.subtracao.Name = "subtracao";
            this.subtracao.Size = new System.Drawing.Size(32, 32);
            this.subtracao.TabIndex = 15;
            this.subtracao.Text = "-";
            this.subtracao.UseVisualStyleBackColor = true;
            this.subtracao.Click += new System.EventHandler(this.subtracao_Click);
            // 
            // multiplicacao
            // 
            this.multiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicacao.Location = new System.Drawing.Point(126, 76);
            this.multiplicacao.Name = "multiplicacao";
            this.multiplicacao.Size = new System.Drawing.Size(32, 32);
            this.multiplicacao.TabIndex = 14;
            this.multiplicacao.Text = "*";
            this.multiplicacao.UseVisualStyleBackColor = true;
            this.multiplicacao.Click += new System.EventHandler(this.multiplicacao_Click);
            // 
            // divisao
            // 
            this.divisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisao.Location = new System.Drawing.Point(126, 38);
            this.divisao.Name = "divisao";
            this.divisao.Size = new System.Drawing.Size(32, 32);
            this.divisao.TabIndex = 13;
            this.divisao.Text = "/";
            this.divisao.UseVisualStyleBackColor = true;
            this.divisao.Click += new System.EventHandler(this.divisao_Click);
            // 
            // cos
            // 
            this.cos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cos.Location = new System.Drawing.Point(201, 76);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(32, 32);
            this.cos.TabIndex = 20;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.cos_Click);
            // 
            // sen
            // 
            this.sen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sen.Location = new System.Drawing.Point(201, 38);
            this.sen.Name = "sen";
            this.sen.Size = new System.Drawing.Size(32, 32);
            this.sen.TabIndex = 19;
            this.sen.Text = "sen";
            this.sen.UseVisualStyleBackColor = true;
            this.sen.Click += new System.EventHandler(this.sen_Click);
            // 
            // potencia
            // 
            this.potencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potencia.Location = new System.Drawing.Point(163, 76);
            this.potencia.Name = "potencia";
            this.potencia.Size = new System.Drawing.Size(32, 32);
            this.potencia.TabIndex = 18;
            this.potencia.Text = "^";
            this.potencia.UseVisualStyleBackColor = true;
            this.potencia.Click += new System.EventHandler(this.potencia_Click);
            // 
            // raiz
            // 
            this.raiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raiz.Location = new System.Drawing.Point(163, 38);
            this.raiz.Name = "raiz";
            this.raiz.Size = new System.Drawing.Size(32, 32);
            this.raiz.TabIndex = 17;
            this.raiz.Text = "raiz";
            this.raiz.UseVisualStyleBackColor = true;
            this.raiz.Click += new System.EventHandler(this.raiz_Click);
            // 
            // porcentagem
            // 
            this.porcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.porcentagem.Location = new System.Drawing.Point(163, 114);
            this.porcentagem.Name = "porcentagem";
            this.porcentagem.Size = new System.Drawing.Size(32, 32);
            this.porcentagem.TabIndex = 23;
            this.porcentagem.Text = "%";
            this.porcentagem.UseVisualStyleBackColor = true;
            this.porcentagem.Click += new System.EventHandler(this.porcentagem_Click);
            // 
            // resto
            // 
            this.resto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resto.Location = new System.Drawing.Point(163, 152);
            this.resto.Name = "resto";
            this.resto.Size = new System.Drawing.Size(70, 32);
            this.resto.TabIndex = 22;
            this.resto.Text = "resto";
            this.resto.UseVisualStyleBackColor = true;
            this.resto.Click += new System.EventHandler(this.resto_Click);
            // 
            // tg
            // 
            this.tg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tg.Location = new System.Drawing.Point(201, 114);
            this.tg.Name = "tg";
            this.tg.Size = new System.Drawing.Size(32, 32);
            this.tg.TabIndex = 21;
            this.tg.Text = "tg";
            this.tg.UseVisualStyleBackColor = true;
            this.tg.Click += new System.EventHandler(this.tg_Click);
            // 
            // limpar
            // 
            this.limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpar.Location = new System.Drawing.Point(239, 38);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(32, 32);
            this.limpar.TabIndex = 24;
            this.limpar.Text = "C";
            this.limpar.UseVisualStyleBackColor = true;
            this.limpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // fibonnaciR
            // 
            this.fibonnaciR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fibonnaciR.Location = new System.Drawing.Point(277, 76);
            this.fibonnaciR.Name = "fibonnaciR";
            this.fibonnaciR.Size = new System.Drawing.Size(32, 32);
            this.fibonnaciR.TabIndex = 25;
            this.fibonnaciR.Text = "FiR";
            this.fibonnaciR.UseVisualStyleBackColor = true;
            this.fibonnaciR.Click += new System.EventHandler(this.fibonacciRecursivo_Click);
            // 
            // fibonacciI
            // 
            this.fibonacciI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fibonacciI.Location = new System.Drawing.Point(277, 38);
            this.fibonacciI.Name = "fibonacciI";
            this.fibonacciI.Size = new System.Drawing.Size(32, 32);
            this.fibonacciI.TabIndex = 26;
            this.fibonacciI.Text = "FiI";
            this.fibonacciI.UseVisualStyleBackColor = true;
            this.fibonacciI.Click += new System.EventHandler(this.fibonacciIterativo_Click);
            // 
            // fatorialIterativo
            // 
            this.fatorialIterativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatorialIterativo.Location = new System.Drawing.Point(276, 113);
            this.fatorialIterativo.Name = "fatorialIterativo";
            this.fatorialIterativo.Size = new System.Drawing.Size(32, 32);
            this.fatorialIterativo.TabIndex = 28;
            this.fatorialIterativo.Text = "FaI";
            this.fatorialIterativo.UseVisualStyleBackColor = true;
            this.fatorialIterativo.Click += new System.EventHandler(this.fatorialIterativo_Click);
            // 
            // fatorialRecursivo
            // 
            this.fatorialRecursivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.fatorialRecursivo.Location = new System.Drawing.Point(276, 151);
            this.fatorialRecursivo.Name = "fatorialRecursivo";
            this.fatorialRecursivo.Size = new System.Drawing.Size(32, 32);
            this.fatorialRecursivo.TabIndex = 27;
            this.fatorialRecursivo.Text = "FaR";
            this.fatorialRecursivo.UseVisualStyleBackColor = true;
            this.fatorialRecursivo.Click += new System.EventHandler(this.fatorialRecursivo_Click);
            // 
            // JanelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 195);
            this.Controls.Add(this.fatorialIterativo);
            this.Controls.Add(this.fatorialRecursivo);
            this.Controls.Add(this.fibonacciI);
            this.Controls.Add(this.fibonnaciR);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.porcentagem);
            this.Controls.Add(this.resto);
            this.Controls.Add(this.tg);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.sen);
            this.Controls.Add(this.potencia);
            this.Controls.Add(this.raiz);
            this.Controls.Add(this.soma);
            this.Controls.Add(this.subtracao);
            this.Controls.Add(this.multiplicacao);
            this.Controls.Add(this.divisao);
            this.Controls.Add(this.virgula);
            this.Controls.Add(this.botao0);
            this.Controls.Add(this.botao3);
            this.Controls.Add(this.botao2);
            this.Controls.Add(this.botao1);
            this.Controls.Add(this.botao6);
            this.Controls.Add(this.botao5);
            this.Controls.Add(this.botao4);
            this.Controls.Add(this.botao9);
            this.Controls.Add(this.botao8);
            this.Controls.Add(this.botao7);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "JanelaPrincipal";
            this.Text = "Calculadora - Pissurno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button botao7;
        private System.Windows.Forms.Button botao8;
        private System.Windows.Forms.Button botao9;
        private System.Windows.Forms.Button botao6;
        private System.Windows.Forms.Button botao5;
        private System.Windows.Forms.Button botao4;
        private System.Windows.Forms.Button botao3;
        private System.Windows.Forms.Button botao2;
        private System.Windows.Forms.Button botao1;
        private System.Windows.Forms.Button botao0;
        private System.Windows.Forms.Button virgula;
        private System.Windows.Forms.Button soma;
        private System.Windows.Forms.Button subtracao;
        private System.Windows.Forms.Button multiplicacao;
        private System.Windows.Forms.Button divisao;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button sen;
        private System.Windows.Forms.Button potencia;
        private System.Windows.Forms.Button raiz;
        private System.Windows.Forms.Button porcentagem;
        private System.Windows.Forms.Button resto;
        private System.Windows.Forms.Button tg;
        private System.Windows.Forms.Button limpar;
        private System.Windows.Forms.Button fibonnaciR;
        private System.Windows.Forms.Button fibonacciI;
        private System.Windows.Forms.Button fatorialIterativo;
        private System.Windows.Forms.Button fatorialRecursivo;
    }
}

