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

        public Form1()
        {
            InitializeComponent();
            client = new MyClient();
            Form1.CheckForIllegalCrossThreadCalls = false;
            Thread thread = new Thread(new ThreadStart(updateMap));
            thread.Start();
        }

        protected void updateMap()
        {
            
                
                  
                
            
        }

        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                client.sendToServer("LEFT#", this);
            }
            else if (e.KeyCode == Keys.Right)
            {
                client.sendToServer("RIGHT#", this);
            }
            else if (e.KeyCode == Keys.Up)
            {
                client.sendToServer("UP#", this);
            }
            else if (e.KeyCode == Keys.Down)
            {
                client.sendToServer("DOWN#", this);
            }
            else if (e.KeyCode == Keys.A)
            {
                client.sendToServer("SHOOT#", this);
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

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

        }


        
    }
}
