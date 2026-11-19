namespace CheeryPic.Practice02;

public class SecondProgram
{
    public int Age { get; set; }
    
    public void Input()
    {
        Console.WriteLine("Enter your age:");
        Age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Age);
    }   
}


