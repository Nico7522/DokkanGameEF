using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DokkanGameEF.Entities
{
    public class CardPlayer
    {
        public int CardId { get; set; }
        public Card Card { get; set; }
        public int PlayerId { get; set; }
        public Player Player { get; set; }
        public int Number { get; set; }

    }
}
