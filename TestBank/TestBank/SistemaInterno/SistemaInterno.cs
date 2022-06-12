using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBank.Entidades;

namespace TestBank.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(Autenticavel usuario, string senha)
        {
            bool usuarioAutenticado = usuario.Autenticar(usuario.login, senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Login bem sucedido!");
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
            }
            return usuarioAutenticado;
        }
    }
}
