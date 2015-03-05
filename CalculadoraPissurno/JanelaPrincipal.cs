using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraPissurno
{
    public partial class JanelaPrincipal : Form
    {
        private Calculador calculador = new Calculador();
        private string numeroAntigo = "0";
        private string numeroAtual = "0";
        private bool limparNoProximoDigito = false;
        private bool limpar2 = false;

        #region Get/Set
        public string NumeroAntigo
        {
            get
            {
                return this.numeroAntigo;
            }
            set
            {
                this.numeroAntigo = value.ToString();
            }
        }
        public string NumeroAtual
        {
            get
            {
                return this.numeroAtual;
            }
            set
            {
                if (value.ToString().Length < textBox1.MaxLength)
                {
                    this.numeroAtual = value.ToString();
                    if (!this.limparNoProximoDigito)
                        textBox1.Text = value.ToString();
                    this.calculador.Valor = this.numeroAtual;
                }
            }
        }
        #endregion Get/Set

        public JanelaPrincipal()
        {
            InitializeComponent();
            textBox1.Text = this.NumeroAtual;
        }

        #region ClickDosNumeros

        private void botao0_Click(object sender, EventArgs e)
        {
            if(this.numeroAtual!="0")
                this.NumeroAtual += 0;
            this.limpar2 = false;
        }

        private void numero_Click(object sender, EventArgs e)
        {
            if (this.numeroAtual != "0" && !this.limparNoProximoDigito)
                this.NumeroAtual += ((Button)sender).Text;
            else
            {
                this.NumeroAtual = ((Button)sender).Text;
                this.limparNoProximoDigito = false;
            }
            this.limpar2 = false;
        }

        #endregion

        #region ClickDasOperacoes

        private void soma_Click(object sender, EventArgs e)
        {
            this.limpar2 = true;
            this.limparNoProximoDigito = true;
            this.AtualizarNumeros();
            this.calculador.Operacao = "soma";
            this.limparNoProximoDigito = false;
        }

        private void subtracao_Click(object sender, EventArgs e)
        {
            this.limpar2 = true;
            this.limparNoProximoDigito = true;
            this.AtualizarNumeros();
            this.calculador.Operacao = "subtracao";
            this.limparNoProximoDigito = false;
        }

        private void multiplicacao_Click(object sender, EventArgs e)
        {
            this.limpar2 = true;
            this.limparNoProximoDigito = true;
            this.AtualizarNumeros();
            this.calculador.Operacao = "multiplicacao";
            this.limparNoProximoDigito = false;
        }

        private void divisao_Click(object sender, EventArgs e)
        {
            this.limpar2 = true;
            this.limparNoProximoDigito = true;
            this.AtualizarNumeros();
            this.calculador.Operacao = "divisao";
            this.limparNoProximoDigito = false;
        }

        private void raiz_Click(object sender, EventArgs e)
        {
            this.calculador.Operacao = "raiz";
            this.limparNoProximoDigito = false;
            this.ProcessarResultado();
        }

        private void potencia_Click(object sender, EventArgs e)
        {
            this.limparNoProximoDigito = true;
            this.AtualizarNumeros();
            this.calculador.Operacao = "potencia";
            this.limparNoProximoDigito = false;
        }

        private void porcentagem_Click(object sender, EventArgs e)
        {
            this.limparNoProximoDigito = true;
            this.AtualizarNumeros();
            this.calculador.Operacao = "porcentagem";
            this.limparNoProximoDigito = false;
        }

        private void resto_Click(object sender, EventArgs e)
        {
            this.limpar2 = true;
            this.limparNoProximoDigito = true;
            this.AtualizarNumeros();
            this.calculador.Operacao = "resto";
            this.limparNoProximoDigito = false;
        }

        private void sen_Click(object sender, EventArgs e)
        {
            this.calculador.Operacao = "seno";
            this.limparNoProximoDigito = false;
            this.ProcessarResultado();
        }

        private void cos_Click(object sender, EventArgs e)
        {
            this.calculador.Operacao = "cosseno";
            this.limparNoProximoDigito = false;
            this.ProcessarResultado();
        }

        private void tg_Click(object sender, EventArgs e)
        {
            this.calculador.Operacao = "tangente";
            this.limparNoProximoDigito = false;
            this.ProcessarResultado();
        }

        #endregion

        #region ProcessarResultado

        private void ProcessarResultado()
        {
            if (this.calculador.Operacao != "none")
            {
                float resultado = 0;
                switch (this.calculador.Operacao)
                {
                    case "soma":
                        if(this.NumeroAtual != "0" && this.NumeroAntigo != "0")
                            resultado = this.calculador.Soma(float.Parse(this.NumeroAntigo));
                        break;

                    case "subtracao":
                        if (this.NumeroAtual != "0" && this.NumeroAntigo != "0")
                            resultado = this.calculador.Subtracao(float.Parse(this.NumeroAntigo));
                        break;

                    case "multiplicacao":
                        if (this.NumeroAtual != "0" && this.NumeroAntigo != "0")
                            resultado = this.calculador.Multiplicacao(float.Parse(this.NumeroAntigo));
                        break;

                    case "divisao":
                        if (this.NumeroAtual != "0" && this.NumeroAntigo != "0")
                            resultado = this.calculador.Divisao(float.Parse(this.NumeroAntigo));
                        break;

                    case "potencia":
                        if (this.NumeroAtual != "0" && this.NumeroAntigo != "0")
                            resultado = this.calculador.Potencia(float.Parse(this.NumeroAntigo));
                        break;

                    case "raiz":
                        resultado = this.calculador.Raiz();
                        break;

                    case "resto":
                        if (this.NumeroAtual != "0" && this.NumeroAntigo != "0")
                            resultado = this.calculador.Resto(float.Parse(this.NumeroAntigo));
                        break;

                    case "seno":
                        resultado = this.calculador.Seno();
                        break;

                    case "cosseno":
                        resultado = this.calculador.Cos();
                        break;

                    case "tangente":
                        resultado = this.calculador.Tg();
                        break;

                    case "porcentagem":
                        if (this.NumeroAtual != "0" && this.NumeroAntigo != "0")
                            resultado = this.calculador.Porcentagem(float.Parse(this.NumeroAntigo));
                        break;
                }
                this.calculador.Operacao = "none";
                this.NumeroAtual = resultado.ToString();
            }
        }

        #endregion

        #region Outros
        /// <summary>
        /// Processa operações remanescentes e atualiza o número
        /// </summary>
        private void AtualizarNumeros()
        {
            this.ProcessarResultado();
            this.NumeroAntigo = this.NumeroAtual;
            if (calculador.Operacao == "none")
                this.NumeroAtual = "0";
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            this.limparNoProximoDigito = false;
            ProcessarResultado();
        }

        private void virgula_Click(object sender, EventArgs e)
        {
            if(this.NumeroAtual.IndexOf(',')==-1)
                this.NumeroAtual += ",";
        }

        private void limpar_Click(object sender, EventArgs e)
        {
            this.NumeroAtual = "0";
            this.NumeroAntigo = "0";
            this.calculador.Operacao = "none";
            this.limpar2 = false;
            this.limparNoProximoDigito = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int cursorPosition = textBox1.SelectionStart;
            try
            {
                //Checagem para ver se o valor é um número
                if (textBox1.Text.IndexOfAny(new char[] { 'e', 'E' }) != -1)
                    throw new Exception();
                else
                    float.Parse(textBox1.Text);
                    

                int _pos = textBox1.Text.IndexOfAny(new char[]{'1','2','3','4','5','6','7','8','9'});
                if (_pos > 0 && textBox1.Text.Length > 1 && textBox1.Text.IndexOf(',') == -1)
                {
                    textBox1.Text = textBox1.Text.Remove(0, _pos);
                    if (cursorPosition > 0)
                        textBox1.SelectionStart = cursorPosition - 1;
                }
                this.NumeroAtual = textBox1.Text;
            }
            catch
            {
                //Tratamento da string
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                    textBox1.Text = "0";

                textBox1.Text = this.NumeroAtual;
                if(cursorPosition>0)
                    textBox1.SelectionStart = cursorPosition-1;
            }
        }

        //Textbox display bugfixer
        private void textBox1_Click(object sender, EventArgs e)
        {
            if (this.limpar2)
            {
                textBox1.Text = "0";
                textBox1.SelectionStart = 1;
                this.limpar2 = false;
            }
        }

        #endregion
    }
}
