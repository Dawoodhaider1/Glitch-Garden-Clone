using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    public float speed;
    public float Damage;
    //public bool AttackerDied = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Attackers attacker = collision.gameObject.GetComponent<Attackers>();
        AttackerHealth health = collision.gameObject.GetComponent<AttackerHealth>();

        if(attacker && health)
        {
            health.DealDamage(Damage);
            Destroy(gameObject);
            Debug.Log("Projectile hits the attacker!");
        }
    }
}
