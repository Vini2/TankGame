namespace lk.ac.mrt.cse.pc11.AI
{
    using System;
    using System.Collections.Generic;

    internal class c
    {
        private static bool[][] a;
        private static int b;
        private static AIMain c;
        private List<DummyAI> d;
        private List<lk.ac.mrt.cse.pc11.AI.b> e;
        private List<lk.ac.mrt.cse.pc11.AI.b> f;

        static c()
        {
            c = AIMain.GetInstance();
            return;
        }

        public c()
        {
            this..ctor(c.PossibleLocations, c.Dummys);
            return;
        }

        public c(bool[][] A_0)
        {
            this..ctor(A_0, c.Dummys);
            return;
        }

        public c(bool[][] A_0, List<DummyAI> A_1)
        {
            int num;
            int num2;
            bool flag;
            this.d = new List<DummyAI>();
            this.e = new List<lk.ac.mrt.cse.pc11.AI.b>();
            this.f = new List<lk.ac.mrt.cse.pc11.AI.b>();
            base..ctor();
            b = (int) A_0.Length;
            this.d = A_1;
            a = new bool[b][];
            num = 0;
            goto Label_00A2;
        Label_004B:
            a[num] = new bool[b];
            num2 = 0;
            goto Label_008D;
        Label_0061:
            if ((A_0[num][num2] == 0) != null)
            {
                goto Label_007C;
            }
            a[num][num2] = 1;
            goto Label_0088;
        Label_007C:
            a[num][num2] = 0;
        Label_0088:
            num2 += 1;
        Label_008D:
            if ((num2 < ((int) a[num].Length)) != null)
            {
                goto Label_0061;
            }
            num += 1;
        Label_00A2:
            if ((num < b) != null)
            {
                goto Label_004B;
            }
            return;
        }

        public c(int A_0, lk.ac.mrt.cse.pc11.AI.b[] A_1, lk.ac.mrt.cse.pc11.AI.b[] A_2, List<DummyAI> A_3)
        {
            int num;
            int num2;
            lk.ac.mrt.cse.pc11.AI.b b;
            lk.ac.mrt.cse.pc11.AI.b b2;
            bool flag;
            lk.ac.mrt.cse.pc11.AI.b[] bArray;
            int num3;
            this.d = new List<DummyAI>();
            this.e = new List<lk.ac.mrt.cse.pc11.AI.b>();
            this.f = new List<lk.ac.mrt.cse.pc11.AI.b>();
            base..ctor();
            lk.ac.mrt.cse.pc11.AI.c.b = A_0;
            this.d = A_3;
            a = new bool[lk.ac.mrt.cse.pc11.AI.c.b][];
            num = 0;
            goto Label_0087;
        Label_004A:
            a[num] = new bool[lk.ac.mrt.cse.pc11.AI.c.b];
            num2 = 0;
            goto Label_0070;
        Label_0060:
            a[num][num2] = 1;
            num2 += 1;
        Label_0070:
            if ((num2 < ((int) a[num].Length)) != null)
            {
                goto Label_0060;
            }
            num += 1;
        Label_0087:
            if ((num < lk.ac.mrt.cse.pc11.AI.c.b) != null)
            {
                goto Label_004A;
            }
            bArray = A_1;
            num3 = 0;
            goto Label_00C0;
        Label_009E:
            b = bArray[num3];
            a[b.d()][b.c()] = 0;
            num3 += 1;
        Label_00C0:
            if ((num3 < ((int) bArray.Length)) != null)
            {
                goto Label_009E;
            }
            bArray = A_2;
            num3 = 0;
            goto Label_00F9;
        Label_00D7:
            b2 = bArray[num3];
            a[b2.d()][b2.c()] = 0;
            num3 += 1;
        Label_00F9:
            if ((num3 < ((int) bArray.Length)) != null)
            {
                goto Label_00D7;
            }
            return;
        }

        private lk.ac.mrt.cse.pc11.AI.a a(lk.ac.mrt.cse.pc11.AI.b A_0, lk.ac.mrt.cse.pc11.AI.b A_1)
        {
            lk.ac.mrt.cse.pc11.AI.a a;
            lk.ac.mrt.cse.pc11.AI.b b;
            lk.ac.mrt.cse.pc11.AI.a a2;
            bool flag;
            a = new lk.ac.mrt.cse.pc11.AI.a();
            b = A_1;
            goto Label_002C;
        Label_000B:
            a.b(new lk.ac.mrt.cse.pc11.AI.b(b.d(), b.c()));
            b = b.e();
        Label_002C:
            if ((((b.d() == A_0.d()) == 0) | ((b.c() == A_0.c()) == 0)) != null)
            {
                goto Label_000B;
            }
            a.b(new lk.ac.mrt.cse.pc11.AI.b(A_0.d(), A_0.c()));
            a2 = a;
        Label_006F:
            return a2;
        }

        public lk.ac.mrt.cse.pc11.AI.a a(int A_0, lk.ac.mrt.cse.pc11.AI.b A_1)
        {
            lk.ac.mrt.cse.pc11.AI.a a;
            a = this.a(A_0, this.d[A_0].d(), A_1);
        Label_001D:
            return a;
        }

        private bool a(int A_0, int A_1)
        {
            bool flag;
            bool flag2;
            if ((((A_0 < 0) | (A_1 < 0)) == 0) != null)
            {
                goto Label_0016;
            }
            flag = 0;
            goto Label_003E;
        Label_0016:
            if (((((A_0 < b) == 0) | ((A_1 < b) == 0)) == 0) != null)
            {
                goto Label_0039;
            }
            flag = 0;
            goto Label_003E;
        Label_0039:
            flag = 1;
        Label_003E:
            return flag;
        }

        private bool a(lk.ac.mrt.cse.pc11.AI.b A_0, lk.ac.mrt.cse.pc11.AI.b A_1, bool[][] A_2)
        {
            bool flag;
            bool flag2;
            if ((((A_1.d() == A_0.d()) & (A_1.c() == A_0.c())) == 0) != null)
            {
                goto Label_002D;
            }
            flag = 1;
            goto Label_00FE;
        Label_002D:
            if ((this.a(A_0.d(), A_0.c()) == 0) != null)
            {
                goto Label_00F9;
            }
            if ((A_2[A_0.d()][A_0.c()] == 0) != null)
            {
                goto Label_00F5;
            }
            A_2[A_0.d()][A_0.c()] = 0;
            this.e.Add(new lk.ac.mrt.cse.pc11.AI.b(A_0.d() - 1, A_0.c(), A_0));
            this.e.Add(new lk.ac.mrt.cse.pc11.AI.b(A_0.d() + 1, A_0.c(), A_0));
            this.e.Add(new lk.ac.mrt.cse.pc11.AI.b(A_0.d(), A_0.c() - 1, A_0));
            this.e.Add(new lk.ac.mrt.cse.pc11.AI.b(A_0.d(), A_0.c() + 1, A_0));
        Label_00F5:
            flag = 0;
            goto Label_00FE;
        Label_00F9:
            flag = 0;
        Label_00FE:
            return flag;
        }

        public lk.ac.mrt.cse.pc11.AI.a a(int A_0, lk.ac.mrt.cse.pc11.AI.b A_1, lk.ac.mrt.cse.pc11.AI.b A_2)
        {
            bool[][] flagArray;
            int num;
            int num2;
            lk.ac.mrt.cse.pc11.AI.a a;
            bool flag;
            flagArray = new bool[b][];
            num = 0;
            goto Label_005F;
        Label_0010:
            flagArray[num] = new bool[b];
            num2 = 0;
            goto Label_004C;
        Label_0022:
            if ((lk.ac.mrt.cse.pc11.AI.c.a[num][num2] == 0) != null)
            {
                goto Label_003F;
            }
            flagArray[num][num2] = 1;
            goto Label_0047;
        Label_003F:
            flagArray[num][num2] = 0;
        Label_0047:
            num2 += 1;
        Label_004C:
            if ((num2 < ((int) flagArray[num].Length)) != null)
            {
                goto Label_0022;
            }
            num += 1;
        Label_005F:
            if ((num < b) != null)
            {
                goto Label_0010;
            }
            num = 0;
            goto Label_00B3;
        Label_0071:
            if ((A_0 == num) != null)
            {
                goto Label_00AE;
            }
            flagArray[this.d[num].d().d()][this.d[num].d().c()] = 0;
        Label_00AE:
            num += 1;
        Label_00B3:
            if ((num < this.d.Count) != null)
            {
                goto Label_0071;
            }
            this.e.Add(A_1);
            a = this.b(A_1, A_2, flagArray);
        Label_00E0:
            return a;
        }

        private lk.ac.mrt.cse.pc11.AI.a b(lk.ac.mrt.cse.pc11.AI.b A_0, lk.ac.mrt.cse.pc11.AI.b A_1, bool[][] A_2)
        {
            lk.ac.mrt.cse.pc11.AI.b b;
            bool flag;
            lk.ac.mrt.cse.pc11.AI.a a;
            bool flag2;
            b = this.e[0];
            flag = 0;
            goto Label_004D;
        Label_0012:
            b = this.e[0];
            if (this.a(b, A_1, A_2) != null)
            {
                goto Label_0040;
            }
            this.e.RemoveAt(0);
            goto Label_004C;
        Label_0040:
            a = this.a(A_0, b);
            goto Label_0063;
        Label_004C:;
        Label_004D:
            if ((this.e.Count > 0) != null)
            {
                goto Label_0012;
            }
            a = null;
        Label_0063:
            return a;
        }
    }
}
