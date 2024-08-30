using Console = System.Console;
    
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        //Instructions:
        // x Create a list of video game names...
        // Order the list of games by length of the game name.
        // Use the lambda expression in this exercise as well.
        // Use Method Syntax for this exercise

        //Here is my list of video game names: 
        var videoGames = new List<string>()
        {
            "Fallout", "Red Dead Redemption", "Powerwashing Simulator", "Fortnite", "Baldur's Gate 3", "Unpacking",
            "Halo", "God of War", "The Sims", "Untitled Goose Game"
        };
        
        //Sorting the list:
        var sortedVideoGames = videoGames.OrderBy(game => game.Length).ToList();
        
        //Displaying the results: 
        Console.WriteLine("Here is the list of games sorted in ascending order by length:");
        foreach (var game in sortedVideoGames)
        {
            Console.WriteLine(game);
        }
}
}

