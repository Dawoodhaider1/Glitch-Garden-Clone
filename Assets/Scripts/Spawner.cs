using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] AttackerPrefabArray;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        foreach(GameObject thisAttacker in AttackerPrefabArray)
        {
            if(isTimeToSpawn (thisAttacker))
            {
                Spawn(thisAttacker);
                //AttackerHealth health = gameObject.GetComponent<AttackerHealth>();
            }
        }
    }
    void Spawn (GameObject myGameObject)
    {
        GameObject Attacker = Instantiate(myGameObject) as GameObject;
        Attacker.transform.parent = transform;
        Attacker.transform.position = transform.position;
    }

    bool isTimeToSpawn (GameObject AttackerGameObject)
    {
        Attackers attackers = AttackerGameObject.GetComponent<Attackers>();

        float meanSpawnDelay = attackers.SeenEverySeconds;
        float spawnsPerSecond = 1 / meanSpawnDelay;
        if(Time.deltaTime > meanSpawnDelay)
        {
            Debug.LogWarning("Spawn Rate Capped by frame rate");
        }

        float threshold = spawnsPerSecond * Time.deltaTime / 4;
        return (Random.value < threshold);  
    }
}
