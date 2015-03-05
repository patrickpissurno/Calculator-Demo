using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPissurno
{
    public class Calculador
    {
        private float valor;
        private string operacao = "none";

        #region Get/Set

        public string Valor
        {
            get
            {
                return valor.ToString();
            }
            set
            {
                valor = float.Parse(value);
            }
        }

        public string Operacao
        {
            get
            {
                return this.operacao;
            }
            set
            {
                if (value == "soma" || value == "subtracao" || value == "multiplicacao" || value == "divisao" || value == "potencia" ||
                    value == "raiz" || value == "seno" || value == "cosseno" || value == "tangente" || value == "resto" ||
                    value == "porcentagem" || value == "none")
                    this.operacao = value;
            }
        }

        #endregion

        #region Operações

        public float Soma(float numero)
        {
            return this.valor + numero;
        }

        public float Subtracao(float numero)
        {
            return numero - this.valor;
        }

        public float Multiplicacao(float numero)
        {
            return this.valor * numero;
        }

        public float Divisao(float numero)
        {
            return numero / this.valor;
        }

        public float Raiz()
        {
            return (float)Math.Sqrt(this.valor);
        }

        public float Potencia(float numero)
        {
            return (float)Math.Pow(numero, this.valor);
        }

        public float Seno()
        {
            return (float)Math.Sin((Math.PI / 180) * this.valor);
        }

        public float Cos()
        {
            return (float)Math.Cos((Math.PI / 180) * this.valor);
        }

        public float Tg()
        {
            return (float)Math.Tan((Math.PI / 180) * this.valor);
        }

        public float Porcentagem(float numero)
        {
            return (this.valor / 100) * numero;
        }

        public float Resto(float numero)
        {
            return numero % this.valor;
        }

        #endregion

    }
}
