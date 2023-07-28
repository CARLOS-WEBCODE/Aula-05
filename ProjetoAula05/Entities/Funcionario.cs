using ProjetoAula05.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula05.Entities
{
    /// <summary>
    /// Classe de entidade
    /// </summary>
    public class Funcionario
    {
        #region Atributos

        private Guid _id;
        private string _nome;
        private string _cpf;
        private string _matricula;
        private DateTime _dataAdmissao;
        private TipoContratacao _Tipo;

        #endregion

        #region Propriedades

        public Guid Id
        {
            get => _id;
            set { _id = value; }
        }

        public string Nome
        {
            get => _nome;
            set
            {

            }
        }



        #endregion
    }
}
