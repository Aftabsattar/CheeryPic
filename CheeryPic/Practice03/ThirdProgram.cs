namespace CheeryPic.Practice03;

public class ThirdProgram
{
    public  int CNIC { get; set; }
    public void Input()
    {
        Console.WriteLine("Enter your CNIC:");
        CNIC = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(CNIC);
    }
}