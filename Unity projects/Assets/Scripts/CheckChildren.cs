using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckChildren : MonoBehaviour
{
    GameObject spawner;

    bool canSpawn = true;

    // Start is called before the first frame update
    void Start()
    {
        spawner = GameObject.FindGameObjectWithTag("Spawner");  
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.childCount <= 0 && canSpawn)
        {
            canSpawn = false;
            spawner.GetComponent<SpawnerScript>().SpawnWord();
        }
    }
}
