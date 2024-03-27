namespace GameLibrary
{
    public class Game
    {
        public int Id {  get; set; }
        public string? Name { get; set; }
        public string? Developer { get; set; }
        public string? Genre { get; set; }
        public DateTime Release {  get; set; }
        public bool Multiplayer { get; set; }
        public int Sold { get; set; }
    }
}
