using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    public GameObject projectile;
    public GameObject gun;
    private GameObject projectileParent;
    private Animator animator;
    private Spawner myLaneSpawner;
    // Start is called before the first frame update

    private void Fire()
    {
        GameObject newProjectile = Instantiate(projectile) as GameObject;
        newProjectile.transform.parent = projectileParent.transform;
        newProjectile.transform.position = gun.transform.position;
    }
    void Start()
    {
        animator = GameObject.FindObjectOfType<Animator>();
        projectileParent = GameObject.Find("Projectiles");

        if (!(projectileParent))
        {
            projectileParent = new GameObject("Projectiles");
        }
        SetMyLaneSpawner();
    }

    // Update is called once per frame
    void Update()
    {
        if(IsAttackerAheadInLane())
        {
            animator.SetBool("IsAttacking", true); 
        }
        else
        {
            animator.SetBool("IsAttacking", false);
        }
    }

    bool IsAttackerAheadInLane()
    {
        //Exit if no attackers in lane
        if(myLaneSpawner.transform.childCount <= 0)
        {
            return false;
        }
        //if there are attackers in the lane

        foreach (Transform attackers in myLaneSpawner.transform)
        {
            if(attackers.transform.position.x > transform.position.x)
            {
                return true;
            }
        }
        //Attacker in the lane but behind.  
        return false;
    }

    void SetMyLaneSpawner()
    {
        Spawner[] spawnerArray1 = GameObject.FindObjectsOfType<Spawner>();

        foreach(Spawner spawner in spawnerArray1)
        {
            if(spawner.transform.position.y == transform.position.y)
            {
                myLaneSpawner = spawner;
                return;
            }
        }
        Debug.LogError(name + " can't find spawner in the Lane");
    }
}
