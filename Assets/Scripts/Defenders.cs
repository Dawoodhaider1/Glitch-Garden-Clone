using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defenders : MonoBehaviour
{
    private StarDisplay starDisplay;
    public int starCost = 100;

    public void AddStars(int amount)
    {
        starDisplay.AddStars(amount);
    }
    // Start is called before the first frame update
    void Start()
    {
        starDisplay = GameObject.FindObjectOfType<StarDisplay>();
    }

}
