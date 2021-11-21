using System;

namespace mentoring.Models
{
    public class Servico
    {
        public int Id { get; set; }
        public int Colaborador { get; set; }
        public string Nome { get; set; }
        public int Preco { get; set; }
        public DateTime DataServico { get; set; }

    }

}