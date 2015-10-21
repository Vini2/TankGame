using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTankClient
{
    class CoinPack
    {
        

        public CoinPack(int x, int y, int time, int value)
        {
            
            this.x = x;
            this.y = y;
            this.time = time;
            this.value = value;
        }
        public int x { get; set; }
        public int y { get; set; }
        public int time { get; set; }
        public int value { get; set; }

    }
}
