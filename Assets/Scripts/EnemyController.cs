using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    private NavMeshAgent _navMeshAgent;
    [SerializeField]
    private Transform _destination;

    // Start is called before the first frame update
    void Start()
    {
        _navMeshAgent.SetDestination(_destination.position);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
