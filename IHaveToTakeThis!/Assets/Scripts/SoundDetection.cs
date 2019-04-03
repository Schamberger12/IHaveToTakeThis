using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundDetection : MonoBehaviour
{
    public Score scoreManager;
    public int soundLevel;

    public GameObject player;

    private void OnCollisionEnter(Collision collision)
    {
        //Assuming the player object is called "Player"
        if (collision.gameObject == player)
        {
            scoreManager.SetLevel(soundLevel);

            Debug.Log("Collision detected");
        }

    }
}
