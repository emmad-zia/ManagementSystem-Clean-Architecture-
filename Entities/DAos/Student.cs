// See https://aka.ms/new-console-template for more information
namespace Entities.DAos;

public class Student
{
    public int Sid { get; set; }
    public string? SName { get; set; }
    public string? Contact { get; set; }

    public virtual IEnumerable<StudentCourse>? StudentCourses { get; set; }
}