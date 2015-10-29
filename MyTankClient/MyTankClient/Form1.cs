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

        // Create a logger for use in this class
        private static log4net.ILog log = log4net.LogManager.GetLogger(typeof(Form1));

        public Form1()
        {
            //Initiate logging based on XML configuration
            log4net.Config.XmlConfigurator.Configure();

            InitializeComponent();
            //Call the logger
            log.Info("Components initialized...");

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

        
    }
}
