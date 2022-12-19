namespace WestEdu.web.Models;

public class Course{
    public Guid CourseId { get; set; } = Guid.NewGuid();
    public string CourseName { get; set; } = "";

    public int CourseNumber {get;set;}


    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

}