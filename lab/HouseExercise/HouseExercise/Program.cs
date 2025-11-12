public class House
{
    public int YearBuilt {  get; set; }
    public double Size { get; set; }
     
    public House (int YearBuilt, double Size)
    {   this.YearBuilt = YearBuilt; 
        this.Size = Size;
    }
    public int HowOld()
    { 
        int currentYear = DateTime.Now.Year;
        int x = currentYear - YearBuilt;
        return x;
    }
    public bool CanBeSold()
    {
        int age = HowOld();
        return age > 15;.
    }
}
public class Program
{
    public static void Main ()
    {

    }
}