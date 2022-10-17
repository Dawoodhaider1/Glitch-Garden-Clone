using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof(Text))]
public class StarDisplay : MonoBehaviour
{
    private int starCost = 10;
    private Text starText;
    private int stars = 1000;

    public enum Status { SUCCESS, FAILURE };
    // Start is called before the first frame update
    void Start()
    {
        starText = GetComponent<Text>();
        UpdateDisplay();
    }

    public void AddStars(int amount)
    {
        stars += amount;
        UpdateDisplay();
    }

    public Status UseStars(int amount)
    {
        if(stars >= amount)
        {
            stars -= amount;
            UpdateDisplay();
            return Status.SUCCESS;
        }
        else
        {
            return Status.FAILURE;
        }
    }

    private void UpdateDisplay()
    {
        starText.text = stars.ToString();
    }
}
