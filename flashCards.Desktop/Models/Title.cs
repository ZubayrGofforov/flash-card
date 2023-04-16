using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flashCards.Desktop.Models
{
    public class Title
    {
        public int Id { get; set; }

        public string WordsTitle { get; set; }

        public long UserId { get; set; }

        public string Description { get; set; }
    }
}
