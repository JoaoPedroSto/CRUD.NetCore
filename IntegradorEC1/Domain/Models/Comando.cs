using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IntegradorEC1.Domain.Models
{
    [Table("comando")]
    public class Comando
    {
        [Key]
        [Column("COD_COMAND")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CodigoComando { get; set; }

        [Required]
        [Column("DESC_COMAND")]
        public string DescricaoComando { get; set; }
    }
}