using System.Collections;
using System.Collections.Generic;
using System.IO;
using Assets.Script;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    public static string[] Team;// список всех комнанд
    public static int NumberOfTeam = 0;//номер выбранной команды

    string path;
    // Start is called before the first frame update
    void Start()
    {
        path = Application.dataPath + "/info/team.txt";
        Team = File.ReadAllLines(path);// загрузка команд из файла
    }
    void OnGUI()
    {
        
        NumberOfTeam = GUI.SelectionGrid(new Rect(Screen.width / 2 - 150, Screen.height / 2 -175 , 300, 300), NumberOfTeam, Team, 1);

        if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 175, 100, 25), "Готов"))
        {

            SceneManager.LoadScene("Game");
        }
    }
}
