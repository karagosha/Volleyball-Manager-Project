﻿using Assets.info;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Script
{
    class Team
    {
        public Team(String name, String country)
        {
            this.Name = name;
            this.Country = country;
        }

        public List<Player> Players= new List<Player>(10);
        public String Name, Country;
        Int32 WinStats, LoseStats, CountOfGames;

        public void AddPlayers()
        {
            string[] lines = File.ReadAllLines(@"C:\Users\karagosha\Documents\VolleballMan\Assets\info\" + this.Name.ToString()+".txt");
            this.CountOfGames = Convert.ToInt32(lines[0]);
            this.WinStats = Convert.ToInt32(lines[1]);
            this.LoseStats = Convert.ToInt32(lines[2]);
            for (int i = 3; i < 13/*countOfplayers*/; i++)
            {
                this.Players.Add(new Player(lines[i], lines[i++], this));
            }
        }
    }
}
