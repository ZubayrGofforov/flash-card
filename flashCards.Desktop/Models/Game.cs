using System;

namespace flashCards.Desktop.Models
{
    public class Game
    {
        public long Id { get; set; }

        public long UserId { get; set; }

        public long TitleId { get; set; }

        public int CorrectAnswer { get; set; }

        public DateTime PlayedTime { get; set; } = DateTime.Now;
    }
}
