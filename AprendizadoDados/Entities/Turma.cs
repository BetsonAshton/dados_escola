using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AprendizadoDados.Entities
{
    public class Turma
    {
        private Guid _idTurma;
        private string _nome;
        private DateTime _dataInicio;
        private string _horario;
        private Professor _professor;
        private Curso _curso;

        public Guid IdTurma
        {
            set
            {
                if(value == Guid.Empty)
                throw new ArgumentNullException("Por favor informe um valor válido");

                _idTurma = value;
            }
            get => _idTurma;
        }

        public string Nome
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Por favor informe o nome da turma");

                var regex = new Regex("^[A-za-zÁ-Ü\\S]{3,150}$");
                if (!regex.IsMatch(value))
                    throw new ArgumentException("Por favor digite um nome válido");
                _nome = value;
            }
            get => _nome;
        }

        public DateTime DataInicio
        {
            set
            {
                if (value == DateTime.MinValue)
                    throw new ArgumentNullException("Por favor informe a data de início");
                _dataInicio = value;
            }
            get => _dataInicio;
        }

        public string Horario
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Por favor informe um horário");
                _horario = value;

            }
            get => _horario;    
        }

        public Professor Professor { get => _professor; set => _professor = value; }
        public Curso Curso { get => _curso; set => _curso = value; }
    }
}
