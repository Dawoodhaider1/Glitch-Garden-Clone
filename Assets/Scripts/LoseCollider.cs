using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour
{
    private int maxCollisions = 0;

    private LevelManager levelManager;


    void OnTriggerEnter2D(Collider2D collision)
    {
        maxCollisions++;
        LivesController.Life -= 1;
        levelManager = GameObject.FindObjectOfType<LevelManager>();

        if (maxCollisions >= 3)
        {
            levelManager.LoadRequest("Lose");
        }
    }
}
