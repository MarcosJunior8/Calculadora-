using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Class1
    {
        private List<double> listnumero = new List<double>();
        

            public void addnumero(double num)
        {
            this.listnumero.Add(num);
        }

        public double somar()
        {
            double resultado = 0;
            foreach (double numero in this.listnumero)
            {
                resultado += numero;
            }
            this.listnumero.Clear();
            return resultado;

        }

        public double subtrair()
        {
            double resultado = this.listnumero[0];
            this.listnumero.RemoveAt(0);
            foreach (double numero in this.listnumero)
            {
                resultado -= numero;
            }
            this.listnumero.Clear();
            return resultado;

        }

        public double mult()
        {
            double resultado = this.listnumero[0];
            this.listnumero.RemoveAt(0);
            foreach (double numero in this.listnumero)
            {
                resultado *= numero;
            }
            this.listnumero.Clear();
            return resultado;

        }

        public double divisao()
        {
            double resultado = this.listnumero[0];
            this.listnumero.RemoveAt(0);
            foreach (double numero in this.listnumero)
            {
                resultado /= numero;
            }
            this.listnumero.Clear();
            return resultado;

        }

        public double media()
        {
            double resultado = 0;
            double x = 0;
            foreach(double numero in this.listnumero)
            {
                resultado += numero;
                x = resultado / this.listnumero.Count;
            }

            return x;
        }





    }
}

    

