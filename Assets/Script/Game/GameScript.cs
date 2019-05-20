using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Script;
using UnityEngine.SceneManagement;


public class  GameScript : MonoBehaviour
{
    Team MyTeam;

    Tournament Tournament;

    Team curTeam;
   
    // Start is called before the first frame update
    void Start()
    {
        Tournament = new Tournament(Settings.Team);
        Tournament.ShuffleGroup();
    }
    
   
    

    void OnGUI()
    {


        if (GUI.Button(new Rect(Screen.width / 2 - 75 + 100, Screen.height / 2 - 25, 150, 50), IsTeam(Tournament.FinalTeams[0])))
        {
            //SceneManager.LoadScene("Statistic");
            curTeam = Tournament.FinalTeams[0];
        }
        if (GUI.Button(new Rect(Screen.width / 2 - 75 - 100, Screen.height / 2 - 25, 150, 50), IsTeam(Tournament.FinalTeams[1])))
        {
            //SceneManager.LoadScene("Statistic");
            curTeam = Tournament.FinalTeams[1];
        }

        if (GUI.Button(new Rect(Screen.width / 2 - 75 - 250, Screen.height / 2 - 25 - 150, 150, 50), IsTeam(Tournament.SemiFinalTeams[0])))
        {
            //SceneManager.LoadScene("Statistic");
            curTeam = Tournament.SemiFinalTeams[0];
        }
        if (GUI.Button(new Rect(Screen.width / 2 - 75 + 250, Screen.height / 2 - 25 - 150, 150, 50), IsTeam(Tournament.SemiFinalTeams[1])))
        {
            //SceneManager.LoadScene("Statistic");
            curTeam = Tournament.SemiFinalTeams[1];
        }
        if (GUI.Button(new Rect(Screen.width / 2 - 75 + 250, Screen.height / 2 - 25 + 150, 150, 50), IsTeam(Tournament.SemiFinalTeams[2])))
        {
            //SceneManager.LoadScene("Statistic");
            curTeam = Tournament.SemiFinalTeams[2];
        }
        if (GUI.Button(new Rect(Screen.width / 2 - 75 - 250, Screen.height / 2 - 25 + 150, 150, 50), IsTeam(Tournament.SemiFinalTeams[3])))
        {
            //SceneManager.LoadScene("Statistic");
            curTeam = Tournament.SemiFinalTeams[3];
        }

        if (GUI.Button(new Rect(Screen.width / 2 - 75 + 400, Screen.height / 2 - 25 - 225, 150, 50), IsTeam(Tournament.GroupTeams[0])))
        {
            //SceneManager.LoadScene("Statistic");
            curTeam = Tournament.GroupTeams[0];
        }
        if(GUI.Button(new Rect(Screen.width / 2 - 75 - 400, Screen.height / 2 - 25 - 225, 150, 50), IsTeam(Tournament.GroupTeams[1])))
        {
            //SceneManager.LoadScene("Statistic");
            curTeam = Tournament.GroupTeams[1];
        }
        if(GUI.Button(new Rect(Screen.width / 2 - 75 + 400, Screen.height / 2 - 25 + 225, 150, 50), IsTeam(Tournament.GroupTeams[2])))
        {
            //SceneManager.LoadScene("Statistic");
            curTeam = Tournament.GroupTeams[2];
        }
        if(GUI.Button(new Rect(Screen.width / 2 - 75 - 400, Screen.height / 2 - 25 + 225, 150, 50), IsTeam(Tournament.GroupTeams[3])))
        {
            //SceneManager.LoadScene("Statistic");
            curTeam = Tournament.GroupTeams[3];
        }

        if(GUI.Button(new Rect(Screen.width / 2 - 75 + 400, Screen.height / 2 - 25 - 75, 150, 50), IsTeam(Tournament.GroupTeams[4])))
        {
            //SceneManager.LoadScene("Statistic");
            curTeam = Tournament.GroupTeams[4];
        }
        if(GUI.Button(new Rect(Screen.width / 2 - 75 - 400, Screen.height / 2 - 25 - 75, 150, 50), IsTeam(Tournament.GroupTeams[5])))
        {
            //SceneManager.LoadScene("Statistic");
            curTeam = Tournament.GroupTeams[5];
        }
        if(GUI.Button(new Rect(Screen.width / 2 - 75 + 400, Screen.height / 2 - 25 + 75, 150, 50), IsTeam(Tournament.GroupTeams[6])))
        {
            //SceneManager.LoadScene("Statistic");
            curTeam = Tournament.GroupTeams[6];
        }
        if(GUI.Button(new Rect(Screen.width / 2 - 75 - 400, Screen.height / 2 - 25 + 75, 150, 50), IsTeam(Tournament.GroupTeams[7])))
        {
            //SceneManager.LoadScene("Statistic");
            curTeam = Tournament.GroupTeams[7];
        }

        if (GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height / 2 + 200, 300, 50), "Начать следующий раунд"))
        {
            //SceneManager.LoadScene("Game");
        }
        
    }

    private string IsTeam(Team curTeam)
    {
        if(curTeam == null)
        {
            return "Не определен";
        }
        else
        {
            return curTeam.Name;
        }
    }

}
