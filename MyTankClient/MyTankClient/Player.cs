using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTankClient
{
    class Player
    {
        public int x { get; set; }
        public int y { get; set; }
        public string name { get; set; }
        public int direction { get; set; }
        public string whether_shot { get; set; }
        public string health { get; set; }
        public int  coins { get; set; }
        public int points { get; set; }
        public int damage { get; set; }

        public Player(string name, int x, int y, int direction)
        {
            this.name = name;
            this.x = x;
            this.y = y;
            this.direction = direction;
        }

        public Player(string name)
        {
            this.name = name;
        }
    }
}
