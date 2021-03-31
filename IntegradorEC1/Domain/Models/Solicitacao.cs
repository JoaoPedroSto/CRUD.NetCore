using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IntegradorEC1.Domain.Models
{
    [Table("SOLICITACAO")]
    public class Solicitacao
    {
        [Key]
        [Column("COD_SOLI")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CodicoSolicitacao { get; set; }

        [Required]
        [Column("DAT_HOR_SOLI")]
        public DateTime DataSolicitacao { get; set; }

        [Column("DAT_HOR_INI_FLUX")]
        public DateTime InicioFluxo { get; set; }

        [Column("DAT_HOR_FIM_FLUX")]
        public DateTime FimFluxo { get; set; }
    }
}
