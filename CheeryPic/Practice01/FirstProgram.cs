namespace CheeryPic.Practice01;

public class FirstProgram
{
    public string Name { get; set; } = string.Empty;

    public void Input()
    {
        Console.WriteLine("Enter your name:");
        Name = Console.ReadLine()?? "Guest";
        Console.WriteLine(Name);
    }
}
