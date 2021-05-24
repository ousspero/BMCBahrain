using System;
using System.Collections.Generic;
using System.Text;

namespace BMSBahrain.Models
{
    public class RegisterModel
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string FatherName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string BloodGroup { get; set; }
        public int? Age { get; set; }
        public double? Weight { get; set; }
        public double? Height { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
