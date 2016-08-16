using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Cibertec_Examen_Final.Resources;

namespace Cibertec_Examen_Final.Model
{
    public class Authors
    {
        [Key]
        [Display(Name = "Auhor_au_id", ResourceType = typeof(Resource))]
        public int au_id { get; set; }

        [Required(ErrorMessage = "Por favor ingresa tus Apellidos")]
        [StringLength(50)]
        [Display(Name = "Author_au_lname", ResourceType = typeof(Resource))]
        public string au_lname { get; set; }

        [Required(ErrorMessage = "Por favor ingresa tus Nombres")]
        [StringLength(50)]
        [Display(Name = "Author_au_fname", ResourceType = typeof(Resource))]
        public string au_fname { get; set; }

        
        [StringLength(20)]
        [Display(Name = "Author_au_phone", ResourceType = typeof(Resource))]
        public string au_phone { get; set; }

        [Display(Name = "Author_au_city", ResourceType = typeof(Resource))]
        [StringLength(50)]
        public string au_city { get; set; }

        [Display(Name = "Author_au_state", ResourceType = typeof(Resource))]
        [StringLength(50)]
        public string au_state { get; set; }

        [Display(Name = "Author_au_zip", ResourceType = typeof(Resource))]
        [StringLength(50)]
        public string au_zip { get; set; }

        [Display(Name = "Author_au_sex", ResourceType = typeof(Resource))]
        [StringLength(1)]
        public string au_sex { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        [Display(Name = "Author_au_salary", ResourceType = typeof(Resource))]
        public decimal au_salary { get; set; }

        [Display(Name = "Author_au_subject", ResourceType = typeof(Resource))]
        [StringLength(100)]
        public string au_subject { get; set; }
        
    }
}
