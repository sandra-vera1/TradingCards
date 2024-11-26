﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3TradingCards
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public IEnumerable<Player> Players { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
