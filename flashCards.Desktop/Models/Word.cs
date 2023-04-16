using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flashCards.Desktop.Models
{
    public class Word
    {
        public int Id { get; set; }

        public string Word_ { get; set; } = String.Empty;

        public string TranslateWord { get; set; } = String.Empty;

        public long TitleId { get; set; } 

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}