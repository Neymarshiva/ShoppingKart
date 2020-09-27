using HelperClass.Componet;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace EmplyoeeManagementModels
{
    public class Emplyoee
    {
        public int EmplyoeeId { get; set; }
        [Required(ErrorMessage = "FirstName is mandatory")]        
        [StringLength(100, MinimumLength = 2)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName is mandatory")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is Not valid")]
        [EmailAddress]
        [EmailDomainValidator(AllowedDomain = "yopmail.com")]
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public int DepartmentId { get; set; }
        public string PhotoPath { get; set; }        
        public Department Department { get; set; }

    }
}
