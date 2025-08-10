
namespace Entities.DAos;

public class Department
{
    public int Did { get; set; }
    public string? DName { get; set; }
    public string? Description { get; set; }
    public bool IsActive { get; set; }

    public virtual IEnumerable<Employee>? Employees { get; set; }
}
