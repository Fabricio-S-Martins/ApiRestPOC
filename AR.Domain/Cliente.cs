using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AR.Domain
{
    [Table("Cliente")]
    //Classe de nome Cliente
    public class Cliente
    {
        [Key]
        //Propriedades da Classe
        public Guid Id { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        [MaxLength(50, ErrorMessage = "O campo {0} deve ter no maximo {1} caracteres")]
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int Idade { get; set; }
    }
}
