using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IntegradorEC1.Domain.Models
{
    [Table("comando")]
    public class Comando
    {
        [Key]
        [Column("COD_COMAND")]
        public int CodigoComando { get; set; }
        [Column("DESC_COMAND")]
        public string DescricaoComando { get; set; }
    }
}