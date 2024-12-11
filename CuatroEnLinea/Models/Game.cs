using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CuatroEnLinea.Models
{
    public class Game
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        [ForeignKey("Player1")]
        public int Player1Id { get; set; }
        public Player Player1 { get; set; }

        [ForeignKey("Player2")]
        public int Player2Id { get; set; }
        public Player Player2 { get; set; }

        public string Result { get; set; }
    }
}
