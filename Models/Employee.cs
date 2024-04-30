using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class Employee
{
    public int Id { get; set; }

    public int EmployeeNumber { get; set; }

    public string EmployeeName { get; set; } = null!;
}
