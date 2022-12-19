namespace WestEdu.web.Models;


public class Teacher{
    public long SocialSecurityNumber { get; set; }
    public string FirstName { get; set; } = "";

    public string LastName { get; set; } = "";
    public string profilepic {get;set;} = "";


    public List<Course> myCourses {get;set;} = new List<Course>();

    public List<Course> GetAllCourses(){
        return myCourses;
    }
 
}