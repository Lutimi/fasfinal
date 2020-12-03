using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UsuarioProfileService.Entities
{
    public partial class UsuarioProfile
    {
        
     
        public int UsuarioId { get; set; }
   
        [Required(ErrorMessage = "Nombre asdasdsda")]
        [StringLength(20, ErrorMessage = "Nombre permite hasta 2asdasdsd")]
        [DataType(DataType.Text)]
        public string Nombre { get; set; }
  
        [Required(ErrorMessage = "Apellido es requerido")]
        [StringLength(20, ErrorMessage = "Apellido permite asdasdads")]
        [DataType(DataType.Text)]
        public string Apellido { get; set; }
      
        [StringLength(10, ErrorMessage = "Celular asd adsdas")]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string Celular { get; set; }
  
        [StringLength(50, ErrorMessage = "Correo permite asdas")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Correo { get; set; }


    }
}
