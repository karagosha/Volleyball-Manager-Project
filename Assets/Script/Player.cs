using Assets.Script;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.info
{
    class Player
    {
        public Player(String name, String role, Team team)
        {
            this.Name = name;
            this.Role = role;
            this.Team = team;
        }
        Team Team;
        int CountOfGoal = 0;
        String Name;
        String Role;
    }
}
