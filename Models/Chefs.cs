using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace chefDish.Models {
    // public class MinimumAgeAttribute: ValidationAttribute {
    //     int _minimumAge;
    //     public MinimumAgeAttribute(int minimumAge) {
    //         _minimumAge = minimumAge;
    //     }

    //     public override bool IsValid(object value) {
    //         DateTime date;
    //         if (DateTime.TryParse(value.ToString(), out date)) {
    //             return date.AddYears(_minimumAge) < DateTime.Now;
    //         }
    //         return false;
    //     }
    // }

    public class ValidBirthday : ValidationAttribute {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext){
            if ((DateTime)value > DateTime.Now) {
                return new ValidationResult("Birthday must be in the past");
            } else {
                return ValidationResult.Success;
            }
        }
    }

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
        // [MinimumAge(18)]
        [DataType(DataType.Date)]
        [Display(Name = "Birthday")]
        public DateTime Birthday {get;set;}
        public int Age {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public List<Dish> Dishes {get;set;}
    }
}