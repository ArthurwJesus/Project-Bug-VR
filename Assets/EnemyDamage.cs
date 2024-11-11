using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public Transform player;

    public float distance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);
        Damage();

    }

    private void Damage(){
        RaycastHit hit;
        PlayerHealt playerHealt;

        if(Physics.Raycast(transform.position, transform.forward, out hit, distance)){
            Debug.Log(hit.transform.tag);

            if(hit.transform.tag =="Player")
            {
                playerHealt = hit.transform.GetComponent<PlayerHealt>();
                playerHealt.TakeDamage();
                Debug.Log(playerHealt.health);
            }
        }
    }
}
