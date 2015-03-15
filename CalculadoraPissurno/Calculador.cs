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
                    value == "porcentagem" || value == "none" || value == "fibonacciIterativo" || value == "fibonacciRecursivo" ||
                    value == "fatorialIterativo" || value == "fatorialRecursivo")
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

        public float FibonacciRecursivo(float numero = -1)
        {
            if (this.valor > 0)
            {
                if (numero == -1)
                    numero = this.valor;
                if (numero == 1 || numero == 2)
                    return 1;
                return this.FibonacciRecursivo(numero - 1) + this.FibonacciRecursivo(numero - 2);
            }
            else
                return 0;
        }

        public float FibonacciIterativo()
        {
            if (this.valor < 1)
                return 0;
            float[] n = { 0, 1, 1};
            for (int i = 0; i < this.valor - 1; i++)
            {
                n[2] = n[1];
                n[1] = n[0] + n[1];
                n[0] = n[2];
            }
            return n[1];
        }

        public float FatorialIterativo()
        {
            float result = 1;
            for (int i = 2; i <= this.valor; i++)
                result *= i;
            return result;
        }

        public float FatorialRecursivo(float n = -1)
        {
            if (n == 0)
                return 1;
            else if (n == -1)
                n = this.valor;
            return n * FatorialRecursivo(n - 1);
        }

        #endregion

    }
}
