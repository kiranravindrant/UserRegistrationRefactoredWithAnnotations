using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace UserRegistration_With_Annotations
{
    class ValidateUser
    {
        

        public static void Display( )
        {
            Console.WriteLine("UserRegistration  Validations");
            Console.WriteLine("===============================");
            SetUserRules objuser = new SetUserRules();

            Console.WriteLine("Enter the First Name");
            objuser.firstName = Console.ReadLine();

            Console.WriteLine("Enter the LastName");
            objuser.lastName = Console.ReadLine();

            Console.WriteLine("Enter Email ID");
            objuser.emailId = Console.ReadLine();

            Console.WriteLine("Enter MobileNo ");
            objuser.phoneNum = Console.ReadLine();

            Console.WriteLine("Enter Passsword ");
            objuser.password = Console.ReadLine();


            ValidationContext Context = new ValidationContext(objuser, null, null);

            List<ValidationResult> Results = new List<ValidationResult>();

            bool isvalid = Validator.TryValidateObject(objuser, Context, Results, true);

            if (!isvalid)
            {
                

                foreach (ValidationResult validationResult in Results)
                {

                    Console.WriteLine("Member Name : {0}", validationResult.MemberNames.First(), Environment.NewLine);
                    Console.WriteLine("Error Msg : {0}{1}", validationResult.ErrorMessage, Environment.NewLine);
                    Console.WriteLine(validationResult.ErrorMessage);

                }
            }
            else
            {
                Console.WriteLine($"Firstname  {objuser.firstName}");
                Console.WriteLine($"Lastname   {objuser.lastName}");
                Console.WriteLine($"Email id   {objuser.emailId}");
                Console.WriteLine($"Phone NO:  {objuser.phoneNum}");
            }
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();

        }
    }

}