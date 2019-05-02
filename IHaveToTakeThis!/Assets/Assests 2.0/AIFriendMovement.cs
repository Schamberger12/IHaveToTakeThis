using UnityEngine;
using UnityEngine.AI;


public class AIFriendMovement : MonoBehaviour
{
    public GameObject player;
    public NavMeshAgent agent;


    void Update()
    {
        agent.SetDestination(player.transform.position);
    }
}