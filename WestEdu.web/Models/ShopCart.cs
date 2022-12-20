namespace WestEdu.web.Models;
public class ShopCart{
    public double Finalprice {get;set;}

    public List<Course> CoursesToBuy { get; set; } = new List<Course>();


    public List<Course> GetMyItems(){
        return CoursesToBuy;
    }
}