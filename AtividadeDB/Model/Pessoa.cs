using System.ComponentModel.DataAnnotations;

namespace AtividadeDB.Model
{
    public class Pessoas
    {
        public int ID { get; set; }

        [MaxLength(100)]
        public string Nome { get; set; }

        [MaxLength(15)]
        public string? NumeroCelular { get; set; }

        public DateOnly DataNascimento { get; set; }


    }
}
