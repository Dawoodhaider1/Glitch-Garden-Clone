using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public float AutoLoadNextLevel = 3.0f;

    public void Start()
    {
        if(AutoLoadNextLevel == 0)
        {
            Debug.Log("AutoLoad deactivated !");
        }
        else
        {
            Invoke("LoadNextRequest", AutoLoadNextLevel);
        }
    }

    public void LoadRequest(string name)
    {
        Debug.Log("Load request called for: " + name);
        SceneManager.LoadScene(name);
    }
    public void QuitRequest()
    {
        Debug.Log("Exit from the game! ");
        Application.Quit();
    }
    public void BackRequest(string name1)
    {
        Debug.Log("Back to Start Page!" + name1);
        SceneManager.LoadScene(name1);
    }
    public void LoadNextRequest()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
    }
    
}
