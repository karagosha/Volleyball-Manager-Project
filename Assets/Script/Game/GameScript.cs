using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Script;

public class GameScript : MonoBehaviour
{
    Team MyTeam;

    Tournament Tournament;
   
    // Start is called before the first frame update
    void Start()
    {
        Tournament = new Tournament(Settings.Team);
        Tournament.ShuffleGroup();
    }
    
    // Update is called once per frame
    void Update()
    {

    }

    

    void OnGUI()
    {
        

        if(GUI.Button(new Rect(Screen.width / 2 - 75 + 100, Screen.height / 2 - 25, 150, 50),  "te")){}
        if(GUI.Button(new Rect(Screen.width / 2 - 75 - 100, Screen.height / 2 - 25, 150, 50), "Не определен")){}

        if(GUI.Button(new Rect(Screen.width / 2 - 75 - 250, Screen.height / 2 - 25 - 150, 150, 50), "Не определен")){}
        if(GUI.Button(new Rect(Screen.width / 2 - 75 + 250, Screen.height / 2 - 25 - 150, 150, 50), "Не определен")){}
        if(GUI.Button(new Rect(Screen.width / 2 - 75 + 250, Screen.height / 2 - 25 + 150, 150, 50), "Не определен")){}
        if(GUI.Button(new Rect(Screen.width / 2 - 75 - 250, Screen.height / 2 - 25 + 150, 150, 50), "Не определен")){}

        if(GUI.Button(new Rect(Screen.width / 2 - 75 + 400, Screen.height / 2 - 25 - 225, 150, 50), "Не определен")){}
        if(GUI.Button(new Rect(Screen.width / 2 - 75 - 400, Screen.height / 2 - 25 - 225, 150, 50), "Не определен")){}
        if(GUI.Button(new Rect(Screen.width / 2 - 75 + 400, Screen.height / 2 - 25 + 225, 150, 50), "Не определен")){}
        if(GUI.Button(new Rect(Screen.width / 2 - 75 - 400, Screen.height / 2 - 25 + 225, 150, 50), "Не определен")){}

        if(GUI.Button(new Rect(Screen.width / 2 - 75 + 400, Screen.height / 2 - 25 - 75, 150, 50), "Не определен")){}
        if(GUI.Button(new Rect(Screen.width / 2 - 75 - 400, Screen.height / 2 - 25 - 75, 150, 50), "Не определен")){}
        if(GUI.Button(new Rect(Screen.width / 2 - 75 + 400, Screen.height / 2 - 25 + 75, 150, 50), "Не определен")){}
        if(GUI.Button(new Rect(Screen.width / 2 - 75 - 400, Screen.height / 2 - 25 + 75, 150, 50), "Не определен")){}
        
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
