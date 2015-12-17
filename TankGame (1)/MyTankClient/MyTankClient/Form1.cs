using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTankClient
{
    public partial class Form1 : Form
    {
        MyClient client;
        public static string[,] map = new string[10, 10];

        //Array of picture boxes
        public static PictureBox[,] formMap = new PictureBox[10, 10];

        // Create a logger for use in this class
        private static log4net.ILog log = log4net.LogManager.GetLogger(typeof(Form1));

        public Form1()
        {
            //Initiate logging based on XML configuration
            log4net.Config.XmlConfigurator.Configure();

            InitializeComponent();
            //Call the logger
            log.Info("Components initialized...");

            initializeMap();

            client = new MyClient();
            Form1.CheckForIllegalCrossThreadCalls = false;
            Thread thread = new Thread(new ThreadStart(updateMap));
            thread.Start();
        }

        public static void updateMap()
        {
            
        }


        public static void updateWholeMap() {
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {

                    if (map[x, y].Equals("C"))
                    {
                        Form1.formMap[x, y].BackgroundImage = Properties.Resources.coin;
                    }
                    else if (map[x, y].Equals("L"))
                    {
                        Form1.formMap[x, y].BackgroundImage = Properties.Resources.redc;
                    }
                    else if (map[x, y].Equals("B"))
                    {
                        Form1.formMap[x, y].BackgroundImage = Properties.Resources.bricks;
                    }
                    else if (map[x, y].Equals("S"))
                    {
                        Form1.formMap[x, y].BackgroundImage = Properties.Resources.stone;
                    }
                    else if (map[x, y].Equals("W"))
                    {
                        Form1.formMap[x, y].BackgroundImage = Properties.Resources.water;
                    }
                    else if (map[x, y].Equals("T"))
                    {
                        Form1.formMap[x, y].BackgroundImage = Properties.Resources.tankme;
                    }
                    else
                    {
                        Form1.formMap[x, y].BackgroundImage = Properties.Resources.grass;
                    }

                    Form1.formMap[x, y].BackgroundImageLayout = ImageLayout.Stretch;



                }
            }
        }


        /*public static void updateMap(int x, int y, string s)
        {

            if (s.Equals('_'))
            {
                formMap[x, y].BackgroundImage = Properties.Resources.grass;
            }
            else if(s.Equals("C"))
            {
                formMap[x, y].BackgroundImage = Properties.Resources.coin;
            }
            else if (s.Equals("L"))
            {
                formMap[x, y].BackgroundImage = Properties.Resources.redc;
            }
            else if (s.Equals("B"))
            {
                formMap[x, y].BackgroundImage = Properties.Resources.bricks;
            }
            else if (s.Equals("S"))
            {
                formMap[x, y].BackgroundImage = Properties.Resources.stone;
            }
            else if (s.Equals("W"))
            {
                formMap[x, y].BackgroundImage = Properties.Resources.water;
            }
            else if (s.Equals("T"))
            {
                formMap[x, y].BackgroundImage = Properties.Resources.tankme;
            }

            formMap[x, y].BackgroundImageLayout = ImageLayout.Stretch;

        }*/


        public void initializeMap() {


            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    try
                    {
                        formMap[i,j] = (PictureBox)Controls.Find("pb" + (i + 1).ToString() + "" + (j + 1), true)[0];

                    }
                    catch (IndexOutOfRangeException)
                    {
                    }
                }
            }
            

        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Call the logger
            log.Info(e.KeyCode.ToString()+" pressed...");

            if (e.KeyCode == Keys.Left)
            {
                //Unit testing
                Assert.AreEqual("Left", e.KeyCode.ToString());

                btnLeft.PerformClick();
                btnLeft.Focus();
            }
            else if (e.KeyCode == Keys.Right)
            {
                //Unit testing
                Assert.AreEqual("Right", e.KeyCode.ToString());

                btnRight.PerformClick();
                btnRight.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                //Unit testing
                Assert.AreEqual("Up", e.KeyCode.ToString());

                btnUp.PerformClick();
                btnUp.Focus();
            }
            else if (e.KeyCode == Keys.Down)
            {
                //Unit testing
                Assert.AreEqual("Down", e.KeyCode.ToString());

                btnDown.PerformClick();
                btnDown.Focus();
            }
            else if (e.KeyCode == Keys.Space)
            {
                //Assert.AreEqual("Space", e.KeyCode.ToString());
                btnShoot.PerformClick();
                btnShoot.Focus();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        //Button click controls
        private void btnJoin_Click(object sender, EventArgs e)
        {
            client.sendToServer("JOIN#", this);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            client.sendToServer("UP#", this);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            client.sendToServer("RIGHT#", this);
        }

        private void btnShoot_Click(object sender, EventArgs e)
        {
            client.sendToServer("SHOOT#", this);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            client.sendToServer("DOWN#", this);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            client.sendToServer("LEFT#", this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                control.PreviewKeyDown += new PreviewKeyDownEventHandler(control_PreviewKeyDown);
            }
        }

        void control_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.A)
            {
                e.IsInputKey = true;
            }
        }

        private void pb12_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
