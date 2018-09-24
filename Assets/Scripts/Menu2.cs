using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu2 : MonoBehaviour {

    void OnGUI()
    {
        if(GUI.Button(new Rect(20, Screen.height / 2 + Screen.height / 4, 100, 50), "Menu"))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
