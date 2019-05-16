using System.Collections;
using System.Collections.Generic;
using System.IO;
using Assets.Script;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    public static string[] Team;
    public static int NumberOfTeam = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        Team = File.ReadAllLines(@"C:\Users\karagosha\Documents\ManagerProject\Assets\info\team.txt");
    }

    // Update is called once per frame
    void Update()
    {
        
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
