using UnityEngine;
using UnityEngine.AI;


public class AIMovement : MonoBehaviour
{

    public GameObject movementDestination1;
    public GameObject movementDestination2;
    public NavMeshAgent agent;
    public float totalTimeToPosition;
    public float currentTime = 0.0f;
    public bool exploredDest1 = false;



    private void Start()
    {
        
        totalTimeToPosition = Random.Range(3.0f, 15.0f);
    }

    void Update()
    {

        currentTime += Time.deltaTime;
        if (currentTime > totalTimeToPosition)
        {
            //Check to see if we explored destination 1
            if (exploredDest1 == true)
            {
                agent.SetDestination(movementDestination2.transform.position);
                //Set the time to 
                currentTime = 0.0f;
                //Set back to false to create a loop between the two destinations
                exploredDest1 = false;
            }
            //If destination 1 isn't explored go to destination 1
            else
            {
                agent.SetDestination(movementDestination1.transform.position);
                currentTime = 0.0f;
                exploredDest1 = true;
            }
        }
    }
}