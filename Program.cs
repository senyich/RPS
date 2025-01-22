


using System.Runtime.InteropServices;

internal class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();
        game.StartGame();
    }
}

public class Game
{
    private bool isGameEnded=false;
    private Random randomMove;
    private int userMove;
    private int computerMove;
    private string winner;
    private string[] moves = { "Камень", "Ножницы", "Бумага" };
    private int p1 = 0;
    private int p2 = 0;
    public Game()
    {
        randomMove = new Random();
    }
    public void StartGame()
    {
        while (isGameEnded != true)
        {
            userMove = UserMove();
            computerMove = randomMove.Next(1, 4);
            int winner = CheckWinner(userMove, computerMove);
            switch(winner)
            {
                case 1:
                    Console.WriteLine($"Победил Человек! Он выйграл с {moves[userMove - 1]} над {moves[computerMove-1]}");
                    isGameEnded = true;
                    break;
                case 2:
                    Console.WriteLine($"Победил Компьютер! Он выйграл с {moves[computerMove - 1]} над {moves[userMove - 1]}");
                    isGameEnded = true;
                    break;
                case 0:
                    Console.WriteLine($"Победила ничья, у всех был ход: {moves[computerMove - 1]}");
                    isGameEnded = true;
                    break;
                case -1:
                    Console.WriteLine($"Никто не победил, все обиделись");
                    isGameEnded = true;
                    break;
            }
        }
        OnGameEnded();
    }
    private int CheckWinner(int p1, int p2)
    {
        if (p1 == 1 && p2 == 1) return 0;
        else if (p1 == 1 && p2 == 2) return 1;
        else if (p1 == 1 && p2 == 3) return 2;

        else if (p1 == 2 && p2 == 1) return 2;
        else if (p1 == 2 && p2 == 2) return 0;
        else if (p1 == 2 && p2 == 3) return 1;

        else if (p1 == 3 && p2 == 1) return 1;
        else if (p1 == 3 && p2 == 2) return 2;
        else if (p1 == 3 && p2 == 3) return 0;
        return -1;
    }
    private int UserMove()
    {
        Console.WriteLine("Введите свой ход:\n" +
                "1 - камень\n" +
                "2 - ножницы\n" +
                "3 - бумага");
        int move = int.Parse(Console.ReadLine());
        if (!(new int[3] { 1, 2, 3 }).Contains(move))
        {
            Console.WriteLine("Введите корректный ход!");
            Console.Clear();
            UserMove();
        }
        else
            return move;
        return 0;
    }
    private void OnGameEnded() => Console.WriteLine("Игра окончена");
    private void EndGame() => isGameEnded = true;
}