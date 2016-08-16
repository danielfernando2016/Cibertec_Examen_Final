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
    public class Books
    {
        [Key]
        [Display(Name = "Books_title_id", ResourceType = typeof(Resource))]
        public int title_id { get; set; }

        [Required(ErrorMessage = "Por favor ingresa el Titulo del Libro")]
        [StringLength(180)]
        [Display(Name = "Books_title", ResourceType = typeof(Resource))]
        public string title { get; set; }

        [Display(Name = "Books_type", ResourceType = typeof(Resource))]
        [StringLength(25)]
        public string type { get; set; }

        [Required(ErrorMessage = "Por favor ingresa el Codigo de Publicacion")]
        [Display(Name = "Books_pub_id", ResourceType = typeof(Resource))]
        public int pub_id { get; set; }

        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Por favor ingresa el Precio del Libro")]
        [Column(TypeName = "money")]
        [Display(Name = "Books_price", ResourceType = typeof(Resource))]
        public decimal price { get; set; }

        [Display(Name = "Books_advance", ResourceType = typeof(Resource))]
        public int advance { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Books_ytd_sales", ResourceType = typeof(Resource))]
        [Column(TypeName = "money")]
        public decimal ytd_sales { get; set; }


        [Display(Name = "Books_notes", ResourceType = typeof(Resource))]
        [StringLength(350)]
        public string notes { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Books_pubdate", ResourceType = typeof(Resource))]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? pubdate { get; set; }


    }
}
