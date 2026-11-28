



using Game_Library___Player_Stats_Manager.Models;

List<Player> players = new List<Player>();

// Add players
players.Add(new Player("P001", "Nitesh"));
players.Add(new Player("P002", "Bikram"));
players.Add(new Player("P003", "Ram"));
players.Add(new Player("P004", "Rahul"));
players.Add(new Player("P005", "Biki"));

Console.WriteLine("===== Game Library Players =====");

// Display all players
foreach (Player player in players)
{
    Console.WriteLine("Player ID: " + player.playerId);
    Console.WriteLine("Username: " + player.username);

    Console.WriteLine();
}
