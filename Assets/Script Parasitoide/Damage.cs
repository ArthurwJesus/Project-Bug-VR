using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public float distance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      ShowDamage();

    }

    private void ShowDamage(){
        RaycastHit hit;
        HealtAfideo healtAfideo;

        if(Physics.Raycast(transform.position, transform.forward, out hit, distance)){
            if(hit.transform.tag =="Enemy")
            {
                Debug.Log("Enemigo tomou dano");
                healtAfideo = hit.transform.GetComponent<HealtAfideo>();
                healtAfideo.TakeDamage();
                Debug.Log(healtAfideo.health);
            }
        }
    }
}
