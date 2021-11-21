using System;

namespace mentoring.Models
{
    public class Colaborador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public DateTime DataContratacao { get; set; }

    }

}
