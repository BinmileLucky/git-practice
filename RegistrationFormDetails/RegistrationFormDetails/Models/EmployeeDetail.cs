using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RegistrationFormDetails.Models;

public partial class EmployeeDetail
{
   
    public int Id { get; set; }
    [Required]
    public string EmpName { get; set; } = null!;
    [Required]
    public string EmpDepartment { get; set; } = null!;
    [Required]
    public string EmpPhone { get; set; } = null!;
    [Required]
    public string Address { get; set; } = null!;
}
