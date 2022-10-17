using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMusicVolume : MonoBehaviour
{
    private MusicManager musicManager;

    // Start is called before the first frame update
    void Start()
    {
        musicManager = GameObject.FindObjectOfType<MusicManager>(); 

        if(musicManager)
        {
            Debug.Log("Music Manager Found !" + musicManager);
            float Volume = PlayerPrefsManager.GetMasterVolume();
            musicManager.SetVolume(Volume);
        }
        else
        {
            Debug.LogWarning("There is no music Manager in the start scene, so cannot set the volume");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
