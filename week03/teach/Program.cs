Console.WriteLine("\n======================\nUnique Letters\n======================");
UniqueLetters.Run();

Console.WriteLine("\n======================\nDisplay Sums\n======================");
DisplaySums.Run();

Console.WriteLine("\n======================\nBasketball\n======================");
Basketball.Run();

// Uncomment and run as you get to the solution part
// Console.WriteLine("\n======================\nUnique Letters\n======================");
// UniqueLettersSolution.Run();

// Console.WriteLine("\n======================\nDisplay Sums\n======================");
// DisplaySumsSolution.Run();

// Console.WriteLine("\n======================\nBasketball\n======================");
// BasketballSolution.Run();
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a simple maze map
        var mazeMap = new Dictionary<(int, int), bool[]>
        {
            { (1,1), new bool[] { false, true, false, true } }, // can go right, down
            { (2,1), new bool[] { true, false, false, true } }, // can go left, down
            { (1,2), new bool[] { false, true, true, false } }, // can go right, up
            { (2,2), new bool[] { true, false, true, false } }  // can go left, up
        };

        var maze = new Maze(mazeMap);

        // Show starting position
        Console.WriteLine(maze.GetStatus());

        // Move around
        maze.MoveRight();
        Console.WriteLine(maze.GetStatus());

        maze.MoveDown();
        Console.WriteLine(maze.GetStatus());

        maze.MoveLeft();
        Console.WriteLine(maze.GetStatus());

        // Try invalid move (will crash)
        maze.MoveDown(); // this should throw error
    }
}