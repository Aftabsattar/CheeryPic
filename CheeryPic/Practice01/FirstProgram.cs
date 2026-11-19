namespace CheeryPic.Practice01;

public class FirstProgram
{
    public string Name { get; set; }
    
    public void Input()
    {
        Name = Console.ReadLine()?? "Guest";
        Console.WriteLine(Name);
    }
}
