namespace GUI
{
    using GUI.Properties;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    public class GUINormal : Form, GUII
    {
        private Label[,] a;
        private GroupBox a0;
        private RadioButton a1;
        private RadioButton a2;
        private Label a3;
        private CheckBox a4;
        private RadioButton a5;
        private GroupBox a6;
        private CheckBox a7;
        private Button a8;
        private GroupBox a9;
        private Label aa;
        private Timer ab;
        private Label ac;
        private Label ad;
        private Label ae;
        private Label af;
        private Label ag;
        private Label ah;
        private Label ai;
        private Label aj;
        private Label ak;
        private Label al;
        private Label am;
        private Label an;
        private Label ao;
        private RadioButton ap;
        private Label aq;
        private RadioButton ar;
        private CheckBox @as;
        private Label at;
        private GroupBox au;
        private RadioButton av;
        private RadioButton aw;
        private Label ax;
        private CheckBox ay;
        private RadioButton az;
        private int b;
        private CheckBox ba;
        private List<Image[]> c;
        private bool[] d;
        private RadioButton[] e;
        private List<int> f;
        private List<int> g;
        private List<int[]> h;
        private int i;
        private List<int> j;
        private List<int> k;
        private List<int> l;
        private Point[] m;
        private Point[] n;
        private IContainer o;
        private Button p;
        private Label q;
        private Label r;
        private Label s;
        private Label t;
        private Label u;
        private Label v;
        private Label w;
        private Label x;
        private Label y;
        private Label z;

        public GUINormal()
        {
            Image[] imageArray;
            this.b = 10;
            this.c = new List<Image[]>();
            this.d = null;
            this.e = new RadioButton[4];
            this.f = new List<int>();
            this.g = new List<int>();
            this.h = new List<int[]>();
            this.i = 0;
            this.j = new List<int>();
            this.k = new List<int>();
            this.l = new List<int>();
            this.o = null;
            base..ctor();
            this.a();
            this.c.Add(new Image[] { Resources.tank_up, Resources.tank_right, Resources.tank_down, Resources.tank_left });
            this.c.Add(new Image[] { Resources.tank_up_1, Resources.tank_right_1, Resources.tank_down_1, Resources.tank_left_1 });
            this.c.Add(new Image[] { Resources.tank_up_2, Resources.tank_right_2, Resources.tank_down_2, Resources.tank_left_2 });
            this.c.Add(new Image[] { Resources.tank_up_3, Resources.tank_right_3, Resources.tank_down_3, Resources.tank_left_3 });
            this.c.Add(new Image[] { Resources.tank_up_4, Resources.tank_right_4, Resources.tank_down_4, Resources.tank_left_4 });
            this.e[0] = this.a2;
            this.e[1] = this.ar;
            this.e[2] = this.az;
            this.e[3] = this.aw;
            return;
        }

        public void a()
        {
            this.o = new Container();
            this.p = new Button();
            this.q = new Label();
            this.r = new Label();
            this.s = new Label();
            this.t = new Label();
            this.u = new Label();
            this.v = new Label();
            this.w = new Label();
            this.x = new Label();
            this.y = new Label();
            this.z = new Label();
            this.aa = new Label();
            this.ab = new Timer(this.o);
            this.ac = new Label();
            this.ad = new Label();
            this.ae = new Label();
            this.af = new Label();
            this.ag = new Label();
            this.ah = new Label();
            this.ai = new Label();
            this.aj = new Label();
            this.ak = new Label();
            this.al = new Label();
            this.am = new Label();
            this.an = new Label();
            this.ao = new Label();
            this.ap = new RadioButton();
            this.aq = new Label();
            this.ar = new RadioButton();
            this.@as = new CheckBox();
            this.at = new Label();
            this.au = new GroupBox();
            this.av = new RadioButton();
            this.aw = new RadioButton();
            this.ax = new Label();
            this.ay = new CheckBox();
            this.az = new RadioButton();
            this.a0 = new GroupBox();
            this.a1 = new RadioButton();
            this.a2 = new RadioButton();
            this.a3 = new Label();
            this.a4 = new CheckBox();
            this.a5 = new RadioButton();
            this.a6 = new GroupBox();
            this.a7 = new CheckBox();
            this.a8 = new Button();
            this.a9 = new GroupBox();
            this.ba = new CheckBox();
            this.au.SuspendLayout();
            this.a0.SuspendLayout();
            this.a6.SuspendLayout();
            this.a9.SuspendLayout();
            base.SuspendLayout();
            this.p.BackColor = Color.FromArgb(0xc0, 0xc0, 0);
            this.p.Font = new Font("Microsoft Sans Serif", 14.25f, 1, 3, 0);
            this.p.ImageAlign = 0x10;
            this.p.Location = new Point(0x3a3, 0x2b0);
            this.p.Name = "exit";
            this.p.Size = new Size(0x4b, 0x20);
            this.p.TabIndex = 11;
            this.p.TabStop = 0;
            this.p.Text = "Exit";
            this.p.TextAlign = 0x40;
            this.p.TextImageRelation = 4;
            this.p.UseVisualStyleBackColor = 0;
            this.p.Click += new EventHandler(this.i);
            this.q.BackColor = SystemColors.ControlText;
            this.q.BorderStyle = 2;
            this.q.Font = new Font("Microsoft Sans Serif", 9.75f, 1, 3, 0);
            this.q.ForeColor = Color.Gold;
            this.q.Location = new Point(0x2d4, 0xeb);
            this.q.Name = "labelScore0";
            this.q.Size = new Size(0x52, 0x1d);
            this.q.TabIndex = 10;
            this.q.Text = "0000 $";
            this.q.TextAlign = 0x20;
            this.r.BackColor = SystemColors.ControlText;
            this.r.BorderStyle = 2;
            this.r.Font = new Font("Microsoft Sans Serif", 9.75f, 1, 3, 0);
            this.r.ForeColor = Color.Gold;
            this.r.Location = new Point(0x2d4, 0x108);
            this.r.Name = "labelScore1";
            this.r.Size = new Size(0x52, 0x1d);
            this.r.TabIndex = 9;
            this.r.Text = "0000 $";
            this.r.TextAlign = 0x20;
            this.s.BackColor = SystemColors.ControlText;
            this.s.BorderStyle = 2;
            this.s.Font = new Font("Microsoft Sans Serif", 9.75f, 1, 3, 0);
            this.s.ForeColor = Color.Gold;
            this.s.Location = new Point(0x2d4, 0x142);
            this.s.Name = "labelScore3";
            this.s.Size = new Size(0x52, 0x1d);
            this.s.TabIndex = 8;
            this.s.Text = "0000 $";
            this.s.TextAlign = 0x20;
            this.t.BackColor = SystemColors.ControlText;
            this.t.BorderStyle = 2;
            this.t.Font = new Font("Microsoft Sans Serif", 9.75f, 1, 3, 0);
            this.t.ForeColor = Color.Gold;
            this.t.Location = new Point(0x2d4, 0x125);
            this.t.Name = "labelScore2";
            this.t.Size = new Size(0x52, 0x1d);
            this.t.TabIndex = 7;
            this.t.Text = "0000 $";
            this.t.TextAlign = 0x20;
            this.u.BackColor = SystemColors.ControlText;
            this.u.BorderStyle = 2;
            this.u.Font = new Font("Microsoft Sans Serif", 9.75f, 1, 3, 0);
            this.u.ForeColor = Color.Gold;
            this.u.Location = new Point(0x2d4, 0x15f);
            this.u.Name = "labelScore4";
            this.u.Size = new Size(0x52, 0x1d);
            this.u.TabIndex = 6;
            this.u.Text = "0000 $";
            this.u.TextAlign = 0x20;
            this.v.BackColor = SystemColors.ControlText;
            this.v.BorderStyle = 2;
            this.v.Font = new Font("Microsoft Sans Serif", 9.75f, 1, 3, 0);
            this.v.ForeColor = Color.Gold;
            this.v.Location = new Point(640, 0xeb);
            this.v.Name = "label6";
            this.v.Size = new Size(0x56, 0x1d);
            this.v.TabIndex = 5;
            this.v.Text = "P0";
            this.v.TextAlign = 0x20;
            this.w.BackColor = SystemColors.ControlText;
            this.w.BorderStyle = 2;
            this.w.Font = new Font("Microsoft Sans Serif", 9.75f, 1, 3, 0);
            this.w.ForeColor = Color.Gold;
            this.w.Location = new Point(640, 0x109);
            this.w.Name = "label7";
            this.w.Size = new Size(0x56, 0x1d);
            this.w.TabIndex = 4;
            this.w.Text = "P1";
            this.w.TextAlign = 0x20;
            this.x.BackColor = SystemColors.ControlText;
            this.x.BorderStyle = 2;
            this.x.Font = new Font("Microsoft Sans Serif", 9.75f, 1, 3, 0);
            this.x.ForeColor = Color.Gold;
            this.x.Location = new Point(640, 0x126);
            this.x.Name = "label8";
            this.x.Size = new Size(0x56, 0x1d);
            this.x.TabIndex = 3;
            this.x.Text = "P2";
            this.x.TextAlign = 0x20;
            this.y.BackColor = SystemColors.ControlText;
            this.y.BorderStyle = 2;
            this.y.Font = new Font("Microsoft Sans Serif", 9.75f, 1, 3, 0);
            this.y.ForeColor = Color.Gold;
            this.y.Location = new Point(640, 0x143);
            this.y.Name = "label9";
            this.y.Size = new Size(0x56, 0x1d);
            this.y.TabIndex = 2;
            this.y.Text = "P3";
            this.y.TextAlign = 0x20;
            this.z.BackColor = SystemColors.ControlText;
            this.z.BorderStyle = 2;
            this.z.Font = new Font("Microsoft Sans Serif", 9.75f, 1, 3, 0);
            this.z.ForeColor = Color.Gold;
            this.z.Location = new Point(640, 0x160);
            this.z.Name = "label10";
            this.z.Size = new Size(0x56, 0x1d);
            this.z.TabIndex = 1;
            this.z.Text = "P4";
            this.z.TextAlign = 0x20;
            this.aa.BackColor = Color.Black;
            this.aa.Font = new Font("Microsoft Sans Serif", 14.25f, 1, 3, 0);
            this.aa.ForeColor = Color.Gold;
            this.aa.Location = new Point(0x27c, 0x6c);
            this.aa.Name = "labeltime";
            this.aa.Size = new Size(0x13f, 0x53);
            this.aa.TabIndex = 0;
            this.aa.TextAlign = 0x20;
            this.ab.Interval = 250;
            this.ab.Tick += new EventHandler(this.g);
            this.ac.BackColor = SystemColors.ControlText;
            this.ac.BorderStyle = 2;
            this.ac.Font = new Font("Microsoft Sans Serif", 9.75f, 1, 3, 0);
            this.ac.ForeColor = Color.Gold;
            this.ac.Location = new Point(0x37b, 0xe9);
            this.ac.Name = "labelHealth1";
            this.ac.Size = new Size(0x40, 0x1d);
            this.ac.TabIndex = 12;
            this.ac.Text = "0%";
            this.ac.TextAlign = 0x20;
            this.ad.BackColor = SystemColors.ControlText;
            this.ad.BorderStyle = 2;
            this.ad.Font = new Font("Microsoft Sans Serif", 9.75f, 1, 3, 0);
            this.ad.ForeColor = Color.Gold;
            this.ad.Location = new Point(0x37b, 0x106);
            this.ad.Name = "labelHealth2";
            this.ad.Size = new Size(0x40, 0x1d);
            this.ad.TabIndex = 13;
            this.ad.Text = "0%";
            this.ad.TextAlign = 0x20;
            this.ae.BackColor = SystemColors.ControlText;
            this.ae.BorderStyle = 2;
            this.ae.Font = new Font("Microsoft Sans Serif", 9.75f, 1, 3, 0);
            this.ae.ForeColor = Color.Gold;
            this.ae.Location = new Point(0x37b, 0x123);
            this.ae.Name = "labelHealth3";
            this.ae.Size = new Size(0x40, 0x1d);
            this.ae.TabIndex = 14;
            this.ae.Text = "0%";
            this.ae.TextAlign = 0x20;
            this.af.BackColor = SystemColors.ControlText;
            this.af.BorderStyle = 2;
            this.af.Font = new Font("Microsoft Sans Serif", 9.75f, 1, 3, 0);
            this.af.ForeColor = Color.Gold;
            this.af.Location = new Point(0x37b, 320);
            this.af.Name = "labelHealth4";
            this.af.Size = new Size(0x40, 0x1d);
            this.af.TabIndex = 15;
            this.af.Text = "0%";
            this.af.TextAlign = 0x20;
            this.ag.BackColor = SystemColors.ControlText;
            this.ag.BorderStyle = 2;
            this.ag.Font = new Font("Microsoft Sans Serif", 9.75f, 1, 3, 0);
            this.ag.ForeColor = Color.Gold;
            this.ag.Location = new Point(0x37b, 350);
            this.ag.Name = "labelHealth5";
            this.ag.Size = new Size(0x40, 0x1d);
            this.ag.TabIndex = 0x10;
            this.ag.Text = "0%";
            this.ag.TextAlign = 0x20;
            this.ah.BackColor = SystemColors.ControlText;
            this.ah.BorderStyle = 2;
            this.ah.Font = new Font("Microsoft Sans Serif", 9.75f, 1, 3, 0);
            this.ah.ForeColor = Color.Gold;
            this.ah.Location = new Point(640, 0xcc);
            this.ah.Name = "label11";
            this.ah.Size = new Size(0x56, 0x1d);
            this.ah.TabIndex = 0x11;
            this.ah.Text = "Player ID";
            this.ah.TextAlign = 0x20;
            this.ai.BackColor = SystemColors.ControlText;
            this.ai.BorderStyle = 2;
            this.ai.Font = new Font("Microsoft Sans Serif", 9.75f, 1, 3, 0);
            this.ai.ForeColor = Color.Gold;
            this.ai.Location = new Point(0x2d4, 0xcc);
            this.ai.Name = "label12";
            this.ai.Size = new Size(0x52, 0x1d);
            this.ai.TabIndex = 0x12;
            this.ai.Text = "Points";
            this.ai.TextAlign = 0x20;
            this.aj.BackColor = SystemColors.ControlText;
            this.aj.BorderStyle = 2;
            this.aj.Font = new Font("Microsoft Sans Serif", 9.75f, 1, 3, 0);
            this.aj.ForeColor = Color.Gold;
            this.aj.Location = new Point(0x327, 0xcc);
            this.aj.Name = "label1";
            this.aj.Size = new Size(0x52, 0x1d);
            this.aj.TabIndex = 0x18;
            this.aj.Text = "Coins";
            this.aj.TextAlign = 0x20;
            this.ak.BackColor = SystemColors.ControlText;
            this.ak.BorderStyle = 2;
            this.ak.Font = new Font("Microsoft Sans Serif", 9.75f, 1, 3, 0);
            this.ak.ForeColor = Color.Gold;
            this.ak.Location = new Point(0x327, 0x15f);
            this.ak.Name = "labelPoints4";
            this.ak.Size = new Size(0x52, 0x1d);
            this.ak.TabIndex = 0x13;
            this.ak.Text = "0000 $";
            this.ak.TextAlign = 0x20;
            this.al.BackColor = SystemColors.ControlText;
            this.al.BorderStyle = 2;
            this.al.Font = new Font("Microsoft Sans Serif", 9.75f, 1, 3, 0);
            this.al.ForeColor = Color.Gold;
            this.al.Location = new Point(0x327, 0x125);
            this.al.Name = "labelPoints2";
            this.al.Size = new Size(0x52, 0x1d);
            this.al.TabIndex = 20;
            this.al.Text = "0000 $";
            this.al.TextAlign = 0x20;
            this.am.BackColor = SystemColors.ControlText;
            this.am.BorderStyle = 2;
            this.am.Font = new Font("Microsoft Sans Serif", 9.75f, 1, 3, 0);
            this.am.ForeColor = Color.Gold;
            this.am.Location = new Point(0x327, 0x142);
            this.am.Name = "labelPoints3";
            this.am.Size = new Size(0x52, 0x1d);
            this.am.TabIndex = 0x15;
            this.am.Text = "0000 $";
            this.am.TextAlign = 0x20;
            this.an.BackColor = SystemColors.ControlText;
            this.an.BorderStyle = 2;
            this.an.Font = new Font("Microsoft Sans Serif", 9.75f, 1, 3, 0);
            this.an.ForeColor = Color.Gold;
            this.an.Location = new Point(0x327, 0x108);
            this.an.Name = "labelPoints1";
            this.an.Size = new Size(0x52, 0x1d);
            this.an.TabIndex = 0x16;
            this.an.Text = "0000 $";
            this.an.TextAlign = 0x20;
            this.ao.BackColor = SystemColors.ControlText;
            this.ao.BorderStyle = 2;
            this.ao.Font = new Font("Microsoft Sans Serif", 9.75f, 1, 3, 0);
            this.ao.ForeColor = Color.Gold;
            this.ao.Location = new Point(0x327, 0xeb);
            this.ao.Name = "labelPoints0";
            this.ao.Size = new Size(0x52, 0x1d);
            this.ao.TabIndex = 0x17;
            this.ao.Text = "0000 $";
            this.ao.TextAlign = 0x20;
            this.ap.AutoSize = 1;
            this.ap.Enabled = 0;
            this.ap.Location = new Point(0x25, 0x4c);
            this.ap.Name = "rA2";
            this.ap.Size = new Size(0x2f, 0x11);
            this.ap.TabIndex = 3;
            this.ap.TabStop = 1;
            this.ap.Text = "After";
            this.ap.UseVisualStyleBackColor = 1;
            this.aq.AutoSize = 1;
            this.aq.Location = new Point(6, 0x25);
            this.aq.Name = "label2";
            this.aq.Size = new Size(0xb5, 13);
            this.aq.TabIndex = 1;
            this.aq.Text = "Activate before or after the real client";
            this.ar.AutoSize = 1;
            this.ar.Checked = 1;
            this.ar.Enabled = 0;
            this.ar.Location = new Point(0x25, 0x35);
            this.ar.Name = "rB2";
            this.ar.Size = new Size(0x38, 0x11);
            this.ar.TabIndex = 2;
            this.ar.TabStop = 1;
            this.ar.Text = "Before";
            this.ar.UseVisualStyleBackColor = 1;
            this.@as.AutoSize = 1;
            this.@as.Location = new Point(9, 0x11);
            this.@as.Name = "ud3";
            this.@as.Size = new Size(0x53, 0x11);
            this.@as.TabIndex = 0;
            this.@as.Text = "Use Dummy";
            this.@as.UseVisualStyleBackColor = 1;
            this.@as.CheckedChanged += new EventHandler(this.d);
            this.at.AutoSize = 1;
            this.at.Location = new Point(6, 0x25);
            this.at.Name = "label3";
            this.at.Size = new Size(0xb5, 13);
            this.at.TabIndex = 1;
            this.at.Text = "Activate before or after the real client";
            this.au.Controls.Add(this.av);
            this.au.Controls.Add(this.aw);
            this.au.Controls.Add(this.ax);
            this.au.Controls.Add(this.ay);
            this.au.Enabled = 0;
            this.au.Location = new Point(0x330, 540);
            this.au.Name = "d4";
            this.au.Size = new Size(190, 0x69);
            this.au.TabIndex = 0x1c;
            this.au.TabStop = 0;
            this.au.Text = "Dummy 4";
            this.av.AutoSize = 1;
            this.av.Enabled = 0;
            this.av.Location = new Point(0x25, 0x4c);
            this.av.Name = "rA4";
            this.av.Size = new Size(0x2f, 0x11);
            this.av.TabIndex = 3;
            this.av.TabStop = 1;
            this.av.Text = "After";
            this.av.UseVisualStyleBackColor = 1;
            this.aw.AutoSize = 1;
            this.aw.Checked = 1;
            this.aw.Enabled = 0;
            this.aw.Location = new Point(0x25, 0x35);
            this.aw.Name = "rB4";
            this.aw.Size = new Size(0x38, 0x11);
            this.aw.TabIndex = 2;
            this.aw.TabStop = 1;
            this.aw.Text = "Before";
            this.aw.UseVisualStyleBackColor = 1;
            this.ax.AutoSize = 1;
            this.ax.Location = new Point(6, 0x25);
            this.ax.Name = "label4";
            this.ax.Size = new Size(0xb5, 13);
            this.ax.TabIndex = 1;
            this.ax.Text = "Activate before or after the real client";
            this.ay.AutoSize = 1;
            this.ay.Location = new Point(9, 0x11);
            this.ay.Name = "ud4";
            this.ay.Size = new Size(0x53, 0x11);
            this.ay.TabIndex = 0;
            this.ay.Text = "Use Dummy";
            this.ay.UseVisualStyleBackColor = 1;
            this.ay.CheckedChanged += new EventHandler(this.c);
            this.az.AutoSize = 1;
            this.az.Checked = 1;
            this.az.Enabled = 0;
            this.az.Location = new Point(0x25, 0x35);
            this.az.Name = "rB3";
            this.az.Size = new Size(0x38, 0x11);
            this.az.TabIndex = 2;
            this.az.TabStop = 1;
            this.az.Text = "Before";
            this.az.UseVisualStyleBackColor = 1;
            this.a0.Controls.Add(this.a1);
            this.a0.Controls.Add(this.a2);
            this.a0.Controls.Add(this.a3);
            this.a0.Controls.Add(this.a4);
            this.a0.Location = new Point(620, 0x1ad);
            this.a0.Name = "d1";
            this.a0.Size = new Size(190, 0x69);
            this.a0.TabIndex = 0x19;
            this.a0.TabStop = 0;
            this.a0.Text = "Dummy 1";
            this.a1.AutoSize = 1;
            this.a1.Enabled = 0;
            this.a1.Location = new Point(0x25, 0x4c);
            this.a1.Name = "rA1";
            this.a1.Size = new Size(0x2f, 0x11);
            this.a1.TabIndex = 3;
            this.a1.TabStop = 1;
            this.a1.Text = "After";
            this.a1.UseVisualStyleBackColor = 1;
            this.a2.AutoSize = 1;
            this.a2.Checked = 1;
            this.a2.Enabled = 0;
            this.a2.Location = new Point(0x25, 0x35);
            this.a2.Name = "rB1";
            this.a2.Size = new Size(0x38, 0x11);
            this.a2.TabIndex = 2;
            this.a2.TabStop = 1;
            this.a2.Text = "Before";
            this.a2.UseVisualStyleBackColor = 1;
            this.a3.AutoSize = 1;
            this.a3.Location = new Point(6, 0x25);
            this.a3.Name = "l1";
            this.a3.Size = new Size(0xb5, 13);
            this.a3.TabIndex = 1;
            this.a3.Text = "Activate before or after the real client";
            this.a4.AutoSize = 1;
            this.a4.Location = new Point(9, 0x11);
            this.a4.Name = "ud1";
            this.a4.Size = new Size(0x53, 0x11);
            this.a4.TabIndex = 0;
            this.a4.Text = "Use Dummy";
            this.a4.UseVisualStyleBackColor = 1;
            this.a4.CheckedChanged += new EventHandler(this.f);
            this.a5.AutoSize = 1;
            this.a5.Enabled = 0;
            this.a5.Location = new Point(0x25, 0x4c);
            this.a5.Name = "rA3";
            this.a5.Size = new Size(0x2f, 0x11);
            this.a5.TabIndex = 3;
            this.a5.TabStop = 1;
            this.a5.Text = "After";
            this.a5.UseVisualStyleBackColor = 1;
            this.a6.Controls.Add(this.a5);
            this.a6.Controls.Add(this.az);
            this.a6.Controls.Add(this.aq);
            this.a6.Controls.Add(this.@as);
            this.a6.Enabled = 0;
            this.a6.Location = new Point(620, 540);
            this.a6.Name = "d3";
            this.a6.Size = new Size(190, 0x69);
            this.a6.TabIndex = 0x1d;
            this.a6.TabStop = 0;
            this.a6.Text = "Dummy 3";
            this.a7.AutoSize = 1;
            this.a7.Location = new Point(9, 0x11);
            this.a7.Name = "ud2";
            this.a7.Size = new Size(0x53, 0x11);
            this.a7.TabIndex = 0;
            this.a7.Text = "Use Dummy";
            this.a7.UseVisualStyleBackColor = 1;
            this.a7.CheckedChanged += new EventHandler(this.e);
            this.a8.Enabled = 0;
            this.a8.Location = new Point(0x26f, 0x28b);
            this.a8.Name = "bStart";
            this.a8.Size = new Size(0x17b, 0x1f);
            this.a8.TabIndex = 30;
            this.a8.Text = "Start";
            this.a8.UseVisualStyleBackColor = 1;
            this.a8.Click += new EventHandler(this.a);
            this.a9.Controls.Add(this.ap);
            this.a9.Controls.Add(this.ar);
            this.a9.Controls.Add(this.at);
            this.a9.Controls.Add(this.a7);
            this.a9.Enabled = 0;
            this.a9.Location = new Point(0x330, 0x1ad);
            this.a9.Name = "d2";
            this.a9.Size = new Size(190, 0x69);
            this.a9.TabIndex = 0x1a;
            this.a9.TabStop = 0;
            this.a9.Text = "Dummy 2";
            this.ba.Appearance = 1;
            this.ba.Location = new Point(620, 0x189);
            this.ba.Name = "dr";
            this.ba.Size = new Size(0x182, 30);
            this.ba.TabIndex = 0x1b;
            this.ba.Text = "Demo Run";
            this.ba.TextAlign = 0x20;
            this.ba.UseVisualStyleBackColor = 1;
            this.ba.CheckedChanged += new EventHandler(this.b);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = 1;
            this.BackgroundImage = Resources.bg;
            this.BackgroundImageLayout = 3;
            base.ClientSize = new Size(0x3fa, 0x2d2);
            base.Controls.Add(this.au);
            base.Controls.Add(this.a0);
            base.Controls.Add(this.a6);
            base.Controls.Add(this.a8);
            base.Controls.Add(this.a9);
            base.Controls.Add(this.ba);
            base.Controls.Add(this.aj);
            base.Controls.Add(this.ak);
            base.Controls.Add(this.al);
            base.Controls.Add(this.am);
            base.Controls.Add(this.an);
            base.Controls.Add(this.ao);
            base.Controls.Add(this.ai);
            base.Controls.Add(this.ah);
            base.Controls.Add(this.ag);
            base.Controls.Add(this.af);
            base.Controls.Add(this.ae);
            base.Controls.Add(this.ad);
            base.Controls.Add(this.ac);
            base.Controls.Add(this.p);
            base.Controls.Add(this.aa);
            base.Controls.Add(this.z);
            base.Controls.Add(this.y);
            base.Controls.Add(this.x);
            base.Controls.Add(this.w);
            base.Controls.Add(this.v);
            base.Controls.Add(this.u);
            base.Controls.Add(this.t);
            base.Controls.Add(this.s);
            base.Controls.Add(this.r);
            base.Controls.Add(this.q);
            base.FormBorderStyle = 3;
            base.MaximizeBox = 0;
            base.Name = "GUINormal";
            base.StartPosition = 1;
            this.Text = "TANK GAME - 2011";
            base.Load += new EventHandler(this.h);
            this.au.ResumeLayout(0);
            this.au.PerformLayout();
            this.a0.ResumeLayout(0);
            this.a0.PerformLayout();
            this.a6.ResumeLayout(0);
            this.a6.PerformLayout();
            this.a9.ResumeLayout(0);
            this.a9.PerformLayout();
            base.ResumeLayout(0);
            return;
        }

        protected override void a(bool A_0)
        {
            bool flag;
            if (((A_0 == null) ? 1 : (this.o == null)) != null)
            {
                goto Label_0022;
            }
            this.o.Dispose();
        Label_0022:
            base.Dispose(A_0);
            return;
        }

        private void a(int A_0)
        {
            int num;
            bool flag;
            num = 0;
            goto Label_0056;
        Label_0005:
            if (((this.h[num][0] == A_0) == 0) != null)
            {
                goto Label_0051;
            }
            this.b(this.h[num][1], this.h[num][2]);
            this.h.RemoveAt(num);
            goto Label_0068;
        Label_0051:
            num += 1;
        Label_0056:
            if ((num < this.h.Count) != null)
            {
                goto Label_0005;
            }
        Label_0068:
            return;
        }

        private int a(string A_0)
        {
            int num;
            num = Convert.ToInt32(A_0.Substring(A_0.IndexOf("P") + 1, A_0.Length - 1));
        Label_0024:
            return num;
        }

        public void a(int A_0, int A_1)
        {
            int num;
            int num2;
            num = this.c(A_0);
            num2 = this.b(A_0);
            this.a[num, num2].TextAlign = 0x20;
            this.a[num, num2].ImageAlign = 0x20;
            this.a[num, num2].Image = Resources.life_pack;
            this.a[num, num2].BackColor = Color.Gold;
            this.a[num, num2].ForeColor = Color.Black;
            this.a[num, num2].Text = "LifePack\n" + Convert.ToString(A_1);
            return;
        }

        public unsafe void a(int A_0, string A_1)
        {
            GUI.GUINormal.a a;
            string[] strArray;
            int num;
            bool flag;
            object[] objArray;
            char[] chArray;
            if ((base.InvokeRequired == 0) != null)
            {
                goto Label_0043;
            }
            a = new GUI.GUINormal.a(this.a);
            base.Invoke(a, new object[] { (int) A_0, A_1 });
            goto Label_011A;
        Label_0043:;
            strArray = A_1.Split(new char[] { 0x3a });
            this.g(A_0);
            this.c(strArray[0]);
            this.m = b(strArray[1]);
            this.n = b(strArray[2]);
            num = 0;
            goto Label_00C2;
        Label_008D:
            this.f(this.e(&(this.m[num]).X, &(this.m[num]).Y));
            num += 1;
        Label_00C2:
            if ((num < ((int) this.m.Length)) != null)
            {
                goto Label_008D;
            }
            num = 0;
            goto Label_010A;
        Label_00D5:
            this.d(this.e(&(this.n[num]).X, &(this.n[num]).Y));
            num += 1;
        Label_010A:
            if ((num < ((int) this.n.Length)) != null)
            {
                goto Label_00D5;
            }
        Label_011A:
            return;
        }

        private void a(object A_0, EventArgs A_1)
        {
            int num;
            bool flag;
            if ((this.ba.Checked == 0) != null)
            {
                goto Label_0048;
            }
            this.d = new bool[5];
            num = 0;
            goto Label_0033;
        Label_0024:
            this.d[num] = 1;
            num += 1;
        Label_0033:
            if ((num < ((int) this.d.Length)) != null)
            {
                goto Label_0024;
            }
            goto Label_00FE;
        Label_0048:
            if ((this.ay.Checked == 0) != null)
            {
                goto Label_006B;
            }
            this.d = new bool[4];
            goto Label_00CF;
        Label_006B:
            if ((this.@as.Checked == 0) != null)
            {
                goto Label_008D;
            }
            this.d = new bool[3];
            goto Label_00CF;
        Label_008D:
            if ((this.a7.Checked == 0) != null)
            {
                goto Label_00AF;
            }
            this.d = new bool[2];
            goto Label_00CF;
        Label_00AF:
            if ((this.a4.Checked == 0) != null)
            {
                goto Label_00CF;
            }
            this.d = new bool[1];
        Label_00CF:
            num = 0;
            goto Label_00EE;
        Label_00D3:
            this.d[num] = this.e[num].Checked;
            num += 1;
        Label_00EE:
            if ((num < ((int) this.d.Length)) != null)
            {
                goto Label_00D3;
            }
        Label_00FE:
            this.a8.Enabled = 0;
            this.ba.Enabled = 0;
            this.a0.Enabled = 0;
            this.a9.Enabled = 0;
            this.a6.Enabled = 0;
            this.au.Enabled = 0;
            return;
        }

        public void a(int A_0, int A_1, int A_2)
        {
            int num;
            int num2;
            num = this.c(A_0);
            num2 = this.b(A_0);
            this.a[num, num2].TextAlign = 0x20;
            this.a[num, num2].ImageAlign = 0x20;
            this.a[num, num2].Image = Resources.coin;
            this.a[num, num2].BackColor = Color.Silver;
            this.a[num, num2].ForeColor = Color.Black;
            this.a[num, num2].Text = Convert.ToString(A_1) + "$\n" + Convert.ToString(A_2);
            return;
        }

        public void a(int A_0, int A_1, int A_2, int A_3)
        {
            int num;
            int num2;
            int num3;
            num = A_0;
            num2 = A_1;
            num3 = num;
            switch (num3)
            {
                case 0:
                    goto Label_0026;

                case 1:
                    goto Label_0080;

                case 2:
                    goto Label_00DA;

                case 3:
                    goto Label_0134;

                case 4:
                    goto Label_018B;
            }
            goto Label_01E2;
        Label_0026:;
        Label_003C:
            this.q.Text = Convert.ToString(num2) ?? "";
            this.ao.Text = Convert.ToString(A_2) + " $";
            this.ac.Text = Convert.ToString(A_3) + " %";
            goto Label_01E2;
        Label_0080:;
        Label_0096:
            this.r.Text = Convert.ToString(num2) ?? "";
            this.an.Text = Convert.ToString(A_2) + " $";
            this.ad.Text = Convert.ToString(A_3) + " %";
            goto Label_01E2;
        Label_00DA:;
        Label_00F0:
            this.t.Text = Convert.ToString(num2) ?? "";
            this.al.Text = Convert.ToString(A_2) + " $";
            this.ae.Text = Convert.ToString(A_3) + " %";
            goto Label_01E2;
        Label_0134:;
        Label_014A:
            this.s.Text = Convert.ToString(num2) ?? "";
            this.am.Text = Convert.ToString(A_2) + " $";
            this.af.Text = Convert.ToString(A_3) + " %";
            goto Label_01E2;
        Label_018B:;
        Label_01A1:
            this.u.Text = Convert.ToString(num2) ?? "";
            this.ak.Text = Convert.ToString(A_2) + " $";
            this.ag.Text = Convert.ToString(A_3) + " %";
        Label_01E2:
            return;
        }

        public bool[] b()
        {
            bool[] flagArray;
            flagArray = this.d;
        Label_000A:
            return flagArray;
        }

        private int b(int A_0)
        {
            int num;
            num = A_0 % this.b;
        Label_000C:
            return num;
        }

        private static unsafe Point[] b(string A_0)
        {
            List<Point> list;
            Point point;
            string[] strArray;
            int num;
            Point[] pointArray;
            Point[] pointArray2;
            char[] chArray;
            bool flag;
            list = new List<Point>();
            strArray = A_0.Split(new char[] { 0x3b });
            num = 0;
            goto Label_0087;
        Label_0022:
            &point = new Point(int.Parse(strArray[num].Substring(0, strArray[num].IndexOf(","))), int.Parse(strArray[num].Substring(strArray[num].IndexOf(",") + 1, (strArray[num].Length - strArray[num].IndexOf(",")) - 1)));
            list.Add(point);
            num += 1;
        Label_0087:
            if ((num < ((int) strArray.Length)) != null)
            {
                goto Label_0022;
            }
            pointArray2 = list.ToArray();
        Label_00A1:
            return pointArray2;
        }

        public void b(int A_0, int A_1)
        {
            int num;
            int num2;
            int num3;
            num = this.c(A_0);
            num2 = this.b(A_0);
            num3 = A_1;
            switch (num3)
            {
                case 0:
                    goto Label_002B;

                case 1:
                    goto Label_0041;

                case 2:
                    goto Label_005B;

                case 3:
                    goto Label_0075;
            }
            goto Label_008F;
        Label_002B:
            this.a[num, num2].Image = null;
            goto Label_0091;
        Label_0041:
            this.a[num, num2].Image = Resources.Waterarea;
            goto Label_0091;
        Label_005B:
            this.a[num, num2].Image = Resources.coin;
            goto Label_0091;
        Label_0075:
            this.a[num, num2].Image = Resources.life_pack;
            goto Label_0091;
        Label_008F:;
        Label_0091:
            this.a[num, num2].TextAlign = 0x20;
            this.a[num, num2].BackColor = Color.WhiteSmoke;
            this.a[num, num2].ForeColor = Color.Black;
            this.a[num, num2].Text = Convert.ToString((num * this.b) + num2);
            return;
        }

        private void b(object A_0, EventArgs A_1)
        {
            bool flag;
            if ((this.ba.Checked == 0) != null)
            {
                goto Label_0031;
            }
            this.a0.Enabled = 0;
            this.a8.Enabled = 1;
            goto Label_0081;
        Label_0031:
            this.a0.Enabled = 1;
            this.a4.Checked = 0;
            this.a7.Checked = 0;
            this.@as.Checked = 0;
            this.ay.Checked = 0;
            this.a8.Enabled = 0;
        Label_0081:
            this.a9.Enabled = 0;
            this.a6.Enabled = 0;
            this.au.Enabled = 0;
            return;
        }

        public void b(int A_0, int A_1, int A_2)
        {
            int num;
            int num2;
            Image[] imageArray;
            int num3;
            num = this.c(A_0);
            num2 = this.b(A_0);
            this.a[num, num2].TextAlign = 0x20;
            this.a[num, num2].ForeColor = Color.Red;
            this.a[num, num2].Image = Resources.tank_up;
            this.a[num, num2].BackColor = Color.Black;
            this.a[num, num2].ForeColor = Color.Gold;
            imageArray = this.c[A_2];
            num3 = A_1;
            switch (num3)
            {
                case 0:
                    goto Label_00AD;

                case 1:
                    goto Label_00C5;

                case 2:
                    goto Label_00DD;

                case 3:
                    goto Label_00F5;
            }
            goto Label_010D;
        Label_00AD:
            this.a[num, num2].Image = imageArray[0];
            goto Label_010F;
        Label_00C5:
            this.a[num, num2].Image = imageArray[1];
            goto Label_010F;
        Label_00DD:
            this.a[num, num2].Image = imageArray[2];
            goto Label_010F;
        Label_00F5:
            this.a[num, num2].Image = imageArray[3];
            goto Label_010F;
        Label_010D:;
        Label_010F:
            return;
        }

        public void b(int A_0, int A_1, int A_2, int A_3)
        {
            GUI.GUINormal.f f;
            bool flag;
            object[] objArray;
            if ((base.InvokeRequired == 0) != null)
            {
                goto Label_0054;
            }
            f = new GUI.GUINormal.f(this.b);
            base.Invoke(f, new object[] { (int) A_0, (int) A_1, (int) A_2, (int) A_3 });
            goto Label_0068;
        Label_0054:
            this.d(A_0, this.e(A_1, A_2), A_3);
        Label_0068:
            return;
        }

        private int c(int A_0)
        {
            int num;
            num = A_0 / this.b;
        Label_000C:
            return num;
        }

        private void c(string A_0)
        {
            string[] strArray;
            string str;
            string[] strArray2;
            int num;
            int num2;
            int num3;
            char[] chArray;
            string[] strArray3;
            int num4;
            bool flag;
            strArray = A_0.Split(new char[] { 0x3b });
            strArray3 = strArray;
            num4 = 0;
            goto Label_0089;
        Label_0021:
            str = strArray3[num4];
            strArray2 = str.Split(new char[] { 0x2c });
            num = Convert.ToInt32(strArray2[0]);
            num2 = Convert.ToInt32(strArray2[1]);
            num3 = 0;
            if (((((int) strArray2.Length) == 3) == 0) != null)
            {
                goto Label_0070;
            }
            num3 = Convert.ToInt32(strArray2[2]);
        Label_0070:
            this.d(this.e(num, num2), num3);
            num4 += 1;
        Label_0089:
            if ((num4 < ((int) strArray3.Length)) != null)
            {
                goto Label_0021;
            }
            return;
        }

        public void c(int A_0, int A_1)
        {
            GUI.GUINormal.h h;
            int num;
            bool flag;
            object[] objArray;
            if ((base.InvokeRequired == 0) != null)
            {
                goto Label_0041;
            }
            h = new GUI.GUINormal.h(this.c);
            base.Invoke(h, new object[] { (int) A_0, (int) A_1 });
            goto Label_0076;
        Label_0041:
            this.b(this.e(A_0, A_1), 0);
            num = this.e(A_0, A_1);
            this.k.Remove(num);
            this.l.Remove(num);
        Label_0076:
            return;
        }

        private void c(object A_0, EventArgs A_1)
        {
            this.aw.Enabled = this.aw.Enabled == 0;
            this.av.Enabled = this.av.Enabled == 0;
            this.@as.Enabled = this.@as.Enabled == 0;
            return;
        }

        public void c(int A_0, int A_1, int A_2)
        {
            GUI.GUINormal.b b;
            bool flag;
            object[] objArray;
            if ((base.InvokeRequired == 0) != null)
            {
                goto Label_004A;
            }
            b = new GUI.GUINormal.b(this.c);
            base.Invoke(b, new object[] { (int) A_0, (int) A_1, (int) A_2 });
            goto Label_0070;
        Label_004A:
            this.a(this.e(A_0, A_1), A_2);
            this.l.Add(this.e(A_0, A_1));
        Label_0070:
            return;
        }

        public void c(int A_0, int A_1, int A_2, int A_3)
        {
            GUI.GUINormal.e e;
            bool flag;
            object[] objArray;
            if ((base.InvokeRequired == 0) != null)
            {
                goto Label_0054;
            }
            e = new GUI.GUINormal.e(this.c);
            base.Invoke(e, new object[] { (int) A_0, (int) A_1, (int) A_2, (int) A_3 });
            goto Label_007C;
        Label_0054:
            this.a(this.e(A_0, A_1), A_2, A_3);
            this.k.Add(this.e(A_0, A_1));
        Label_007C:
            return;
        }

        public void d(int A_0)
        {
            int num;
            int num2;
            num = this.c(A_0);
            num2 = this.b(A_0);
            this.a[num, num2].TextAlign = 0x20;
            this.a[num, num2].Image = Resources.Waterarea;
            this.a[num, num2].BackColor = Color.Blue;
            this.a[num, num2].ForeColor = Color.Black;
            this.a[num, num2].Text = "Water";
            return;
        }

        public void d(string A_0)
        {
            GUI.GUINormal.d d;
            string[] strArray;
            int num;
            string[] strArray2;
            int num2;
            int num3;
            int num4;
            int num5;
            int num6;
            int num7;
            int num8;
            int num9;
            bool flag;
            object[] objArray;
            char[] chArray;
            if ((base.InvokeRequired == 0) != null)
            {
                goto Label_003B;
            }
            d = new GUI.GUINormal.d(this.d);
            base.Invoke(d, new object[] { A_0 });
            goto Label_018E;
        Label_003B:;
            strArray = A_0.Split(new char[] { 0x3a });
            this.c(strArray[((int) strArray.Length) - 1]);
            num = 0;
            goto Label_009E;
        Label_0065:
            if (this.k.Contains(this.j[num]) != null)
            {
                goto Label_0099;
            }
            this.b(this.j[num], 0);
        Label_0099:
            num += 1;
        Label_009E:
            if ((num < this.j.Count) != null)
            {
                goto Label_0065;
            }
            num = 1;
            goto Label_0179;
        Label_00B9:;
            strArray2 = strArray[num].Split(new char[] { 0x2c, 0x3b });
            num2 = this.a(strArray2[0]);
            num3 = Convert.ToInt32(strArray2[1]);
            num4 = Convert.ToInt32(strArray2[2]);
            num5 = Convert.ToInt32(strArray2[3]);
            num6 = Convert.ToInt32(strArray2[4]);
            num7 = Convert.ToInt32(strArray2[5]);
            num8 = Convert.ToInt32(strArray2[6]);
            num9 = Convert.ToInt32(strArray2[7]);
            if (((num7 > 0) == 0) != null)
            {
                goto Label_014F;
            }
            this.b(this.e(num3, num4), num5, num2);
        Label_014F:
            this.a(num2, num9, num8, num7);
            this.j.Add(this.e(num3, num4));
            num += 1;
        Label_0179:
            if ((num < (this.i + 1)) != null)
            {
                goto Label_00B9;
            }
        Label_018E:
            return;
        }

        public void d(int A_0, int A_1)
        {
            int num;
            int num2;
            int num3;
            bool flag;
            int num4;
            if ((A_1 == 4) != null)
            {
                goto Label_0127;
            }
            num = this.c(A_0);
            num2 = this.b(A_0);
            this.a[num, num2].TextAlign = 0x20;
            num3 = (A_1 * 100) / 4;
            num4 = num3;
            if (num4 > 0x19)
            {
                goto Label_004F;
            }
            if (num4 == 0)
            {
                goto Label_00AB;
            }
            if (num4 == 0x19)
            {
                goto Label_005D;
            }
            goto Label_00C5;
        Label_004F:
            if (num4 == 50)
            {
                goto Label_0077;
            }
            if (num4 == 0x4b)
            {
                goto Label_0091;
            }
            goto Label_00C5;
        Label_005D:
            this.a[num, num2].Image = Resources.brick_wall_25;
            goto Label_00C5;
        Label_0077:
            this.a[num, num2].Image = Resources.brick_wall_50;
            goto Label_00C5;
        Label_0091:
            this.a[num, num2].Image = Resources.brick_wall_75;
            goto Label_00C5;
        Label_00AB:
            this.a[num, num2].Image = Resources.brick_wall;
        Label_00C5:
            this.a[num, num2].BackColor = Color.Brown;
            this.a[num, num2].ForeColor = Color.Black;
            this.a[num, num2].Text = "Brick \n" + ((int) (((4 - A_1) * 100) / 4)) + "%";
            goto Label_0132;
        Label_0127:
            this.b(A_0, 0);
        Label_0132:
            return;
        }

        private void d(object A_0, EventArgs A_1)
        {
            this.au.Enabled = this.au.Enabled == 0;
            this.az.Enabled = this.az.Enabled == 0;
            this.a5.Enabled = this.a5.Enabled == 0;
            this.a7.Enabled = this.a7.Enabled == 0;
            return;
        }

        public void d(int A_0, int A_1, int A_2)
        {
            int num;
            int num2;
            bool flag;
            int[] numArray;
            int num3;
            if (((A_1 > 0) == 0) != null)
            {
                goto Label_017D;
            }
            num = this.c(A_1);
            num2 = this.b(A_1);
            this.a(A_0);
            if ((this.n.Contains<Point>(new Point(num, num2)) == 0) != null)
            {
                goto Label_0068;
            }
            this.h.Add(new int[] { A_0, A_1, 1 });
            goto Label_00F4;
        Label_0068:
            if ((this.k.Contains(A_1) == 0) != null)
            {
                goto Label_009F;
            }
            this.h.Add(new int[] { A_0, A_1, 2 });
            goto Label_00F4;
        Label_009F:
            if ((this.l.Contains(A_1) == 0) != null)
            {
                goto Label_00D6;
            }
            this.h.Add(new int[] { A_0, A_1, 3 });
            goto Label_00F4;
        Label_00D6:
            numArray = new int[3];
            numArray[0] = A_0;
            numArray[1] = A_1;
            this.h.Add(numArray);
        Label_00F4:
            num3 = A_2;
            switch (num3)
            {
                case 0:
                    goto Label_0110;

                case 1:
                    goto Label_012A;

                case 2:
                    goto Label_0144;

                case 3:
                    goto Label_015E;
            }
            goto Label_0178;
        Label_0110:
            this.a[num, num2].Image = Resources.bullet_up;
            goto Label_017A;
        Label_012A:
            this.a[num, num2].Image = Resources.bullet_right;
            goto Label_017A;
        Label_0144:
            this.a[num, num2].Image = Resources.bullet_down;
            goto Label_017A;
        Label_015E:
            this.a[num, num2].Image = Resources.bullet_left;
            goto Label_017A;
        Label_0178:;
        Label_017A:
            goto Label_0187;
        Label_017D:
            this.a(A_0);
        Label_0187:
            return;
        }

        public void d(int A_0, int A_1, int A_2, int A_3)
        {
            GUI.GUINormal.g g;
            bool flag;
            object[] objArray;
            if ((base.InvokeRequired == 0) != null)
            {
                goto Label_0054;
            }
            g = new GUI.GUINormal.g(this.d);
            base.Invoke(g, new object[] { (int) A_0, (int) A_1, (int) A_2, (int) A_3 });
            goto Label_0076;
        Label_0054:
            this.b(this.e(A_0, A_1), A_2, A_3);
            this.i += 1;
        Label_0076:
            return;
        }

        public void e(int A_0)
        {
            this.aa.Text = Convert.ToString(A_0);
            return;
        }

        public int e(int A_0, int A_1)
        {
            int num;
            bool flag;
            if (((A_0 < 0) ? 1 : (A_1 < 0)) != null)
            {
                goto Label_001E;
            }
            num = (A_0 * this.b) + A_1;
            goto Label_0023;
        Label_001E:
            num = -1;
        Label_0023:
            return num;
        }

        private void e(object A_0, EventArgs A_1)
        {
            this.a6.Enabled = this.a6.Enabled == 0;
            this.ar.Enabled = this.ar.Enabled == 0;
            this.ap.Enabled = this.ap.Enabled == 0;
            this.a4.Enabled = this.a4.Enabled == 0;
            return;
        }

        public void f(int A_0)
        {
            int num;
            int num2;
            num = this.c(A_0);
            num2 = this.b(A_0);
            this.a[num, num2].TextAlign = 0x20;
            this.a[num, num2].Image = Resources.stone_wall;
            this.a[num, num2].BackColor = Color.Black;
            this.a[num, num2].ForeColor = Color.LightYellow;
            this.a[num, num2].Text = "Stone";
            return;
        }

        private void f(object A_0, EventArgs A_1)
        {
            this.a9.Enabled = this.a9.Enabled == 0;
            this.a2.Enabled = this.a2.Enabled == 0;
            this.a1.Enabled = this.a1.Enabled == 0;
            this.a8.Enabled = this.a8.Enabled == 0;
            return;
        }

        public void g(int A_0)
        {
            int num;
            int num2;
            int num3;
            int num4;
            int num5;
            int num6;
            bool flag;
            this.b = A_0;
            num = 50;
            num2 = 50;
            num3 = 500 / A_0;
            num4 = 80 / A_0;
            this.a = new Label[A_0, A_0];
            num5 = 0;
            goto Label_0153;
        Label_0030:
            num6 = 0;
            goto Label_013E;
        Label_0039:
            this.a[num5, num6] = new Label();
            this.a[num5, num6].BorderStyle = 2;
            this.a[num5, num6].Location = new Point(num + (num3 * num5), num2 + (num3 * num6));
            this.a[num5, num6].Size = new Size(num3, num3);
            this.a[num5, num6].BackColor = Color.WhiteSmoke;
            this.a[num5, num6].Font = new Font("Times New Roman", (float) num4, 1, 3, 0);
            this.a[num5, num6].TextAlign = 0x20;
            this.a[num5, num6].Text = Convert.ToString((num5 * A_0) + num6);
            base.Controls.Add(this.a[num5, num6]);
            num6 += 1;
        Label_013E:
            if ((num6 < A_0) != null)
            {
                goto Label_0039;
            }
            num5 += 1;
        Label_0153:
            if ((num5 < A_0) != null)
            {
                goto Label_0030;
            }
            return;
        }

        private void g(object A_0, EventArgs A_1)
        {
            return;
        }

        private void h(object A_0, EventArgs A_1)
        {
            return;
        }

        private void i(object A_0, EventArgs A_1)
        {
            Application.Exit();
            return;
        }

        protected override bool IsInputKey(Keys keyData)
        {
            bool flag;
            bool flag2;
            if (((((((keyData == 0x26) | (keyData == 40)) | (keyData == 0x25)) | (keyData == 0x27)) | (keyData == 0x11)) == 0) != null)
            {
                goto Label_002A;
            }
            flag = 1;
            goto Label_0034;
        Label_002A:
            flag = base.IsInputKey(keyData);
        Label_0034:
            return flag;
        }

        private delegate void a(int A_0, string A_1);

        private delegate void b(int A_0, int A_1, int A_2);

        private delegate void c(int A_0);

        private delegate void d(string A_0);

        private delegate void e(int A_0, int A_1, int A_2, int A_3);

        private delegate void f(int A_0, int A_1, int A_2, int A_3);

        private delegate void g(int A_0, int A_1, int A_2, int A_3);

        private delegate void h(int A_0, int A_1);
    }
}
