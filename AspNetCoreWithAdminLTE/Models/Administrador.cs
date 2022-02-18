using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreWithAdminLTE.Models
{
    public class Administrador
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "El email es requerido")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El password es requerido")]
        [DataType(DataType.Password)]
        public string Password { get; set; }







    }
}



