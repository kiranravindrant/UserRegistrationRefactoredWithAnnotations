using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace UserRegistration_With_Annotations
{
    class SetUserRules
    {
        [Required(ErrorMessage = "First name is required")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "First name should have minimum 3 characters")]
        [RegularExpression(@"^[A-Z][a-z]{3,}$", ErrorMessage = "Invalid Format")]
        [DataType(DataType.Text)]
        public string firstName { get; set; }



        [Required(ErrorMessage = "Lastname is required")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Last name should have minimum 3 characters")]
        [RegularExpression(@"^[A-Z][a-z]{3,}$", ErrorMessage = "last name is Invalid")]
        [DataType(DataType.Text)]
        public string lastName { get; set; }

        

        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(@"^[A-z a-z  ]{3,}[-+0-9 ]?[.]?([a-z A-z 0-9]{3,})?[@][a-z A-z 0-9]{1,}[.]?[a-z]{2,}[.]?[a-z]{2,3}$", ErrorMessage = "Email id is invalid")]
        [DataType(DataType.EmailAddress)]
        public string emailId { get; set; }

   

        [Required(ErrorMessage = "Mobile number is required")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^[9][1][ ][0-9]{10}$", ErrorMessage = "Phone Number is invalid")]
        [Phone]
        public string phoneNum { get; set; }



        [Required(ErrorMessage = "password is required")]
        [RegularExpression(@"^((?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*-_.])(?=.{8,}))", ErrorMessage = "Passsword is invalid")]
        [DataType(DataType.Password)]
        public string password { get; set; }


    }
}
