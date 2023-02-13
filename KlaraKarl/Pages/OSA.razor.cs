﻿using System.ComponentModel.DataAnnotations;

namespace KlaraKarl.Pages
{
    public class Osaformmodel
    {
        [Required (ErrorMessage = "Name måste anges")]
        [StringLength(50, ErrorMessage = "För långt namn kan endast innehålla 50 tecken.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Epost måste anges")]
        [StringLength(50, ErrorMessage = "För långt namn kan endast innehålla 50 tecken.")]
        public string Email { get; set; }
        [StringLength(1000, ErrorMessage = "För långt max 1000 tecken.")]
        public string Otherinfo { get; set; }

        public string customAllergy { get; set; }
        public List <String> Allergy { get; set; }
    }
}
