﻿    using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    void OnGUI()
    {

        if (GUI.Button(new Rect(Screen.width / 2-50, Screen.height / 2-50, 100, 25), "Выбор команды"))
        {
            SceneManager.LoadScene("Settings");
        }
        if (GUI.Button(new Rect(Screen.width / 2-50, Screen.height / 2, 100, 25), "Выход"))
        {
            Application.Quit();

        }

    } 
}
