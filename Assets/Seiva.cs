using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seiva : MonoBehaviour
{    
    private void OnTriggerEnter(Collider other){

        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if(playerInventory != null){
           playerInventory.SeivaCollected();
           gameObject.SetActive(false); 
        }
    }
}
