namespace lk.ac.mrt.cse.pc11.AI
{
    using lk.ac.mrt.cse.pc11;
    using lk.ac.mrt.cse.pc11.bean;
    using lk.ac.mrt.cse.pc11.util;
    using System;
    using System.Collections.Generic;
    using System.Drawing;

    public class AIMain
    {
        private static AIMain a;
        private int b;
        private bool[][] c;
        private List<DummyAI> d;
        private RandomGen e;
        private List<AIMessage> f;
        private List<CoinPile> g;

        static AIMain()
        {
            a = new AIMain();
            return;
        }

        private AIMain()
        {
            this.d = new List<DummyAI>();
            this.e = new RandomGen();
            this.f = new List<AIMessage>();
            this.g = new List<CoinPile>();
            base..ctor();
            return;
        }

        public void a(Contestant A_0, string A_1)
        {
            this.f.Add(new AIMessage(A_0, A_1));
            return;
        }

        public static AIMain GetInstance()
        {
            AIMain main;
            main = a;
        Label_0009:
            return main;
        }

        public unsafe void moveShips()
        {
            DummyAI yai;
            List<DummyAI>.Enumerator enumerator;
            bool flag;
            enumerator = this.d.GetEnumerator();
        Label_000E:
            try
            {
                goto Label_0062;
            Label_0010:
                yai = &enumerator.Current;
                yai.a(this.g);
                if ((Constant.AI_FACTOR > 1) != null)
                {
                    goto Label_0058;
                }
                if ((((this.e.randomD(100) % 5) == 0) == 0) != null)
                {
                    goto Label_0055;
                }
                yai.c();
            Label_0055:
                goto Label_0061;
            Label_0058:
                yai.c();
            Label_0061:;
            Label_0062:
                if (&enumerator.MoveNext() != null)
                {
                    goto Label_0010;
                }
                goto Label_007E;
            }
            finally
            {
            Label_006F:
                &enumerator.Dispose();
            }
        Label_007E:
            return;
        }

        public unsafe void setMap(Point[] pits, Point[] obs)
        {
            int num;
            bool flag;
            num = 0;
            goto Label_002C;
        Label_0005:
            this.c[&(pits[num]).X][&(pits[num]).Y] = 0;
            num += 1;
        Label_002C:
            if ((num < ((int) pits.Length)) != null)
            {
                goto Label_0005;
            }
            num = 0;
            goto Label_0061;
        Label_003A:
            this.c[&(obs[num]).X][&(obs[num]).Y] = 0;
            num += 1;
        Label_0061:
            if ((num < ((int) obs.Length)) != null)
            {
                goto Label_003A;
            }
            return;
        }

        public void setMapSize(int gridSize)
        {
            int num;
            int num2;
            bool flag;
            this.b = gridSize;
            this.c = new bool[this.b][];
            num = 0;
            goto Label_0058;
        Label_001D:
            this.c[num] = new bool[this.b];
            num2 = 0;
            goto Label_0046;
        Label_0035:
            this.c[num][num2] = 1;
            num2 += 1;
        Label_0046:
            if ((num2 < this.b) != null)
            {
                goto Label_0035;
            }
            num += 1;
        Label_0058:
            if ((num < this.b) != null)
            {
                goto Label_001D;
            }
            return;
        }

        public List<CoinPile> AvailableCoinPileList
        {
            set
            {
                this.g = value;
                return;
            }
        }

        public List<DummyAI> Dummys
        {
            get
            {
                List<DummyAI> list;
                list = this.d;
            Label_000A:
                return list;
            }
            set
            {
                this.d = value;
                return;
            }
        }

        public int MapSize
        {
            get
            {
                int num;
                num = this.b;
            Label_000A:
                return num;
            }
        }

        public List<AIMessage> NextAIupdates
        {
            get
            {
                List<AIMessage> list;
                List<AIMessage> list2;
                list = new List<AIMessage>();
                list.AddRange(this.f);
                this.f = new List<AIMessage>();
                list2 = list;
            Label_0023:
                return list2;
            }
        }

        public bool[][] PossibleLocations
        {
            get
            {
                bool[][] flagArray;
                flagArray = this.c;
            Label_000A:
                return flagArray;
            }
        }
    }
}
