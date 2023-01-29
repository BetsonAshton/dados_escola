using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendizadoDados.Entities
{
    public class Curso
    {
        private Guid _idCurso;
        private string _titulo;
        private decimal _cargaHoraria;


        public Guid IdCurso
        {
            set
            {
                if (value == Guid.Empty)
                    throw new ArgumentException("Por favor informe o id do curso válido");
                _idCurso = value;
            }
            get => _idCurso;
        }

        public string Titulo
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Por favor informe o titulo do curso");
                _titulo = value;
            }
            get => _titulo;
        }

        public decimal CargaHoraria { get => _cargaHoraria; set => _cargaHoraria = value; }
    }
}
