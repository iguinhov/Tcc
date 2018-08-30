using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tcc.Models
{
    public class Usuarios
    {
        public int ID { get; set; }

        
        [Required]
        public string Password { get; set; }

    }
}