using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackerHealth : MonoBehaviour
{

    public float health = 200f;
    public float levelprogress = 0f;
    public float progress = 0f;
    public Slider slider;
    private void Start()
    {
        slider = GameObject.FindObjectOfType<Slider>();
    }

    public void DealDamage (float damage)
    {
        health -= damage;
        if(health <=0)
        {
            ObjectDie();
            if (slider != null)
            {
                Debug.Log(progress);
                slider.value +=10f;
            }
        }
    }

    public void ObjectDie()
    {
        Destroy(gameObject);
        
        Debug.Log("Attacker Died !");
    }
}
