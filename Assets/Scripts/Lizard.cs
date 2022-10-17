using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Attackers))]
public class Lizard : MonoBehaviour
{

    private Animator animator;
    private Attackers attacker;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        attacker = GetComponent<Attackers>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        GameObject obj = collision.gameObject;

        //Leave the method as it is, if not colliding with any defender...
        if (!(obj.GetComponent<Defenders>()))
        {
            return;
        }
        else
        {
            animator.SetBool("IsAttacking", true);
            attacker.attack(obj);
        }

        Debug.Log("The Lizard Collided with the current Defender !");

    }
}
