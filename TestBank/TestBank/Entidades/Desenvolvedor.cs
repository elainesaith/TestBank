using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBank.Entidades
{
    public class Desenvolvedor: Funcionario
    {
        public Desenvolvedor(string cpf, string nome, double salario) : base(cpf, nome, salario)
        {

        }

        public override void AumentarSalario()
        {
            salario *= 1.11;
        }

        public override double CalcularComissao()
        {
            return salario * 0.11;
        }
    }
}
