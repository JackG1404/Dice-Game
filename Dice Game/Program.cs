class DiceGame
{
    static void Main(string[] args)
    {
        // These will store the random dice rolls for the player and enemy
        int playerRoll;
        int enemyRoll;

        // Scores start at 0 for both
        int playerScore = 0;
        int enemyScore = 0;

        // Create a random number generator
        Random rng = new Random();

        // We'll play 10 rounds
        for (int round = 1; round <= 10; round++)
        {
            Console.WriteLine($"Round {round}: Press any key to roll the dice!");
            Console.ReadKey(); // Wait for player input before rolling

            // Player's turn to roll (1 to 6)
            playerRoll = rng.Next(1, 7);
            Console.WriteLine($"\nYou rolled a {playerRoll}");

            // Just a little suspense...
            Console.WriteLine("...");
            Thread.Sleep(1000); // Wait 1 second

            // Enemy's turn to roll
            enemyRoll = rng.Next(1, 7);
            Console.WriteLine($"Enemy rolled a {enemyRoll}");

            // Figure out who won this round
            if (playerRoll > enemyRoll)
            {
                playerScore++;
                Console.WriteLine("Nice! You won this round!");
            }
            else if (playerRoll < enemyRoll)
            {
                enemyScore++;
                Console.WriteLine("Uh oh! Enemy takes this one.");
            }
            else
            {
                Console.WriteLine("It's a tie this round!");
            }

            // Show the current score
            Console.WriteLine($"Scoreboard => You: {playerScore} | Enemy: {enemyScore}");
            Console.WriteLine(); // Blank line for spacing
        }

        // Game over — time for the final result!
        Console.WriteLine("Game Over!");

        if (playerScore > enemyScore)
        {
            Console.WriteLine("🎉 You win the game! Great job!");
        }
        else if (playerScore < enemyScore)
        {
            Console.WriteLine("😞 You lost the game. Better luck next time!");
        }
        else
        {
            Console.WriteLine("🤝 It's a draw! So close!");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey(); // So the window doesn't just vanish immediately
    }
}
