using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] gameObjects;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimal", 1,3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnAnimal()
    {
        int randomAnimal = Random.Range(0, 3);
        int randomSpawnZ= Random.Range(-4, -14);
        Vector3 spawnPos = new Vector3(-12, 1,randomSpawnZ);

        Instantiate(gameObjects[randomAnimal],spawnPos,transform.rotation);
    }

}
