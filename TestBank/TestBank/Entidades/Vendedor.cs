using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBank.Entidades
{
    public class Vendedor: Funcionario
    {
        public Vendedor(string cpf,  string nome, double salario) : base(cpf, nome, salario)
        {

        }

        public override void AumentarSalario()
        {
            salario *= 1.21;
        }

        public override double CalcularComissao()
        {
            return salario * 0.21;
        }
    }
}
