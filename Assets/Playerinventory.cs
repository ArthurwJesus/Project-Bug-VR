using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class PlayerInventory : MonoBehaviour
{
    public int NumberOfSeiva {get; private set;}
    public GameObject completeLevelUI;

    public AudioSource audioSourceCollect;

    public GameObject enemyDestroy;


    public UnityEvent<PlayerInventory> OnSeivaCollected;

    public void SeivaCollected()
    {
        NumberOfSeiva++;
        audioSourceCollect.Play();
        OnSeivaCollected.Invoke(this);

        if(NumberOfSeiva == 3){
            completeLevelUI.SetActive(true);
            Destroy(enemyDestroy);
        }
    }
}
