using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBank.Entidades
{
    public abstract class Funcionario
    {
        public string nome { get; set; }
        public string cpf { get; private set; }
        public double salario { get; protected set; }

        public abstract double CalcularComissao();

        public virtual double PremioSemestral()
        {
            return salario * 0.2;
        }

        public static int numeroTotalFuncionarios { get; private set; }
        public Funcionario(string cpf, double salario)
        {
            this.cpf = cpf;
            this.salario = salario;
            numeroTotalFuncionarios++;
        }
        public abstract void AumentarSalario();
    }
}
