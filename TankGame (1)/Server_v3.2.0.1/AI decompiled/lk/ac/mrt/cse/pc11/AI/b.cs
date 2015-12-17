namespace lk.ac.mrt.cse.pc11.AI
{
    using System;
    using System.Drawing;

    public class b
    {
        private int a;
        private int b;
        private lk.ac.mrt.cse.pc11.AI.b c;

        public unsafe b(Point A_0)
        {
            this.c = null;
            base..ctor();
            this.a = &A_0.X;
            this.b = &A_0.Y;
            return;
        }

        public b(int A_0, int A_1)
        {
            this.c = null;
            base..ctor();
            this.a = A_0;
            this.b = A_1;
            return;
        }

        public b(int A_0, int A_1, lk.ac.mrt.cse.pc11.AI.b A_2)
        {
            this..ctor(A_0, A_1);
            this.c = A_2;
            return;
        }

        public void a()
        {
            Console.Write(this.b());
            return;
        }

        public bool a(lk.ac.mrt.cse.pc11.AI.b A_0)
        {
            bool flag;
            flag = (this.a == A_0.d()) & (this.b == A_0.c());
        Label_0021:
            return flag;
        }

        public void a(int A_0)
        {
            this.b = A_0;
            return;
        }

        public string b()
        {
            string str;
            object[] objArray;
            str = string.Concat(new object[] { "(", (int) this.d(), ",", (int) this.c(), ")" });
        Label_0045:
            return str;
        }

        public int b(lk.ac.mrt.cse.pc11.AI.b A_0)
        {
            int num;
            bool flag;
            if (((A_0.c() < this.b) == 0) != null)
            {
                goto Label_001B;
            }
            num = 1;
            goto Label_006D;
        Label_001B:
            if (((A_0.d() < this.a) == 0) != null)
            {
                goto Label_0035;
            }
            num = 2;
            goto Label_006D;
        Label_0035:
            if (((A_0.b > this.b) == 0) != null)
            {
                goto Label_004F;
            }
            num = 3;
            goto Label_006D;
        Label_004F:
            if (((A_0.d() > this.a) == 0) != null)
            {
                goto Label_0069;
            }
            num = 4;
            goto Label_006D;
        Label_0069:
            num = 0;
        Label_006D:
            return num;
        }

        public void b(int A_0)
        {
            this.a = A_0;
            return;
        }

        public int c()
        {
            int num;
            num = this.b;
        Label_000A:
            return num;
        }

        public int d()
        {
            int num;
            num = this.a;
        Label_000A:
            return num;
        }

        public lk.ac.mrt.cse.pc11.AI.b e()
        {
            lk.ac.mrt.cse.pc11.AI.b b;
            b = this.c;
        Label_000A:
            return b;
        }
    }
}
