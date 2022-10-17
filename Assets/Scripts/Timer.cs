using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float levelSeconds = 100;

    //public float secondsLeft;
    //public Attackers attacker;
    private Slider slider;
    private AudioSource audioSource;
    private bool IsEndOfLevel = false;
    private LevelManager levelManager;
    private GameObject WinLabel;
    private AttackerHealth attackerHealth;


    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        //secondsLeft = levelSeconds;
        audioSource = GetComponent<AudioSource>();
        levelManager = GameObject.FindObjectOfType<LevelManager>();
        attackerHealth = GameObject.FindObjectOfType<AttackerHealth>();
        //attacker = GameObject.FindObjectOfType<Attackers>();

        WinLabel = GameObject.Find("You Win");
        if(!(WinLabel))
        {
            Debug.LogWarning("Win Label Not Accessible !");
        }
        WinLabel.SetActive(false);
    }

    // Update is called once per frame
    public void Update()
    {
        
        //slider.value = attackerHealth.progress;

        if (slider.value >=levelSeconds && !(IsEndOfLevel))
        {
            audioSource.Play();
            WinLabel.SetActive(true);
            Invoke("LoadNextLevel", audioSource.clip.length);
            IsEndOfLevel = true;
        }
    }

    public void LoadNextLevel()
    {
        levelManager.LoadNextRequest();
    }
}
