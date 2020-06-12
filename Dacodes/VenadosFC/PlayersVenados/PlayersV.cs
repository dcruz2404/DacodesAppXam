using System;
using System.Collections.Generic;
using System.Text;

namespace Dacodes.VenadosFC
{
    public class PlayersV
    {
        public Result result { get; set; }

        public class Result
        {
            public bool success { get; set; }
            public Data data { get; set; }
        }

        public class Data
        {
            public Team team { get; set; }
            public int code { get; set; }
        }
    }
}
