using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]
public class Attackers : MonoBehaviour
{
    public float health = 200f;
    [Tooltip ("Average number of seconds between appreances")]
    public float SeenEverySeconds;

    private float CurrentSpeed;
    private GameObject currentDefender;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        transform.Translate(Vector3.left * CurrentSpeed * Time.deltaTime);
        if(!(currentDefender))
        {
            animator.SetBool("IsAttacking", false); 
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log(name + "Collider is called !");
    }

    public void WalkingSpeed(float speed)
    {
        CurrentSpeed = speed;
    }

    public void AttackingCurrentDefender(float damage)
    {
        if(currentDefender)
        {
            Health health = currentDefender.GetComponent<Health>();
            
            if(health)
            {
                health.DealDamage(damage);
            }

        }
        Debug.Log(name + " Collision occured" + damage);
    }

    public void attack(GameObject obj)
    {
        currentDefender = obj;
    }

}
