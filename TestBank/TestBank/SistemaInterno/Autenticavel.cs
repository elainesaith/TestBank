using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBank.Entidades;

namespace TestBank.SistemaInterno
{
    public abstract class Autenticavel: Funcionario
    {
        public Autenticavel(string cpf, string nome, double salario) : base(cpf, nome, salario)
        {
            this.login = this.nome.Substring(0, this.nome.IndexOf(" "));
            this.senha = "@#" + this.cpf + "!";
        }
        public string login { get; set; }
        public string senha { get; private set; }
        public bool Autenticar(string login, string senha)
        {
            return this.login.Equals(login) && this.senha.Equals(senha);
        }
        public void AlterarSenha(string senhaAntiga, string senhaNova)
        {
            if (this.senha.Equals(senhaAntiga))
            {
                this.senha = senhaNova;
            }
        }
    }
}
