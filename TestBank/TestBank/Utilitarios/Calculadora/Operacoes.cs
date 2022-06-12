using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBank.Utilitarios.Calculadora
{
    public class Operacoes
    {
        public Soma soma { get; set; }
        public Subtracao subtracao { get; set; }
        public Multiplicacao multiplicacao { get; set; }
        public Divisao divisao { get; set; }
        public Operacoes()
        {
            this.soma = new Soma();
            this.subtracao = new Subtracao();
            this.multiplicacao = new Multiplicacao();
            this.divisao = new Divisao();
        }

    }
}
