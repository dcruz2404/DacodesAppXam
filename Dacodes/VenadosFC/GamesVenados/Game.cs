using System;
using System.Collections.Generic;
using System.Text;

namespace Dacodes.VenadosFC
{
    public class Game
    {
        public bool local { get; set; }
        public string opponent { get; set; }
        public string opponent_image { get; set; }
        public DateTime datetime { get; set; }
        public string league { get; set; }
        public string image { get; set; }
        public int home_score { get; set; }
        public int away_score { get; set; }
    }
}
