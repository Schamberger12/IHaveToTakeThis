using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundDetection : MonoBehaviour
{
    public Score scoreManager;
    public int soundLevel;

    public GameObject player;

    private void OnTriggerStay(Collider other)
    {
        //Assuming the player object is called "Player"
        if (other.gameObject == player)
        {
            scoreManager.SetLevel(soundLevel);

            Debug.Log("Collision detected");
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            scoreManager.SetLevel(1);
        }
    }
}
