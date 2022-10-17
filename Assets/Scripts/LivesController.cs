using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesController : MonoBehaviour
{
    public GameObject heart1, heart2, heart3;
    public static int Life;
    // Start is called before the first frame update
    void Start()
    {
        Life = 3;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
        //gameOver.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Life > 3)
        {
            Life = 3;
        }

        switch (Life)
        {
            case 3:
                {
                    heart1.gameObject.SetActive(true);
                    heart2.gameObject.SetActive(true);
                    heart3.gameObject.SetActive(true);
                    break;
                }
            case 2:
                {
                    heart1.gameObject.SetActive(true);
                    heart2.gameObject.SetActive(true);
                    heart3.gameObject.SetActive(false);
                    break;
                }
            case 1:
                {
                    heart1.gameObject.SetActive(true);
                    heart2.gameObject.SetActive(false);
                    heart3.gameObject.SetActive(false);
                    break;
                }
            case 0:
                {
                    heart1.gameObject.SetActive(false);
                    heart2.gameObject.SetActive(false);
                    heart3.gameObject.SetActive(false);
                    Debug.Log("Game Over!");
                    break;
                }

        }
    }
}
