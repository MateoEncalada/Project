using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation.Editor;
using UnityEngine;
using UnityEngine.AI;

public class NavigationAI : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent agent;
    public float followRange = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer <= followRange)
        {
            agent.destination = player.position;
        }
        else
        {
            // Stop moving if the player is out of range
            agent.destination = transform.position;
        }
    }
     
}
