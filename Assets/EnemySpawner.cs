using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public int limitEnemy = 3;

    public GameObject prefabToSpawn;

    // Start is called before the first frame update
    void Start()
    {
         for(int i = 0 ; i < limitEnemy ; i++ )
        {
            SpawnAfideo();
        }
    }

    void Update()
    {

    }

    public void SpawnAfideo()
    {
        Vector3 randomPosition = Random.insideUnitSphere * 3;
        randomPosition.y = -0.5379928f;

        Instantiate(prefabToSpawn, randomPosition, Quaternion.identity);
    }
}
