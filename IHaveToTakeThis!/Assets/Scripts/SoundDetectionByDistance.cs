using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundDetectionByDistance : MonoBehaviour
{
    public Score scoreManager;
    public int soundLevel;
    public GameObject thisObject;

    public GameObject player;
    public float Distance;
    public int triggerDistance; // 4 seems to be a good distance for this
    public int detected = 0;

    void Update()
    {
        Distance = Vector3.Distance(thisObject.transform.position, player.transform.position);

        if (Distance < triggerDistance - 2)
        {
            scoreManager.SetLevel(soundLevel);
            detected = 1;
        }
        else if (Distance < triggerDistance - 1 && Distance > triggerDistance - 2)
        {
            scoreManager.SetLevel(soundLevel - 1);
            detected = 1;
        }
        else if (Distance < triggerDistance && Distance > triggerDistance - 1)
        {
            scoreManager.SetLevel(soundLevel - 2);
            detected = 1;
        }
        else if (detected == 1 && Distance > triggerDistance)
        {
            scoreManager.SetLevel(1);
            detected = 0;
        }

    }
}
