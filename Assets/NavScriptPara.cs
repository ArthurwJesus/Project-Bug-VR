using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NavScriptPara : MonoBehaviour
{
    [SerializeField] private float Radius = 20;

    NavMeshAgent My_enemy;

    Vector3 Next_Position;
    void Start ()
    {
        My_enemy = GetComponent<NavMeshAgent>();
        Next_Position = transform.position;
    }
    
    void Update ()
    {
        if(Vector3.Distance(Next_Position,transform.position) <= 1.5f)
        {
            Next_Position = Generic_Random_Point_Generator.R_Point_Ge(transform.position,Radius);
            My_enemy.SetDestination(Next_Position);
        }       
    }
}