using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    public float FadeInTime;

    private Image imagefade;
    private Color currentcolor = Color.black;

    // Start is called before the first frame update
    void Start()
    {
        imagefade = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad < FadeInTime)
        {
            float AlphaChange = Time.deltaTime / FadeInTime;
            currentcolor.a -= AlphaChange;
            imagefade.color = currentcolor;
            Debug.Log("Fade In Activated!");
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
