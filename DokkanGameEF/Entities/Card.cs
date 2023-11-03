using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DokkanGameEF.Entities
{
    public class Card
    {
        public int CardId { get; set; }

        public string Card_name { get; set; }
        public int Defense { get; set; }
        public int Attack { get; set; }
        public int Life { get; set; }
        public string Type { get; set; }
        public string Side { get; set; }
        public string Card_details { get; set; }
        public string Card_attack_details { get; set; }
        public string Leader_skill { get; set; }

        public List<CardPlayer> Players { get; set; }

    }
}
