using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace chefDish.Models {
    public class Chef {
        [Key]
        public int ChefId {get;set;}

        [Required]
        [MinLength(2, ErrorMessage = "First name must be at least 2 characters")]
        [Display(Name = "First Name")]
        public string FirstName {get;set;}

        [Required]
        [MinLength(2, ErrorMessage = "Last name must be at least 2 characters")]
        [Display(Name = "Last Name")]
        public string LastName {get;set;}

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Birthday")]
        public DateTime Birthday {get;set;}
        public int Age {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public List<Dish> Dishes {get;set;}
    }
}