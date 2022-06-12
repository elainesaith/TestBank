using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBank.Entidades
{
    public class Diretor: Funcionario
    {
        public override double CalcularComissao()
        {
            return this.salario * 1.1;
        }
        public override double PremioSemestral()
        {
            return salario + base.PremioSemestral();
        }
        public Diretor(string cpf, double salario): base(cpf, salario)
        {
            Console.WriteLine("Criando um diretor..");
        }
        public override void AumentarSalario()
        {
            this.salario *= 1.15;
        }
    }
}
