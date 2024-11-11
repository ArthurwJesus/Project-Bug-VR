using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavScript : MonoBehaviour {

    private UnityEngine.AI.NavMeshAgent Agent;
    public Transform Alvo;

    void Start () {
        Agent = GetComponent<UnityEngine.AI.NavMeshAgent> ();
    }
    
    // Update is called once per frame
    void Update () {
        Agent.SetDestination (Alvo.position);
}
}