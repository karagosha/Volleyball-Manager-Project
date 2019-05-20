using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Script
{
    class Tournament
    {
        public Tournament(String[] teams)
        {
            CreateTeams(teams);
        }

        List<Team> Teams = new List<Team>();
        public int StepOfTounament = 0;

        public void CreateTeams(String[] teams)
        {
            
           foreach( var item in teams)
           {
                var x = new Team(item, "Russia");
                Teams.Add(x);
                x.AddPlayers();

           }
        }

        public List<Team> FinalTeams = new List<Team>(2) { null, null };

        public List<Team> SemiFinalTeams = new List<Team>(4) { null, null, null, null };

        public List<Team> GroupTeams = new List<Team>(8) { null, null, null, null, null, null, null, null };

        public void ShuffleGroup()
        {
            Random random = new Random();
            Int32 n = Teams.Count;
            GroupTeams = Teams;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Team val = GroupTeams[k];
                GroupTeams[k] = GroupTeams[n];
                GroupTeams[n] = val;
            }
        }

        public Team GenerateGame(Team team1, Team team2)
        {
            int team1Points = 0, team2Points = 0;
            while ((team1Points > 25 || team2Points > 25)&& Math.Abs(team1Points-team2Points)>=2) 
            {
                PoissonExp(team1.TeamPower);
                PoissonExp(team2.TeamPower);
            }

            if (team1Points > team2Points)
                return team1;
            else
                return team2;

        }

        public int PoissonExp(double teamPower)
        {
            double rate = 2;//плотность распределния
            int k = -1;
            double s = 0;
            while (s < rate)
            {
                s += exp(1);
                ++k;
            }
            return k;

        }


        private double exp(double lyambda)
        {
            return Math.Log(r()) / lyambda * (-1.0);
        }
        Random rand = new Random();
        public double r()
        {
            return rand.NextDouble();
        }
    }
}
