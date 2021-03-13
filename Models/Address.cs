using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Pierwsze_API.Models
{
    public class Address
    {
        [Display(Name = "Twoja ulica")]
        [StringLength(60, MinimumLength =3), Required(ErrorMessage = "To pole jest wymagane")]
        public string Street { get; set; }
        
        [Display(Name = "Kod pocztowy")]
        [Required(ErrorMessage = "Pole Kod pocztowy obowiązkowe")]
        public string ZipCode { get; set; }
     
        [Display(Name = "Miasto")]
        [Required(ErrorMessage = "Pole Miasto obowiązkowe")]
        public string City { get; set; }

        [Display(Name = "Numer")]
        [Required]
        public int Number { get; set; }

    }
}
