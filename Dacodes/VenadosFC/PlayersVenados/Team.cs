using System;
using System.Collections.Generic;
using System.Text;

namespace Dacodes.VenadosFC
{
    public class Team
    {
        public Forward[] forwards { get; set; }
        public Center[] centers { get; set; }
        public Defens[] defenses { get; set; }
        public Goalkeeper[] goalkeepers { get; set; }
        public Coach[] coaches { get; set; }
    }
}
