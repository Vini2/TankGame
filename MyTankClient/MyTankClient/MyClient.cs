using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace MyTankClient
{
    class MyClient
    {

        private TcpClient client_1;
        private string ip = "127.0.0.1";
     
        private Int32 portIn = 6000;   //Port use to connect
        private Int32 portOut = 7000;  //Port to recieve

        private string data;

        private Form1 com;

        private Thread thread;

        //to keep the initial player details
        private int playerLocationX, playerLocationY;
        private string playerName,direction;
        
        //initial locations of bricks,stones & water
        private int[,] bricks,stones,water;

        //details of each players and damage levels
        private string[] player1, player2, player3, player4, player5,p1damage,p2damage,p3damage,p4damage,p5damage;
        
        //coins and life pakc availability
        private string[][] coins,lifepacks;


        public MyClient() {
            thread = new Thread(new ThreadStart(recieveFromServer));
        }

        //Send message to the server
         public void sendToServer(string message,Form1 com) 
        {
            this.com = com; 
            client_1 = new TcpClient();
            client_1.Connect(IPAddress.Parse(ip), portIn);
            Stream stream = client_1.GetStream();

            ASCIIEncoding asciiencode = new ASCIIEncoding();
            byte[] msg = asciiencode.GetBytes(message);

            stream.Write(msg, 0, msg.Length);
            stream.Close();
            client_1.Close();
            if (message.Equals("JOIN#"))    //Start the game with the command JOIN#
                thread.Start();
        }

        //Get messages from server
        public void recieveFromServer() 
        {
            TcpListener listner = new TcpListener(IPAddress.Parse(ip), portOut);
            while (true)
            {
                listner.Start();
                TcpClient clientRecieve = listner.AcceptTcpClient();
                Stream streamRecieve = clientRecieve.GetStream();
                Byte[] bytes = new Byte[256];

                int i;
                data = null;

                while ((i = streamRecieve.Read(bytes, 0, bytes.Length)) != 0)
                {
                    data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                }

                if (data.Substring(0,1).Equals("S"))
                {
                    decodeInitialPlayerLocations(data);
                }
                else if (data.Substring(0, 1).Equals("I"))
                {
                    decodeObstacleLocations(data);
                }
                else if (data.Substring(0, 1).Equals("C"))
                {
                    decodeCoinLocations(data);
                }
                else if (data.Substring(0, 1).Equals("G"))
                {
                    decodeCurrentState(data);
                }
                else if (data.Substring(0, 1).Equals("L"))
                {
                    decodeLifePacks(data);
                }

                string[] lines = Regex.Split(data, ":");
                    com.Invoke(new Action(() =>
                    {
                        if (lines.Length == 5)
                        {
                            //com.displayData("gggggggggggg");
                            Console.Write("ggggg");
                        }
                        else
                        {
                            //com.displayData("\n message => \n"+data + "\n");
                            Console.Write("\n message => \n" + data + "\n");
                        }
                    }));
                streamRecieve.Close();
                listner.Stop();
                clientRecieve.Close();
            }
        }

        private void decodeLifePacks(string data)
        {
            throw new NotImplementedException();
        }

        private void decodeCurrentState(string data)
        {
            throw new NotImplementedException();
        }

        private void decodeCoinLocations(string data)
        {
            throw new NotImplementedException();
        }

        private void decodeObstacleLocations(string data)
        {
            string[] lines = Regex.Split(data, ":#");
            string bricksStr = lines[2];
            string stoneStr = lines[3];
            string waterStr = lines[4];

            string[] brickStrCordinates = Regex.Split(bricksStr, ";,");
            string[] stoneStrCordinates = Regex.Split(bricksStr, ";,");
            string[] waterStrCordinates = Regex.Split(bricksStr, ";,");

            bricks = new int[2, (brickStrCordinates.Length / 2)];
            stones = new int[2, (stoneStrCordinates.Length / 2)];
            water = new int[2, (waterStrCordinates.Length / 2)];
            
            for (int x = 0; x < brickStrCordinates.Length; x++)
            {
                if (x % 2 == 0)
                {
                    bricks[0, x/2] = Int32.Parse(brickStrCordinates[x]);
                }
                else
                {
                    bricks[1, x / 2] = Int32.Parse(brickStrCordinates[x]);
                }
            }

            for (int x = 0; x < stoneStrCordinates.Length; x++)
            {
                if (x % 2 == 0)
                {
                    stones[0, x / 2] = Int32.Parse(stoneStrCordinates[x]);
                }
                else
                {
                    stones[1, x / 2] = Int32.Parse(stoneStrCordinates[x]);
                }
            }

            for (int x = 0; x < waterStrCordinates.Length; x++)
            {
                if (x % 2 == 0)
                {
                    water[0, x / 2] = Int32.Parse(waterStrCordinates[x]);
                }
                else
                {
                    water[1, x / 2] = Int32.Parse(waterStrCordinates[x]);
                }
            }
        }

        private void decodeInitialPlayerLocations(string data)
        {
            string[] lines = Regex.Split(data, ":");
            string[] cordinates = Regex.Split(lines[2], ":");
            playerName = lines[1];
            playerLocationX = Int32.Parse(cordinates[0]);
            playerLocationY = Int32.Parse(cordinates[1]);
            direction = lines[3];
        }

    }
}
