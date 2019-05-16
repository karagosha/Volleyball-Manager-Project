using Assets.info;
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

        public List<Player> Players;
        String Name, Country;
        Int32 WinStats, LoseStats, CountOfGames;
        public void AddPlayers()
        {
            string[] players = File.ReadAllLines(@"C:\Users\karagosha\Documents\ManagerProject\Assets\info\" + this.Name.ToString());
            CountOfGames = Convert.ToInt32(players[0]);
            WinStats = Convert.ToInt32(players[1]);
            LoseStats = Convert.ToInt32(players[2]);
            for (int i = 3; i < players.Length; i++)
            {
                Players.Add(new Player(players[i], players[i++], this));
            }
        }
    }
}
