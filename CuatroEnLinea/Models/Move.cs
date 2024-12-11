namespace CuatroEnLinea.Models
{
    public class Move
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public int Column { get; set; }
        public int Row { get; set; }
        public string PlayerColor { get; set; }
    }
}