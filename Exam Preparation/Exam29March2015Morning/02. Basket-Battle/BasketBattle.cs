/* Problem 2 – Basket Battle
Simeon likes to play a special basket game with Nakov called Basket Battle. The rules are very simple. 
 * Every player tries to score a basket from a different distance and if he succeeds, 
 * he wins a certain amount of points (based on the distance he shot from). 
 * You will receive the distance from which every player tries to score and the information whether the shot was successful or not. 
The players decide who will start shooting first .The game is played in several rounds. Each round consists of the two players shooting. 
 * After each round, the players switch turns (if Simeon was first in the first round, he is shooting second in the second round). 
 * A player wins if he reaches 500 points. If someone reaches 500 points, the game stops and your program should break and print the output. 
A player can’t make more than 500 points in the game. For example if a player has 450 points and he scores successfully 90 points, 
 * the player stays with 450 points after that round. You must help Simeon and Nakov calculate their points and determine 
 * the winner with a computer program. Example:
Simeon <- The player who starts shooting first.
3 <- The number of possible rounds.
300 <- Simeon tries to score 300 points.
success <- Simeon succeeds and scores.
200 <- Nakov tries to score 200 points.
fail <- Nakov fails and still has 0 points.
400 <- Nakov tries to score 400 points. (New round starts and players switch turns)
success <- Nakov succeeds and scores.
200 <- Simeon tries to score 200 points.
success <- Simeon succeeds and scores.

The game has ended since Simeon has scored a total of 500 points and wins the game.
Input
The input data should be read from the console. It consists of three input values, each at a separate line:
•	The first line holds a string F – the name of the player that starts shooting first in the first round 
•	The second line holds an integer N – the number of rounds in the game
•	For each round you will receive an input P - the amount of points every player tries to score and the string I - information about whether the shot was successful or not (each input will be on a separate line). 
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data should be printed on the console. You have 3 cases:
1.	If there is a winner (someone reaches 500 points), your output should consist of three lines:
•	On the first line you should print the name of the winner.
•	On the second line you should print in which round the player won the game.
•	On the third line you should print the points of the player who lost the game
2.	If no one won the game and the players have the same score, you should print out two lines:
•	On the first line you should print the text: "DRAW"
•	On the second line you should print the points that the players have.

3.	 If no one wins the game and the players have different amount of points your output should consist of two lines:
•	On the first line you should print the name of the player with more points.
•	On the second line you should print the difference between the points of the players.
Constraints
•	F will be a string, either "Simeon" or "Nakov".
•	N will be an integer number in the range [1...20].
•	P will be integer in the range [1…500].
•	I will be a string, either "success" or "fail".
 */

using System;

class BasketBattle
{
    static void Main()
    {
        string F = Console.ReadLine();
        int N = int.Parse(Console.ReadLine());

        int NakovScore = 0;
        int SimeonScore = 0;
        for (int i = 0; i < N; i++)
        {
            int P1 = int.Parse(Console.ReadLine());
            string I1 = Console.ReadLine();

            switch (F)
            {
                case "Nakov":
                    {
                        NakovScore = Score(NakovScore, P1, I1);
                        if (NakovScore == 500 && SimeonScore != NakovScore)
                        {
                            NakovWins(SimeonScore, i);
                            return;
                        }
                        break;
                    }
                case "Simeon":
                    {
                        SimeonScore = Score(SimeonScore, P1, I1);
                        if (SimeonScore == 500 && SimeonScore != NakovScore)
                        {
                            SimeonWins(NakovScore, i);
                            return;
                        }
                        break;
                    }
            }

            int P2 = int.Parse(Console.ReadLine());
            string I2 = Console.ReadLine();

            switch (F)
            {
                case "Simeon":
                    {
                        NakovScore = Score(NakovScore, P2, I2);
                        if (NakovScore == 500 && SimeonScore != NakovScore)
                        {
                            NakovWins(SimeonScore, i);
                            return;
                        }
                        F = "Nakov";
                        break;
                    }
                case "Nakov":
                    {
                        SimeonScore = Score(SimeonScore, P2, I2);
                        if (SimeonScore == 500 && SimeonScore != NakovScore)
                        {
                            SimeonWins(NakovScore, i);
                            return;
                        }
                        F = "Simeon";
                        break;
                    }
            }
        }

        if (SimeonScore == NakovScore)
        {
            Console.WriteLine("DRAW");
            Console.WriteLine(NakovScore);
        }
        else
        {
            if (NakovScore > SimeonScore)
            {
                Console.WriteLine("Nakov");
            }
            else
            {
                Console.WriteLine("Simeon");
            }

            Console.WriteLine(Math.Abs(NakovScore - SimeonScore));
        }
    }

    private static void SimeonWins(int NakovScore, int i)
    {
        Console.WriteLine("Simeon");
        Console.WriteLine(i + 1);
        Console.WriteLine(NakovScore);
    }

    private static void NakovWins(int SimeonScore, int i)
    {
        Console.WriteLine("Nakov");
        Console.WriteLine(i + 1);
        Console.WriteLine(SimeonScore);
    }

    private static int Score(int Score, int P, string I)
    {
        if (I == "success")
        {
            int temp = Score;
            temp += P;
            if (temp <= 500)
            {
                Score = temp;
            }
        }
        return Score;
    }
}

