using System;
using System.Collections.Generic;

namespace StudentApi.Models;

public partial class StudentInfo
{
    public int StudId { get; set; }

    public string StudName { get; set; } = null!;

    public int StudAge { get; set; }

    public string? StudContact { get; set; }

    public string StudEmail { get; set; } = null!;
}
