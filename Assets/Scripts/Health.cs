using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public float health = 200f;
   
    public void DealDamage (float damage)
    {
        health -= damage;
        if(health <=0)
        {
            ObjectDie();
        }
    }

    public void ObjectDie()
    {
        Destroy(gameObject);
        Debug.Log("Defender Died !");
    }
}
