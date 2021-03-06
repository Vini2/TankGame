﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private Thread thread,thread2;

        public static string[,] map = new string[10, 10];

        //To keep the list of tanks,coins,LifePacks,bricks,water & stones
        private static ArrayList coinPacks = new ArrayList();
        private static ArrayList lifePacks = new ArrayList();
        private static ArrayList tankList = new ArrayList();
        private static ArrayList brickList = new ArrayList();
        private static ArrayList waterList = new ArrayList();
        private static ArrayList stoneList = new ArrayList();

        private string[,] matrix = new string[20,20];
        
        //this contains the number of tanks in the game
        int numberOfTanks = 0;
        int numberOfBricks = 0;

        //the constructor
        public MyClient() {
            thread = new Thread(new ThreadStart(recieveFromServer));
            //thread2 = new Thread(new ThreadStart(update));
        }

        public static void update()
        {
            while (true)
            {
                updateCoinsAndLifepacks();
                Thread.Sleep(800);
            }
        }

        //this function would print out the current map on the Console
        public void printMap()
        {
            foreach (Player tank in tankList)
            {
                Console.WriteLine(tank.name);
                int x = tank.x;
                int y = tank.y;
                map[y, x] = "T";
            }
            Console.WriteLine("Printing map");
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    Console.Write(map[x, y] + " ");
                }
                Console.WriteLine();
            }
        }

        //this method would update the map with coins and life packs
        public void updateMap()
        {
           
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    if (map[x, y].Equals("C") || map[x, y].Equals("L"))
                    {
                        map[x, y] = "_";
                    }
                }
            }
            try
            {
                foreach (CoinPack item in coinPacks)
                {
                    if (item.time > 0)
                    {

                        map[item.y, item.x] = "C";
                    }
                    else
                    {
                        coinPacks.Remove(item);
                    }
                }
            }
            catch (Exception e)
            {

            }

            try
            {
                foreach (LifePack item in lifePacks)
                {
                    if (item.time > 0)
                    {
                        map[item.y, item.x] = "L";
                    }
                    else
                    {
                        lifePacks.Remove(item);
                    }
                }
            }
            catch (Exception e)
            {

            }
        }

        //this would update the locations of the tanks
        public static void updateTanks()
        {
            foreach (Player tank in tankList)
            {
                int xCor = tank.x;
                int yCor = tank.y;
                map[yCor, xCor] = "_";

            }
        }

        //this method would decrement the time of life packs and update them
        public static void updateCoinsAndLifepacks()
        {

            foreach(CoinPack item in coinPacks )
            {
                item.time -= 1;
            }

            foreach(LifePack item in lifePacks)
            {
                item.time -=1;
            }

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
                updateCoinsAndLifepacks();
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
                else
                {
                    if (data.Equals("OBSTACLE#"))
                    {
                        Console.WriteLine("OBSTACLE :( ");
                    }
                    else if (data.Equals("CELL_OCCUPIED#"))
                    {
                        Console.WriteLine("CELL_OCCUPIED#");
                    }
                    else if (data.Equals("DEAD#"))
                    {
                        Console.WriteLine("DEAD#");
                    }
                    else if (data.Equals("TOO_QUICK#"))
                    {
                        Console.WriteLine("TOO_QUICK#");
                    }
                    else if (data.Equals("INVALID_CELL#"))
                    {
                        Console.WriteLine("INVALID_CELL#");
                    }
                    else if (data.Equals("GAME_HAS_FINISHED#"))
                    {
                        Console.WriteLine("GAME_HAS_FINISHED#");
                    }
                    else if (data.Equals("GAME_NOT_STARTED_YET#"))
                    {
                        Console.WriteLine("GAME_NOT_STARTED_YET#");
                    }
                    else if (data.Equals("NOT_A_VALID_CONTESTANT#"))
                    {
                        Console.WriteLine("NOT_A_VALID_CONTESTANT#");
                    }

                }

                string[] lines = Regex.Split(data, ":");
                    com.Invoke(new Action(() =>
                    {
                        
                    }));
                streamRecieve.Close();
                listner.Stop();
                clientRecieve.Close();
            }
        }

        //this method would decode the information about the life packs recieved from the server
        private void decodeLifePacks(string data)
        {
            //L:<x>,<y>:<LT>#

            char[] delimeters = {':','#'};
            string[] lines = data.Split(delimeters);
            Console.WriteLine("Decoding lifepack locations");

            //L   <x>,<y>  <LT>

            char[] delimeters2 = {','};
            string[] location = lines[1].Split(delimeters2);

            //this would add the newly created life packs to the life packs list
            lifePacks.Add(new LifePack(Int32.Parse(location[0]), Int32.Parse(location[1]), 1+ (Int32.Parse(lines[2])/1000))); 
            
            //this adds the life packs to the life pack array 
            map[Int32.Parse(location[1]), Int32.Parse(location[0])] = "L";
            updateMap();
            printMap();
            
        }

        //this would decode the message stating the current status of the server
        private void decodeCurrentState(string data)
        {
            //G  P1;<x>,<y>;<Dir>;<shotes?>;<health>;<coins>;<points>   ....   P5;<x>,<y>;<Dir>;<shotes?>;<health>;<coins>;<points>         <x>,<y>,<damage>;   .....   <x>,<y>,<damage># 

            char[] delimeters = { ':', '#' };
            char[] delimeters2 = { ';' };
            char[] delimeters3 = { ',' };
            string[] lines = data.Split(delimeters);

            Console.WriteLine("Decoding current state");

            //this for loop would traverse throught the list of string which has details about the tanks
            //and would decode the details and update relevent tanks in the tank list
            for (int x = 1; x < numberOfTanks; x++)
            {
                string[] playerDetails = lines[x].Split(delimeters2);
                Console.WriteLine("Decoding player details");

                string name = playerDetails[0];
                string[] cordinates = playerDetails[1].Split(delimeters3);
                int xCor = Int32.Parse(cordinates[0]);
                int yCor = Int32.Parse(cordinates[1]);
                int dir = Int32.Parse(playerDetails[2]);
                int shots = Int32.Parse(playerDetails[3]);
                string health = playerDetails[4];
                int coins = Int32.Parse(playerDetails[5]);
                int points = Int32.Parse(playerDetails[6]);

                updateTanks();
                foreach (Player tank in tankList)
                {
                    if (tank.name.Equals(name))
                    {
                        tank.x = xCor;
                        tank.y = yCor;
                        tank.direction = dir;
                        tank.health = health;
                        tank.coins = coins;
                        tank.points = points;

                        if (map[tank.y, tank.x].Equals("C"))
                        {
                            foreach (CoinPack item in coinPacks)
                            {
                                if (item.x == tank.x && item.y == tank.y)
                                {
                                    item.time = -1;
                                }
                            }


                        }
                        else if (map[tank.y, tank.x].Equals("L"))
                        {
                            foreach (LifePack item in lifePacks)
                            {
                                if (item.x == tank.x && item.y == tank.y)
                                {
                                    item.time = -1;
                                }
                            }

                        }

                        map[tank.y, tank.x] = "T"; 

                    }
                }
            }

            //This section would decode the details about damage levels of bridge
            string damage = lines[numberOfTanks];
            string[] damageBricks = damage.Split(delimeters2);
            try
            {
                for (int y = 0; y < damageBricks.Length; y++)
                {
                    string[] dmg = damageBricks[y].Split(delimeters3);


                    int dmgX = Int32.Parse(dmg[0]);
                    int dmgY = Int32.Parse(dmg[1]);
                    int dmgInt = Int32.Parse(dmg[2]);

                    foreach (Brick brick in brickList)
                    {
                        if (brick.x == dmgX && brick.y == dmgY)
                        {
                            if (dmgInt == 0)
                            {
                                brick.damage = 0;
                            }
                            else if (dmgInt == 1)
                            {
                                brick.damage = 25;
                            }
                            else if (dmgInt == 2)
                            {
                                brick.damage = 50;
                            }
                            else if (dmgInt == 3)
                            {
                                brick.damage = 75;
                            }
                            else if (dmgInt == 4)
                            {
                                brick.damage = 100;
                                removeBrick();
                                map[brick.y, brick.x] = "_";
                            }

                        }
                    }
                }
            }
            catch (Exception e)
            {
                
            }

            updateMap();
            printMap();
        }

        //Needs to be implemented
        //This method should remove a brick from the current list
        private void removeBrick()
        {
            throw new NotImplementedException();
        }

        //this method would decode the locations of the coins and their values.
        private void decodeCoinLocations(string data)
        {
            //C:<x>,<y>:<LT>:<Val>#
            char[] delimeters = { ':', '#' };
            string[] lines = data.Split(delimeters);

            Console.WriteLine("Decoding coin locations");

            char[] delimeters2 = {','};
            string[] location = lines[1].Split(delimeters2);

            coinPacks.Add(new CoinPack(Int32.Parse(location[0]), Int32.Parse(location[1]),1+ (Int32.Parse(lines[2])/1000), Int32.Parse(lines[3])));
            map[Int32.Parse(location[1]), Int32.Parse(location[0])] = "C";

            updateMap();
            printMap();
        }

        //this method would decode data about obstavcles such as bricks, stones & water
        private void decodeObstacleLocations(string data)
        {
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    map[y, x] = "_";
                }
            }
            //I P1   <x>,<y>;<x>,<y>;<x>,<y>…..< x>,<y>    <x>,<y>;<x>,<y>;<x>,<y>…..<x>,<y>    <x>,<y>;<x>,<y>;<x>,<y>…..<x>,<y>#

            char[] delimeters = { ':', '#' };
            char[] delimeters2 = { ';' };
            char[] delimeters3 = { ',' };
            char[] delimeters4 = { ';', ',' };
            string[] lines = data.Split(delimeters);

            
            Console.WriteLine("Decoding obstacle locations");
            
            string bricksStr = lines[2];
            string stoneStr = lines[3];
            string waterStr = lines[4];

            string[] brickStrCordinates = bricksStr.Split(delimeters4);
            string[] stoneStrCordinates = stoneStr.Split(delimeters4);
            string[] waterStrCordinates = waterStr.Split(delimeters4);

            int xLoc = 0, yLoc = 0;
            numberOfBricks = brickStrCordinates.Length;
            for (int x = 0; x < brickStrCordinates.Length; x++)
            {
                
                if (x % 2 == 0)
                {
                    xLoc = Int32.Parse(brickStrCordinates[x]);
                }
                else
                {
                    yLoc = Int32.Parse(brickStrCordinates[x]);
                    brickList.Add(new Brick(yLoc, xLoc));
                    numberOfBricks += 1;
                    map[yLoc, xLoc] = "B";
                }
                
            }

            for (int x = 0; x < stoneStrCordinates.Length; x++)
            {
                
                if (x % 2 == 0)
                {
                    xLoc = Int32.Parse(stoneStrCordinates[x]);
                }
                else
                {

                    yLoc = Int32.Parse(stoneStrCordinates[x]);
                    
                    stoneList.Add(new Stone(yLoc, xLoc));
                    map[yLoc, xLoc] = "S";
                }
                
            }

            for (int x = 0; x < waterStrCordinates.Length; x++)
            {
                
                if (x % 2 == 0)
                {
                    xLoc = Int32.Parse(waterStrCordinates[x]);
                }
                else
                {
                    yLoc = Int32.Parse(waterStrCordinates[x]);
                    waterList.Add(new Water(yLoc, xLoc));
                    map[yLoc, xLoc] = "W";
                }
                
            }

            updateMap();
            printMap();
        }

        //this method decodes data about 
        private void decodeInitialPlayerLocations(string data)
        {
            // S:P0;0,0;0:P1;0,9;0#
            char[] delimeters = { ':', '#' };
            char[] delimeters2 = { ';' };
            char[] delimeters3 = { ',' };
            char[] delimeters4 = { ';', ',' };

            string[] lines = data.Split(delimeters);
            
            int numberOfPlayers = lines.Length - 1;
            numberOfTanks = numberOfPlayers;
            for (int x = 1; x<numberOfPlayers; x++)
            {
                // S  P0;0,0;0   P1;0,9;0
                string[] lines2 = lines[x].Split(delimeters2);
                string[] my_tankXY = lines2[1].Split(delimeters3);
                
                    string name = lines2[0];
                    int xLoc = Int32.Parse(my_tankXY[0]);
                    int yLoc = Int32.Parse(my_tankXY[1]);
                    int direction = Int32.Parse(lines2[2]);
                    tankList.Add(new Player(name,xLoc,yLoc,direction));
                    map[yLoc, xLoc] = "T";
                
            }
            
            Console.WriteLine("Decoding initial player locations");
            
            updateMap();
            printMap();

        }
        
        //return the list of coin packs
        public ArrayList getCoinPackArray()
        {
            return coinPacks;
        }
       
        //return the list of tanks
        public ArrayList getTankArray()
        {
            return tankList;
        }
       
        //return the list of life packs
        //this method would return the LifePackArray
        public ArrayList getLifePackArray()
        {
            return lifePacks;
        }

        //this method would return the current brick pack array
        public ArrayList getBrickArray()
        {
            return brickList;
        }

        //this method would return the current water location array
        public ArrayList getWaterArray()
        {
            return waterList;
        }

        //this method would return the stone array
        public ArrayList getStoneArray()
        {
            return stoneList;
        }

        
    }
}
