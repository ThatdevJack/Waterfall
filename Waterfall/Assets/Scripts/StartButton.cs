using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{

    public string sceneName;

    public void OnMouseClick()
    {





        SceneManager.LoadScene(sceneName);



    }

    public void AdventureMouseClick()
    {
        if(PlayerPrefs.GetInt("playedAdventure") == 1)
        {
            string savedScene = PlayerPrefs.GetString("LoadScene");
            SceneManager.LoadScene(savedScene);
        }
        else
        {
            OnMouseClick();
        }
    }
}
