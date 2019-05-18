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
                Teams.Add(new Team(item, "Russia"));  
           }
        }

        public List<Team> FinalTeams = new List<Team>(2);

        public List<Team> SemiFinalTeams = new List<Team>(4);

        public List<Team> GroupTeams = new List<Team>(8);

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

        public void GenerateGame(Team team1, Team team2)
        {
            double lyambda = 4;
            Int32 time = 0;
            time = time + exp(lyambda);
            Int32 u = Uniform(0, lyambda);
            if (lyambda > u) 
            {

            }
                           
        }

        private int Uniform(int v, double lyambda)
        {
            throw new NotImplementedException();
        }

        private int exp(double lyambda)
        {
            throw new NotImplementedException();
        }
    }
}
