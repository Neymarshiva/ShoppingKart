using EmplyoeeManagementModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmplyoeeManagement.Web.Models
{
    public class EditEmployeeModel:Emplyoee
    {        
        [CompareProperty("Email",
            ErrorMessage = "Email and Confirm Email must match")]
        public string ConfirmEmail { get; set; }
    }
}
