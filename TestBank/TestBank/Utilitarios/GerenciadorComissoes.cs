using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBank.Entidades;

namespace TestBank.Utilitarios
{
    public class GerenciadorComissoes
    {
        private double totalComissao;

        public void Registrar(Funcionario funcionario)
        {
            this.totalComissao += funcionario.CalcularComissao();
        }
        public double TotalComissao()
        {
            return this.totalComissao;
        }

    }
}
