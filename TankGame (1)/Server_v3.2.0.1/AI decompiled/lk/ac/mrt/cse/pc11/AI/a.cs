namespace lk.ac.mrt.cse.pc11.AI
{
    using System;
    using System.Collections.Generic;

    public class a
    {
        private List<lk.ac.mrt.cse.pc11.AI.b> a;
        private int b;

        public a()
        {
            this.a = new List<lk.ac.mrt.cse.pc11.AI.b>();
            base..ctor();
            return;
        }

        public a(List<lk.ac.mrt.cse.pc11.AI.b> A_0)
        {
            this.a = new List<lk.ac.mrt.cse.pc11.AI.b>();
            base..ctor();
            this.a = A_0;
            this.a();
            return;
        }

        private void a()
        {
            this.b = this.a.Count;
            return;
        }

        public void a(lk.ac.mrt.cse.pc11.AI.b A_0)
        {
            this.a.Add(A_0);
            this.a();
            return;
        }

        public void a(int A_0)
        {
            this.a.RemoveAt(A_0);
            this.a();
            return;
        }

        public void a(lk.ac.mrt.cse.pc11.AI.b A_0, int A_1)
        {
            List<lk.ac.mrt.cse.pc11.AI.b> list;
            int num;
            bool flag;
            list = new List<lk.ac.mrt.cse.pc11.AI.b>();
            num = 0;
            goto Label_0024;
        Label_000B:
            list.Add(this.a[num]);
            num += 1;
        Label_0024:
            if ((num < A_1) != null)
            {
                goto Label_000B;
            }
            list.Add(A_0);
            num = A_1;
            goto Label_0051;
        Label_0038:
            list.Add(this.a[num]);
            num += 1;
        Label_0051:
            if ((num < this.a.Count) != null)
            {
                goto Label_0038;
            }
            this.a = list;
            this.a();
            return;
        }

        public lk.ac.mrt.cse.pc11.AI.b b()
        {
            lk.ac.mrt.cse.pc11.AI.b b;
            b = this.a[this.a.Count - 1];
        Label_001C:
            return b;
        }

        public void b(lk.ac.mrt.cse.pc11.AI.b A_0)
        {
            this.a(A_0, 0);
            return;
        }

        public lk.ac.mrt.cse.pc11.AI.b b(int A_0)
        {
            lk.ac.mrt.cse.pc11.AI.b b;
        Label_0001:
            try
            {
                b = this.a[A_0];
                goto Label_001D;
            }
            catch (Exception)
            {
            Label_0011:
                b = new lk.ac.mrt.cse.pc11.AI.b(0, 0);
                goto Label_001D;
            }
        Label_001D:
            return b;
        }

        public lk.ac.mrt.cse.pc11.AI.b c()
        {
            lk.ac.mrt.cse.pc11.AI.b b;
            b = this.a[this.a.Count - 2];
        Label_001C:
            return b;
        }

        public int d()
        {
            int num;
            this.a();
            num = this.b;
        Label_0011:
            return num;
        }

        public lk.ac.mrt.cse.pc11.AI.b e()
        {
            lk.ac.mrt.cse.pc11.AI.b b;
            bool flag;
            if ((this.a.Count < 2) != null)
            {
                goto Label_001E;
            }
            b = this.b(1);
            goto Label_0029;
        Label_001E:
            b = this.b(0);
        Label_0029:
            return b;
        }

        public unsafe void f()
        {
            lk.ac.mrt.cse.pc11.AI.b b;
            List<lk.ac.mrt.cse.pc11.AI.b>.Enumerator enumerator;
            object[] objArray;
            bool flag;
            enumerator = this.a.GetEnumerator();
        Label_000E:
            try
            {
                goto Label_0059;
            Label_0010:
                b = &enumerator.Current;
                Console.Write(string.Concat(new object[] { (int) b.d(), ",", (int) b.c(), ";" }));
            Label_0059:
                if (&enumerator.MoveNext() != null)
                {
                    goto Label_0010;
                }
                goto Label_0075;
            }
            finally
            {
            Label_0066:
                &enumerator.Dispose();
            }
        Label_0075:
            Console.Write("\n");
            return;
        }
    }
}
