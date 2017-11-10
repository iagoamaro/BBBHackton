using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBBHackton.Data.Model
{
    public class ExpProfissional : BaseModel
    {
        [Required]
        public string Cargo { get; set; }

        [Required]
        public string Empresa { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Data de início")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataInicio { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Data de desligamento")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataFinal { get; set; }

        public int PerfilId { get; set; }

        [ForeignKey("PerfilId")]
        public virtual Perfil Perfil { get; set; }

        [Required]
        public string Atribuicao { get; set; }
    }
}
