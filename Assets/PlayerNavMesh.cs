using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerNavMesh : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();

    }

    public void Move(Vector3 destination)
    {
        navMeshAgent.destination = destination;
    }
}
