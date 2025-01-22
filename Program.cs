


internal class Program
{
    static void Main(string[] args)
    {
        
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
    private void StartGame()
    {
        while (isGameEnded != true)
        {
            userMove = UserMove();
        }
    }
    private int UserMove()
    {
        Console.WriteLine("Введите свой ход:\n" +
                "1 - камень\n" +
                "2 - ножницы\n" +
                "3 - бумага");
        int move = int.Parse(Console.ReadLine());
        if (!new int[] { 1, 2, 3 }.Contains(move))
        {
            Console.WriteLine("Введите корректный ход!");
            UserMove();
        }
        else
            return move;
        return 0;
    }
    private void OnGameEnded(string winner) => Console.WriteLine("Игра окончена");
    private void EndGame() => isGameEnded = true;
}