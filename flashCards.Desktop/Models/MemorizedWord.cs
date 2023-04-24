using System;

namespace flashCards.Desktop.Models
{
    public class MemorizedWord
    {
        public long Id { get; set; }

        public long UserId { get; set; }

        public long WordId { get; set; }

        public DateTime MemorizedWordDate { get; set; } = DateTime.Now;
    }
}
