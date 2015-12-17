namespace lk.ac.mrt.cse.pc11.AI
{
    using lk.ac.mrt.cse.pc11;
    using lk.ac.mrt.cse.pc11.bean;
    using lk.ac.mrt.cse.pc11.util;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Threading;

    public class DummyAI
    {
        private Contestant a;
        private bool[][] b;
        private List<lk.ac.mrt.cse.pc11.AI.d> c;
        private lk.ac.mrt.cse.pc11.AI.a d;
        private AIMain e;
        private CoinPile f;
        private int g;
        private int h;
        private CoinPile i;
        private int j;
        private RandomGen k;

        public DummyAI(Contestant A_0, int A_1)
        {
            this.c = new List<lk.ac.mrt.cse.pc11.AI.d>();
            this.d = new lk.ac.mrt.cse.pc11.AI.a();
            this.e = AIMain.GetInstance();
            this.g = 0x7d0;
            this.h = -1;
            this.k = new RandomGen();
            base..ctor();
            this.a = A_0;
            this.a.Index = A_1;
            this.h = A_1;
            return;
        }

        public lk.ac.mrt.cse.pc11.AI.a a()
        {
            lk.ac.mrt.cse.pc11.AI.a a;
            bool flag;
            if (((this.d == null) == 0) != null)
            {
                goto Label_001A;
            }
            this.b();
        Label_001A:
            a = this.d;
        Label_0023:
            return a;
        }

        public bool a(lk.ac.mrt.cse.pc11.AI.b A_0)
        {
            bool flag;
            flag = this.b[A_0.d()][A_0.c()];
        Label_0018:
            return flag;
        }

        private void a(CoinPile A_0)
        {
            lk.ac.mrt.cse.pc11.AI.d d;
            d = new lk.ac.mrt.cse.pc11.AI.d(A_0, this.a, this.b);
            this.c.Add(d);
            Monitor.Enter(this.c);
            this.c.Sort(new Comparison<lk.ac.mrt.cse.pc11.AI.d>(this.a));
            Monitor.Exit(this.c);
            return;
        }

        public unsafe void a(List<CoinPile> A_0)
        {
            CoinPile pile;
            List<CoinPile>.Enumerator enumerator;
            bool flag;
            this.c = new List<lk.ac.mrt.cse.pc11.AI.d>();
        Label_000C:
            try
            {
                enumerator = A_0.GetEnumerator();
            Label_0015:
                try
                {
                    goto Label_005E;
                Label_0017:
                    pile = &enumerator.Current;
                    if ((Constant.AI_FACTOR > 3) != null)
                    {
                        goto Label_0053;
                    }
                    if ((((this.k.randomD(100) % 3) == 0) == 0) != null)
                    {
                        goto Label_0050;
                    }
                    this.a(pile);
                Label_0050:
                    goto Label_005D;
                Label_0053:
                    this.a(pile);
                Label_005D:;
                Label_005E:
                    if (&enumerator.MoveNext() != null)
                    {
                        goto Label_0017;
                    }
                    goto Label_007A;
                }
                finally
                {
                Label_006B:
                    &enumerator.Dispose();
                }
            Label_007A:
                goto Label_0083;
            }
            catch (Exception)
            {
            Label_007E:
                goto Label_0083;
            }
        Label_0083:
            return;
        }

        internal void a(int A_0)
        {
            this.g = A_0;
            return;
        }

        protected int a(lk.ac.mrt.cse.pc11.AI.d A_0, lk.ac.mrt.cse.pc11.AI.d A_1)
        {
            int num;
            int num2;
            int num3;
            int num4;
            bool flag;
            num = 0;
            num2 = 0;
            if ((A_0 == null) != null)
            {
                goto Label_0018;
            }
            num = A_0.g();
        Label_0018:
            if ((A_1 == null) != null)
            {
                goto Label_002B;
            }
            num2 = A_1.g();
        Label_002B:
            if (((num == num2) == 0) != null)
            {
                goto Label_003D;
            }
            num4 = 0;
            goto Label_005A;
        Label_003D:
            num3 = 0;
            if (((num > num2) == 0) != null)
            {
                goto Label_0052;
            }
            num3 = 1;
            goto Label_0056;
        Label_0052:
            num3 = -1;
        Label_0056:
            num4 = num3;
        Label_005A:
            return num4;
        }

        public void b()
        {
            int num;
            bool flag;
            lk.ac.mrt.cse.pc11.AI.d d;
            bool flag2;
        Label_0001:
            try
            {
                num = 0;
                goto Label_001E;
            Label_0006:
                this.c[num].b();
                num += 1;
            Label_001E:
                if ((num < this.c.Count) != null)
                {
                    goto Label_0006;
                }
                if ((Constant.AI_FACTOR < 7) != null)
                {
                    goto Label_006E;
                }
                Monitor.Enter(this.c);
                this.c.Sort(new Comparison<lk.ac.mrt.cse.pc11.AI.d>(this.a));
                Monitor.Exit(this.c);
            Label_006E:
                flag = 1;
                num = 0;
                goto Label_00A2;
            Label_0074:
                this.d = this.c[num].f();
                flag = 0;
                if ((Constant.AI_FACTOR < 4) != null)
                {
                    goto Label_009D;
                }
                goto Label_00B4;
            Label_009D:
                num += 1;
            Label_00A2:
                if ((num < this.c.Count) != null)
                {
                    goto Label_0074;
                }
            Label_00B4:
                if ((flag == 0) != null)
                {
                    goto Label_00FA;
                }
                if ((Constant.AI_FACTOR < 8) != null)
                {
                    goto Label_00F7;
                }
                d = this.f();
                d.b();
                this.d = d.f();
                this.i = null;
                this.j = 0x3e8;
            Label_00F7:
                goto Label_014B;
            Label_00FA:;
            Label_00FB:
                try
                {
                    this.i = this.b(this.d.b());
                    this.j = this.d.d();
                    goto Label_0149;
                }
                catch (Exception)
                {
                Label_0127:
                    this.j = this.e.MapSize * this.e.MapSize;
                    goto Label_0149;
                }
            Label_0149:;
            Label_014B:
                goto Label_016E;
            }
            catch (Exception)
            {
            Label_014E:
                Console.WriteLine(this.a.Name + " move aborted");
                goto Label_016E;
            }
        Label_016E:
            return;
        }

        protected unsafe CoinPile b(lk.ac.mrt.cse.pc11.AI.b A_0)
        {
            lk.ac.mrt.cse.pc11.AI.d d;
            CoinPile pile;
            List<lk.ac.mrt.cse.pc11.AI.d>.Enumerator enumerator;
            bool flag;
            enumerator = this.c.GetEnumerator();
        Label_000E:
            try
            {
                goto Label_0041;
            Label_0010:
                d = &enumerator.Current;
                if ((new lk.ac.mrt.cse.pc11.AI.b(d.c().Position).a(A_0) == 0) != null)
                {
                    goto Label_0040;
                }
                pile = d.c();
                goto Label_0062;
            Label_0040:;
            Label_0041:
                if (&enumerator.MoveNext() != null)
                {
                    goto Label_0010;
                }
                goto Label_005D;
            }
            finally
            {
            Label_004E:
                &enumerator.Dispose();
            }
        Label_005D:
            pile = null;
        Label_0062:
            return pile;
        }

        public void c()
        {
            lk.ac.mrt.cse.pc11.AI.b b;
            lk.ac.mrt.cse.pc11.AI.b b2;
            bool flag;
            int num;
            if (((Constant.AI_FACTOR < 5) == 0) != null)
            {
                goto Label_001A;
            }
            Thread.Sleep(100);
        Label_001A:
            if ((Constant.AI_FACTOR > 2) != null)
            {
                goto Label_004C;
            }
            if ((((this.k.randomD(100) % 2) == 0) == 0) != null)
            {
                goto Label_0049;
            }
            this.b();
        Label_0049:
            goto Label_0055;
        Label_004C:
            this.b();
        Label_0055:
            if ((this.d == null) != null)
            {
                goto Label_0102;
            }
            b = this.d.e();
            switch (this.d().b(b))
            {
                case 0:
                    goto Label_009D;

                case 1:
                    goto Label_009F;

                case 2:
                    goto Label_00B7;

                case 3:
                    goto Label_00CF;

                case 4:
                    goto Label_00E7;
            }
            goto Label_00FF;
        Label_009D:
            goto Label_0101;
        Label_009F:
            AIMain.GetInstance().a(this.a, "UP#");
            goto Label_0101;
        Label_00B7:
            AIMain.GetInstance().a(this.a, "LEFT#");
            goto Label_0101;
        Label_00CF:
            AIMain.GetInstance().a(this.a, "DOWN#");
            goto Label_0101;
        Label_00E7:
            AIMain.GetInstance().a(this.a, "RIGHT#");
            goto Label_0101;
        Label_00FF:;
        Label_0101:;
        Label_0102:
            return;
        }

        protected unsafe lk.ac.mrt.cse.pc11.AI.d f()
        {
            int num;
            List<lk.ac.mrt.cse.pc11.AI.b> list;
            lk.ac.mrt.cse.pc11.AI.b b;
            lk.ac.mrt.cse.pc11.AI.d d;
            bool flag;
            List<lk.ac.mrt.cse.pc11.AI.b>.Enumerator enumerator;
            this.b = AIMain.GetInstance().PossibleLocations;
            num = (int) this.b.Length;
            list = new List<lk.ac.mrt.cse.pc11.AI.b>();
            list.Add(new lk.ac.mrt.cse.pc11.AI.b(num / 2, num / 2));
            if ((Constant.AI_FACTOR < 6) != null)
            {
                goto Label_0080;
            }
            list.Add(new lk.ac.mrt.cse.pc11.AI.b((num / 2) - 1, num / 2));
            list.Add(new lk.ac.mrt.cse.pc11.AI.b(num / 2, (num / 2) - 1));
            list.Add(new lk.ac.mrt.cse.pc11.AI.b((num / 2) - 1, (num / 2) - 1));
        Label_0080:
            enumerator = list.GetEnumerator();
        Label_0089:
            try
            {
                goto Label_00D7;
            Label_008B:
                b = &enumerator.Current;
                if ((this.a(b) == 0) != null)
                {
                    goto Label_00D6;
                }
                this.f = new CoinPile(b.d(), b.c());
                d = new lk.ac.mrt.cse.pc11.AI.d(this.f, this.a, this.b);
                goto Label_00FA;
            Label_00D6:;
            Label_00D7:
                if (&enumerator.MoveNext() != null)
                {
                    goto Label_008B;
                }
                goto Label_00F5;
            }
            finally
            {
            Label_00E6:
                &enumerator.Dispose();
            }
        Label_00F5:
            d = null;
        Label_00FA:
            return d;
        }

        public bool Alive
        {
            get
            {
                bool flag;
                flag = this.a.IsAlive;
            Label_000F:
                return flag;
            }
        }

        public Contestant Cont
        {
            get
            {
                Contestant contestant;
                contestant = this.a;
            Label_000A:
                return contestant;
            }
        }

        public lk.ac.mrt.cse.pc11.AI.b Pos
        {
            get
            {
                lk.ac.mrt.cse.pc11.AI.b b;
                Point point;
                b = new lk.ac.mrt.cse.pc11.AI.b(&this.a.CurrentP.X, &this.a.CurrentP.Y);
            Label_002F:
                return b;
            }
        }

        public bool[][] Possibility
        {
            set
            {
                this.b = value;
                return;
            }
        }
    }
}
