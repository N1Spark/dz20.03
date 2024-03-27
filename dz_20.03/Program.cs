using GameLibrary;
using GameContextLibrary;
using System.ComponentModel;
using System.Diagnostics;

namespace CodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new GameContext())
            {
                var query = (from g in db.Games
                             select g).ToList();
                foreach (var item in query)
                {
                    Console.WriteLine("Game: " + item.Name);
                    Console.WriteLine("Developer: " + item.Developer);
                    Console.WriteLine("Genre: " + item.Genre);
                    Console.WriteLine("Release: " + item.Release.ToString().Substring(0,10));
                    Console.WriteLine("Copies Sold: " + item.Sold);
                    if(item.Multiplayer)
                        Console.WriteLine("Mode: Multiplayer");
                    else
                        Console.WriteLine("Mode: Singleplayer");
                    Console.WriteLine();
                }
            }
        }
    }
}