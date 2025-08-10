namespace Entities.DAos;
public class Employee
{
    public int Eid { get; set; }

    public string? EmpName { get; set; }
    public string? Gender { get; set; }
    public double Salary { get; set; }
    public DateTime DOB { get; set; }

    public int? Did { get; set; }
    public virtual Department? DepartmentNav { get; set; }


}

