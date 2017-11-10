
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBBHackton.Data.Model
{
    public class Perfil : BaseModel
    {
        [Required]
        [Display(Name = "Nome")]
        public string FullName { get; set; }

        [DataType(DataType.ImageUrl)]
        public string Foto { get; set; }

        public string LinkSocialMedia { get; set; }

        [Required]
        [Display(Name = "Data de nascimento")]
        [DataType(DataType.Date)]        
        public DateTime DataNascimento { get; set; }
                  

        public virtual List<Curso> Cursos { get; set; }

        public virtual List<ExpProfissional> Experiencias { get; set; }

        [Required]        
        public string AboutMe { get; set; }


    }
}
