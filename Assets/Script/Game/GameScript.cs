
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Script;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameScript : MonoBehaviour
{

    public GameObject MainGameObject;

    public GameObject gameObject ;

    Team MyTeam;

    Tournament Tournament;

    Team curTeam;

    //Start is called before the first frame update
    void Start()
    {
        Tournament = new Tournament(Settings.Team);
        Tournament.ShuffleGroup();
        

    }

    private bool MainIsActive = true;   


    void OnGUI()
    {

        if (MainIsActive)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 75 + 100, Screen.height / 2 - 25, 150, 50), IsTeam(Tournament.FinalTeams[1])))
            {
                if (Tournament.FinalTeams[1] != null)
                {
                    gameObject.gameObject.SetActive(true);
                    MainGameObject.gameObject.SetActive(false);
                    MainIsActive = false;
                    curTeam = Tournament.FinalTeams[1];
                }
            }
            if ( GUI.Button(new Rect(Screen.width / 2 - 75 - 100, Screen.height / 2 - 25, 150, 50), IsTeam(Tournament.FinalTeams[0])))
            {
                if (Tournament.FinalTeams[0] != null)
                {
                    gameObject.gameObject.SetActive(true);
                    MainGameObject.gameObject.SetActive(false);
                    MainIsActive = false;
                    curTeam = Tournament.FinalTeams[0];
                }
            }

            if ( GUI.Button(new Rect(Screen.width / 2 - 75 - 250, Screen.height / 2 - 25 - 150, 150, 50), IsTeam(Tournament.SemiFinalTeams[0])))
            {
                if (Tournament.SemiFinalTeams[0] != null)
                {
                    gameObject.gameObject.SetActive(true);
                    MainGameObject.gameObject.SetActive(false);
                    MainIsActive = false;
                    curTeam = Tournament.SemiFinalTeams[0];
                }
            }
            
            if ( GUI.Button(new Rect(Screen.width / 2 - 75 + 250, Screen.height / 2 - 25 - 150, 150, 50), IsTeam(Tournament.SemiFinalTeams[2])))
            {
                if (Tournament.SemiFinalTeams[2] != null)
                {
                    gameObject.gameObject.SetActive(true);
                    MainGameObject.gameObject.SetActive(false);
                    MainIsActive = false;
                    curTeam = Tournament.SemiFinalTeams[2];
                }
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 75 + 250, Screen.height / 2 - 25 + 150, 150, 50), IsTeam(Tournament.SemiFinalTeams[3])))
            {
                if (Tournament.FinalTeams[3] != null)
                {
                    gameObject.gameObject.SetActive(true);
                    MainGameObject.gameObject.SetActive(false);
                    MainIsActive = false;
                    curTeam = Tournament.SemiFinalTeams[3];
                }
            }
            if ( GUI.Button(new Rect(Screen.width / 2 - 75 - 250, Screen.height / 2 - 25 + 150, 150, 50), IsTeam(Tournament.SemiFinalTeams[1])))
            {
                if (Tournament.FinalTeams[1] != null)
                {
                    gameObject.gameObject.SetActive(true);
                    curTeam = Tournament.SemiFinalTeams[1];
                    MainGameObject.gameObject.SetActive(false);
                    MainIsActive = false;
                }
            }

            if ( GUI.Button(new Rect(Screen.width / 2 - 75 + 400, Screen.height / 2 - 25 - 225, 150, 50), IsTeam(Tournament.GroupTeams[4])))
            {
                if (Tournament.GroupTeams[4] != null)
                {
                    gameObject.gameObject.SetActive(true);
                    MainGameObject.gameObject.SetActive(false);
                    MainIsActive = false;
                    curTeam = Tournament.GroupTeams[4];
                }
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 75 - 400, Screen.height / 2 - 25 - 225, 150, 50), IsTeam(Tournament.GroupTeams[0])))
            {
                if (Tournament.GroupTeams[0] != null)
                {
                    gameObject.gameObject.SetActive(true);
                    MainGameObject.gameObject.SetActive(false);
                    MainIsActive = false;
                    curTeam = Tournament.GroupTeams[0];
                }
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 75 + 400, Screen.height / 2 - 25 + 225, 150, 50), IsTeam(Tournament.GroupTeams[7])))
            {
                if (Tournament.GroupTeams[7] != null)
                {
                    gameObject.gameObject.SetActive(true);
                    MainGameObject.gameObject.SetActive(false);
                    MainIsActive = false;
                    curTeam = Tournament.GroupTeams[7];
                }
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 75 - 400, Screen.height / 2 - 25 + 225, 150, 50), IsTeam(Tournament.GroupTeams[3])))
            {
                if (Tournament.GroupTeams[3] != null)
                {
                    gameObject.gameObject.SetActive(true);
                    MainGameObject.gameObject.SetActive(false);
                    MainIsActive = false;
                    curTeam = Tournament.GroupTeams[3];
                }
            }

            if ( GUI.Button(new Rect(Screen.width / 2 - 75 + 400, Screen.height / 2 - 25 - 75, 150, 50), IsTeam(Tournament.GroupTeams[5])))
            {
                if (Tournament.GroupTeams[5] != null)
                {
                    gameObject.gameObject.SetActive(true);
                    MainGameObject.gameObject.SetActive(false);
                    MainIsActive = false;
                    curTeam = Tournament.GroupTeams[5];
                }
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 75 - 400, Screen.height / 2 - 25 - 75, 150, 50), IsTeam(Tournament.GroupTeams[1])))
            {
                if (Tournament.GroupTeams[1] != null)
                {
                    gameObject.gameObject.SetActive(true);
                    MainGameObject.gameObject.SetActive(false);
                    MainIsActive = false;
                    curTeam = Tournament.GroupTeams[1];
                }
            }
            if ( GUI.Button(new Rect(Screen.width / 2 - 75 + 400, Screen.height / 2 - 25 + 75, 150, 50), IsTeam(Tournament.GroupTeams[6])))
            {
                if (Tournament.GroupTeams[6] != null)
                {
                    gameObject.gameObject.SetActive(true);
                    MainGameObject.gameObject.SetActive(false);
                    MainIsActive = false;
                    curTeam = Tournament.GroupTeams[6];
                }
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 75 - 400, Screen.height / 2 - 25 + 75, 150, 50), IsTeam(Tournament.GroupTeams[2])))
            {
                if (Tournament.GroupTeams[2] != null)
                {
                    gameObject.gameObject.SetActive(true);
                    MainGameObject.gameObject.SetActive(false);
                    MainIsActive = false;
                    curTeam = Tournament.GroupTeams[2];
                }
            }

            if (GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height / 2 + 200, 300, 50), "Начать следующий раунд"))
            {
                if (Tournament.StepOfTounament == 3)
                {
                    SceneManager.LoadScene("Statistic");
                }
                Tournament.GenerateRoundOfTournament();
            }
        }
        else
        {
            GUI.Label(new Rect(Screen.width / 2 - 300, Screen.height / 2 +50, 300, 50), curTeam.boost.ToString());

            GUI.Label(new Rect(Screen.width / 2 - 150, Screen.height / 2 - 200, 300, 50), curTeam.Name);

            GUI.Label(new Rect(Screen.width / 2 - 300, Screen.height / 2, 150, 50),
                curTeam.WinStats.ToString() + '/' + curTeam.LoseStats.ToString());

            for (int i = 0; i < curTeam.Players.Count; i++)
            {
                GUI.Label(new Rect(Screen.width / 2 + 200, Screen.height / 2 - 140 + 30 * i, 250, 30), curTeam.Players[i].Name);
                GUI.Label(new Rect(Screen.width / 2 + 200, Screen.height / 2 - 105 + 30 * i, 150, 30), curTeam.Players[i].Role);
            }

            if (GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height / 2 + 200, 300, 50), "Назад"))
            {
                gameObject.gameObject.SetActive(false);
                MainGameObject.gameObject.SetActive(true);
                MainIsActive = true;
            }
            //if(curTeam.Name == MyTeam.Name)
            //{
                if(GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height / 2 + 150, 300, 50), "Boost"))
                {
                    if (curTeam.boost < 1)
                        curTeam.boost += 0.25;
                }
            //}

        }

    }

    private string IsTeam(Team curTeam)
    {
        if (curTeam == null)
        {
            return "Не определен";
        }
        else
        {
            return (curTeam.Name + curTeam.LastReasult);
        }
    }

}