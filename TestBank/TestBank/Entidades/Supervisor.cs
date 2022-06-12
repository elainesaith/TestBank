using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBank.Entidades
{
    public class Supervisor: Funcionario
    {
        public double percentualComissao { get; set; }
        public override double CalcularComissao()
        {
            return this.salario * this.percentualComissao;
        }

        public override void AumentarSalario()
        {
            this.salario *= 1.18;
        }

        public Supervisor(string cpf, string nome, double salario) : base(cpf, nome, salario)
        {

        }
    }
}
