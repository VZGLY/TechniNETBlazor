using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechniNETBlazor.Shared.Validators;

namespace TechniNETBlazor.Shared
{
    public class User
    {
        public int Id { get; set; }

        [EmailAddress]
        [Required]
        [NotUpper(ErrorMessage = "Pas de majuscule dans l'email")]
        public string Email { get; set; }
    }
}
