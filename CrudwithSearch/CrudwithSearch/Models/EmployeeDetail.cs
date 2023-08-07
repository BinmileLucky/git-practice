using System;
using System.Collections.Generic;

namespace CrudwithSearch.Models;

public partial class EmployeeDetail
{
    public int Id { get; set; }

    public string EmpName { get; set; } = null!;

    public string EmpDepartment { get; set; } = null!;

    public string EmpPhone { get; set; } = null!;

    public string Address { get; set; } = null!;
}
