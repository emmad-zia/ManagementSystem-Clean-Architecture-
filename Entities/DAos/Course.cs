namespace Entities.DAos;

public class Course
{
    public int Cid { get; set; }
    public string? CName { get; set; }
    public string? Description { get; set; }
    public virtual IEnumerable<StudentCourse>? StudentCourses { get; set; }
}