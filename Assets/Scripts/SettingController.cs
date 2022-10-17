using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingController : MonoBehaviour
{
    public Slider VolumeSlider;
    public Slider DifficultySlider;
    public LevelManager levelManager;

    private MusicManager musicManager;
    // Start is called before the first frame update
    void Start()
    {
        musicManager = GameObject.FindObjectOfType<MusicManager>();
        VolumeSlider.value = PlayerPrefsManager.GetMasterVolume();
        DifficultySlider.value = PlayerPrefsManager.GetDifficulty();
    }

    // Update is called once per frame
    void Update()
    {
        musicManager.SetVolume(VolumeSlider.value);
    }

    public void SaveAndExit()
    {
        PlayerPrefsManager.SetMasterVolume(VolumeSlider.value);
        PlayerPrefsManager.SetDifficulty(DifficultySlider.value);
        levelManager.LoadRequest("Start");
    }

    public void SetDefaults ()
    {
        VolumeSlider.value = 0.75f;
        DifficultySlider.value = 2f;
    }
}
