namespace CheeryPic.Practice04;

public class FourthProgram
{
    public string Email { get; set; } = string.Empty;
    public void EmailInput() 
    {
        Console.WriteLine("Please enter your email address:");
        var email = Console.ReadLine();
        Console.WriteLine($"You entered: {email}");
    }
}