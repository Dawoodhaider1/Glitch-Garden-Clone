using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraveStone : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Attackers attackers = collision.gameObject.GetComponent<Attackers>();

        if (attackers)
        {
            animator.SetTrigger("UnderAttack Trigger");
        }
    }
}
