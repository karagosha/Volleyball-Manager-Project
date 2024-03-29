﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Script;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.UI;

public class Statistic : MonoBehaviour
{
    public Text WinnerName;


    Team Team;

    void OnGUI()
    {
        WinnerName.text= Tournament.Winner[0].Name;
        
        GUI.Label(new Rect(Screen.width / 2 -300, Screen.height / 2 , 150, 50), 
            Tournament.Winner[0].WinStats.ToString() + '/' + Tournament.Winner[0].LoseStats.ToString());

        for (int i = 0; i < Tournament.Winner[0].Players.Count; i++)// список инроков победившей команды
        {
            GUI.Label(new Rect(Screen.width / 2 + 200, Screen.height / 2 -100 + 40*i, 150, 30), Tournament.Winner[0].Players[i].Name);
            GUI.Label(new Rect(Screen.width / 2 + 200, Screen.height / 2 - 125 + 40*i, 150, 30), Tournament.Winner[0].Players[i].Role);
        }

        if(GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height / 2 + 200, 300, 50), "Начать заново"))
        {
            SceneManager.LoadScene("Menu");
        }

    }
}
