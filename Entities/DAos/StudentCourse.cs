namespace Entities.DAos;

public class StudentCourse
{
    public int SCid { get; set; }

    public int Sid { get; set; }
    public virtual Student? StudentNav { get; set; }


    public int Cid { get; set; }
    public virtual Course? CourseNav { get; set; }

    public DateTime DOE { get; set; }
    public string? Term { get; set; }
    public double Marks { get; set; }
}