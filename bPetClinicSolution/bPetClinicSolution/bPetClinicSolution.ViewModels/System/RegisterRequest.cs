using System;
using System.Collections.Generic;
using System.Text;

namespace bPetClinicSolution.ViewModels.System
{
    public class RegisterRequest
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Dob { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }

        public string email { get; set; }
        public string PhoneNumber { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
