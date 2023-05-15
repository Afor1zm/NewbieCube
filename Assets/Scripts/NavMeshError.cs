using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshError : MonoBehaviour
{
    public GameObject player;

    private NavMeshAgent navmesh;
    
    void Start()
    {
        navmesh = GetComponent<NavMeshAgent>();
        //navmesh.destination = player.transform.position;
        navmesh.SetDestination(player.transform.position);
    }
}
