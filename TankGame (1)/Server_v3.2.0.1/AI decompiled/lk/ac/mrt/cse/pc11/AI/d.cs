namespace lk.ac.mrt.cse.pc11.AI
{
    using lk.ac.mrt.cse.pc11.bean;
    using System;
    using System.Collections.Generic;

    public class d
    {
        private CoinPile a;
        private Contestant b;
        private bool[][] c;
        private lk.ac.mrt.cse.pc11.AI.a d;
        private int e;
        private bool f;
        private lk.ac.mrt.cse.pc11.AI.c g;

        public d(CoinPile A_0, Contestant A_1, bool[][] A_2)
        {
            this.f = 0;
            base..ctor();
            this.a = A_0;
            this.b = A_1;
            this.c = A_2;
            this.b();
            return;
        }

        public bool[][] a()
        {
            bool[][] flagArray;
            flagArray = this.c;
        Label_000A:
            return flagArray;
        }

        internal void a(lk.ac.mrt.cse.pc11.AI.a A_0)
        {
            this.d = A_0;
        Label_0008:
            try
            {
                this.e = this.d.d();
                goto Label_002A;
            }
            catch (Exception)
            {
            Label_001D:
                this.e = 100;
                goto Label_002A;
            }
        Label_002A:
            return;
        }

        public lk.ac.mrt.cse.pc11.AI.a a(CoinPile A_0)
        {
            lk.ac.mrt.cse.pc11.AI.a a;
            lk.ac.mrt.cse.pc11.AI.a a2;
            this.g = new lk.ac.mrt.cse.pc11.AI.c();
            a2 = this.g.a(this.a(this.h().Index), new lk.ac.mrt.cse.pc11.AI.b(this.c().Position), new lk.ac.mrt.cse.pc11.AI.b(A_0.Position));
        Label_0048:
            return a2;
        }

        private int a(int A_0)
        {
            List<DummyAI> list;
            int num;
            int num2;
            bool flag;
            list = AIMain.GetInstance().Dummys;
            num = 0;
            goto Label_0036;
        Label_0010:
            if (((list[num].e().Index == A_0) == 0) != null)
            {
                goto Label_0031;
            }
            num2 = num;
            goto Label_0047;
        Label_0031:
            num += 1;
        Label_0036:
            if ((num < list.Count) != null)
            {
                goto Label_0010;
            }
            num2 = -1;
        Label_0047:
            return num2;
        }

        public void a(bool[][] A_0)
        {
            this.c = A_0;
            return;
        }

        public lk.ac.mrt.cse.pc11.AI.a b()
        {
            lk.ac.mrt.cse.pc11.AI.a a;
            this.g = new lk.ac.mrt.cse.pc11.AI.c(this.c);
            this.d = this.g.a(this.a(this.h().Index), new lk.ac.mrt.cse.pc11.AI.b(this.c().Position));
        Label_0044:
            try
            {
                this.e = this.d.d();
                goto Label_0066;
            }
            catch (Exception)
            {
            Label_0059:
                this.e = 100;
                goto Label_0066;
            }
        Label_0066:
            a = this.d;
        Label_0070:
            return a;
        }

        internal CoinPile c()
        {
            CoinPile pile;
            pile = this.a;
        Label_000A:
            return pile;
        }

        public bool d()
        {
            bool flag;
            flag = this.f;
        Label_000A:
            return flag;
        }

        public lk.ac.mrt.cse.pc11.AI.b e()
        {
            lk.ac.mrt.cse.pc11.AI.b b;
            b = new lk.ac.mrt.cse.pc11.AI.b(this.a.Position);
        Label_0014:
            return b;
        }

        internal lk.ac.mrt.cse.pc11.AI.a f()
        {
            lk.ac.mrt.cse.pc11.AI.a a;
            a = this.d;
        Label_000A:
            return a;
        }

        public int g()
        {
            int num;
            num = this.e;
        Label_000A:
            return num;
        }

        internal Contestant h()
        {
            Contestant contestant;
            contestant = this.b;
        Label_000A:
            return contestant;
        }

        public int i()
        {
            int num;
            num = this.a.DisappearTime;
        Label_000F:
            return num;
        }

        public int j()
        {
            int num;
            num = this.a.Price;
        Label_000F:
            return num;
        }
    }
}
