using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBBHackton.Data.Model
{
    public class Curso : BaseModel
    {
        [Required]
        [Display(Name = "Nome do Curso")]
        public string NomeCurso { get; set; }

        [Required]
        [Display(Name = "Instituição de ensino")]
        public string Universidade { get; set; }

        [Required]
        [Display(Name = "Data de início")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataInicio { get; set; }

        [Required]
        [Display(Name = "Data de conclusão")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataConclusao { get; set; }

        public int PerfilId { get; set; }

        [ForeignKey("PerfilId")]
        public virtual Perfil Perfil { get; set; }

        [Required]
        public string Atribuicao { get; set; }
    }
}
