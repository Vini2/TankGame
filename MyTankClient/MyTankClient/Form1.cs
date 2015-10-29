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

        // Create a logger for use in this class
        private static log4net.ILog log = log4net.LogManager.GetLogger(typeof(Form1));

        public Form1()
        {
            //Initiate logging based on XML configuration
            log4net.Config.XmlConfigurator.Configure();

            InitializeComponent();
            //Call the logger
            log.Info("Components initialized");

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

            //Call the logger
            log.Info(e.KeyCode+" pressed");

            if (e.KeyCode == Keys.Left)
            {
                Assert.AreEqual("Left", e.KeyCode.ToString());
                client.sendToServer("LEFT#", this);
            }
            else if (e.KeyCode == Keys.Right)
            {
                Assert.AreEqual("Right", e.KeyCode.ToString());
                client.sendToServer("RIGHT#", this);
            }
            else if (e.KeyCode == Keys.Up)
            {
                Assert.AreEqual("Up", e.KeyCode.ToString());
                client.sendToServer("UP#", this);
            }
            else if (e.KeyCode == Keys.Down)
            {
                Assert.AreEqual("Down", e.KeyCode.ToString());
                client.sendToServer("DOWN#", this);
            }
            else if (e.KeyCode == Keys.A)
            {
                Assert.AreEqual("A", e.KeyCode.ToString());
                client.sendToServer("SHOOT#", this);
            }
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

        private void LogText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString()=="A")
            {
                LogText.Text = "";
            }
        }

        /*[TestMethod()]
        public void combineArrayStringWithSpaceTest(String input)
        {
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual = input;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        } */ 
        
    }
}
