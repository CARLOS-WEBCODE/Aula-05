using ProjetoAula05.Enums;
using ProjetoAula05.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private DateTime? _dataAdmissao;
        private TipoContratacao? _tipo;

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
                var regex = new Regex("^[A-Za-zÀ-Üà-ü\\s]{6,150}$");
                if (!regex.IsMatch(value))
                    throw new ValidationsException("Nome do funcionário inválido.");

                _nome = value;
            }
        }

        public string Cpf
        {
            get => _cpf;
            set
            {
                var regex = new Regex("^[0-9]{11}$");
                if (!regex.IsMatch(value))
                    throw new ValidationsException("CPF inválido (Informe 11 digitos numéricos");

                _cpf = value;
            }
        }

        public string Matricula
        {
            get => _matricula;
            set
            {
                var regex = new Regex("^[0-9]{4}$");
                if (!regex.IsMatch(value))
                    throw new ValidationsException("Matrícula inválido (Informe 4 digitos numéricos");

                _matricula = value;
            }
        }

        public DateTime? DataAdmissao
        {
            get => _dataAdmissao;
            set { _dataAdmissao = value;}
        }

        public TipoContratacao? Tipo
        {
            get => _tipo;
            set { _tipo = value; }
        }


        #endregion
    }
}
