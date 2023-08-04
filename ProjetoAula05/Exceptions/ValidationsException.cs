using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula05.Exceptions
{
    /// <summary>
    /// Classe de exceção customizada para erros de validação do projeto
    /// </summary>
    public class ValidationsException : Exception
    {
        //atributo
        private readonly string _mensagem;

        //método construtor -> ctor + 2[tab]
        public ValidationsException(string mensagem)
        {
            _mensagem = mensagem;
        }

        //sobrescrita do método Message da classe Exception
        public override string Message => $"Ocorreu um erro de validação: {_mensagem}";
    }
}
