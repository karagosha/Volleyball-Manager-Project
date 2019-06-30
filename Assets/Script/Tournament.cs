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

        public List<String> GroupResult= new List<String>(4) { null, null, null, null };

        public List<String> FinalResults= new List<String>(2) { null, null };

        public static List<Team> Winner = new List<Team>(1) { null };

        public List<String> WinResult = new List<String>(1) { null };

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

        public void GenerateRoundOfTournament()
        {
            switch (StepOfTounament)
            {
                case 0:
                    SemiFinalTeams = getResult(GroupTeams);
                    StepOfTounament++;
                    break;
                case 1:
                    FinalTeams = getResult(SemiFinalTeams);
                    StepOfTounament++;
                    break;
                case 2:
                    Winner = getResult(FinalTeams);
                    StepOfTounament++;
                    break;
            }
        }

        private List<Team> getResult(List<Team> list)
        {
            List<Team> resultList= new List<Team>(list.Count/2);
           
            for (int i = 0; i < list.Count; i++)
            {
                resultList.Add(GenerateGame(list[i], list[i++]));
            }
            
            return resultList;
        }

        private Team GenerateGame(Team team1, Team team2)
        {
            int team1Points = 0, team2Points = 0;
            do
            {
                team1Points += PoissonExp(team1.TeamPower, team1.boost);
                team2Points += PoissonExp(team2.TeamPower, team2.boost);
            } while ((team1Points < 25 && team2Points < 25)  /*Math.Abs(team1Points - team2Points) <= 2*/);

                team1.LastReasult = team1Points.ToString() + "/" + team2Points.ToString();
            team2.LastReasult = team1Points.ToString() + "/" + team2Points.ToString();
            if (team1Points > team2Points)
            {
                team1.CountOfGames++;
                team1.WinStats++;
                team2.CountOfGames++;
                team2.LoseStats++;
                return team1;
            }
            else
            {
                team2.CountOfGames++;
                team2.WinStats++;
                team1.CountOfGames++;
                team1.LoseStats++;
                return team2;
            }
                

        }

        private int PoissonExp(double teamPower, double boost)
        {
            double rate = 0.2;//плотность распределния
            int k = -1;
            double s = 0;
            while (s < rate)
            {
                s += exp(1) + (teamPower+boost)/20;
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
