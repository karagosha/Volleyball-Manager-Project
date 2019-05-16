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
        int StepOfTounament = 0;

        public void CreateTeams(String[] teams)
        {
            
           foreach( var item in teams)
           {
                Teams.Add(new Team(item, "Russia"));  
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
