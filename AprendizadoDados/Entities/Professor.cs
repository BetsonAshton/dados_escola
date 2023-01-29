using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AprendizadoDados.Entities
{
    public class Professor
    {
        private Guid _idProfessor;
        private string _nome;
        private string _telefone;
        private string _email;

        public Guid IdProfessor
        {
            set
            {
                if (value == Guid.Empty)
                    throw new ArgumentException("Por favor informe o Id");
                _idProfessor = value;
            }
            get => _idProfessor;
        }

        public string Nome
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Por favor informe o nome do professor");

                var regex = new Regex("^[A-Za-zÁ-Üá-ü\\s]{3,150}$");
                    if (!regex.IsMatch(value))
                    throw new ArgumentException("Por favor informe o nome do professor válido");
                    _nome = value;
               
            }
            get => _nome;
        }

        public string Telefone
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Por favor informe o telefone");
                _telefone = value;
            }
            get => _telefone;
        }
        public string Email
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Por favor informe o Email");
                _email = value;
            }
            get => _email;
        }
    }
}
