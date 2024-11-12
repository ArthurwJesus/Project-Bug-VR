using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealt : MonoBehaviour
{

    public int health;

    public GameObject simulator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(health < 0){
            //Remove o player
            gameObject.SetActive(false);
            SceneManager.LoadScene("Main menu");
            Destroy(simulator);
        }
    }

    public void TakeDamage()
    {
      Debug.Log("F");
      health--;  
    }
}
