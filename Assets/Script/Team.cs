using Assets.info;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

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
        public Int32 WinStats, LoseStats, CountOfGames;
        public double TeamPower = 0;
        public String LastReasult = "";
        public double boost = 0;
        public void AddPlayers()// Инизиализация игроков команды
        {
            string path = Application.dataPath + "/info/" + this.Name.ToString() + ".txt";
            string[] lines = File.ReadAllLines(path);
            this.CountOfGames = Convert.ToInt32(lines[0]);
            this.WinStats = Convert.ToInt32(lines[1]);
            this.LoseStats = Convert.ToInt32(lines[2]);
            TeamPower =(double) WinStats / CountOfGames;
            for (int i = 3; i < 23; i+=2)
            {
                this.Players.Add(new Player(lines[i], lines[i+1], this));
            }
        }
    }
}
