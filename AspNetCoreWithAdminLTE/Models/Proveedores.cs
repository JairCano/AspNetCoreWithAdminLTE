using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreWithAdminLTE.Models
{
    public class Proveedores
    {
        [Key]
        public int id { get; set; }


        [Required(ErrorMessage = "El Nombre es Obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres", MinimumLength = 10)]
        [Display(Name = "Nombre")]
        public String Nombre { get; set; }


        [Required(ErrorMessage = "El Email es Obligatorio")]
        [Display(Name = "Email")]
        public String Email { get; set; }

        [Required(ErrorMessage = "El Telefono es Obligatorio")]
        [StringLength(10, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres", MinimumLength = 6)]
        [Display(Name = "Telefono")]
        public String Telefono { get; set; }


    }
}

