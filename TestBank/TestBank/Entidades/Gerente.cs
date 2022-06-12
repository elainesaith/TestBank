using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBank.SistemaInterno;

namespace TestBank.Entidades
{
    public class Gerente : Autenticavel
    {
        public Gerente(string cpf, string nome, double salario) : base(cpf, nome, salario)
        {
            Console.WriteLine("Criando um gerente...");
        }

        public override void AumentarSalario()
        {
            this.salario *= 1.05;
        }

        public override double CalcularComissao()
        {
            return this.salario * 0.8;
        }
    }
}
