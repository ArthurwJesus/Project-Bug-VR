using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeivaSpawner : MonoBehaviour
{

    public int numberOfSeivaSpawner = 3;

    public GameObject seivaPrefab;

    public float height;

    // Start is called before the first frame update
    void Start()
    {
        // MRUK.Instance.RegisterSceneLoadedCallback(SpawnSeiva);
    }

    public void SpawnSeiva()
    {
        for(int i = 0 ; i < numberOfSeivaSpawner ; i++ )
        {

            Vector3 randomPosition = Random.insideUnitSphere * 3;
            randomPosition.y = 0;

            Instantiate(seivaPrefab, randomPosition, Quaternion.identity);
        }
    }

}
