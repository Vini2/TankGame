using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTankClient
{
    class LifePack
    {
        public LifePack(int x, int y, int time)
        {
            this.x = x;
            this.y = y;
            this.time = time;
        }

        public int x { get; set; }
        public int y { get; set; }
        public int time { get; set; }
    }
}
