using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreWithAdminLTE.Models
{
    //TODO: 2. Creamos el modelo (Es la tabla en la BD)
    public class Empleados
    {
        [Key]
        public int id { get; set; }

        [Required (ErrorMessage = "El Documento es Obligatorio")]
        [StringLength (12, ErrorMessage ="El {0} debe tener al menos {2} y maximo {1} caracteres", MinimumLength =7)]
        [Display (Name ="Documento")]
        public String Documento { get; set; }

        [Required(ErrorMessage = "El Nombre es Obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres", MinimumLength = 10)]
        [Display(Name = "Nombre")]
        public String Nombre { get; set; }

        [Required(ErrorMessage = "El Apellido es Obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres", MinimumLength = 10)]
        [Display(Name = "Apellido")]
        public String Apellido { get; set; }

        [Required(ErrorMessage = "El Edad es Obligatorio")]
        [StringLength(2, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres", MinimumLength = 2)]
        [Display(Name = "Edad")]
        public String Edad { get; set; }

        [Required(ErrorMessage = "El Email es Obligatorio")]
        [Display(Name = "Email")]
        public String Email { get; set; }

        [Required(ErrorMessage = "El Telefono es Obligatorio")]
        [StringLength(10, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres", MinimumLength = 6)]
        [Display(Name = "Telefono")]
        public String Telefono { get; set; }

        [Required(ErrorMessage = "El Cargo es Obligatorio")]
        [Display(Name = "Cargo")]
        public String Cargo { get; set; }

        [Required(ErrorMessage = "La Fecha es Obligatoria")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha I")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "El Estado es Obligatorio")]
        [Display(Name = "Estado")] 
        public String Estado { get; set; }
    }
}
