using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerPhone : MonoBehaviour
{

    public GameObject character;

    public Timer timer;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)){
            if (!timer.phoneAnswered)
            {
                timer.phoneAnswered = true;
                timer.resetTimer();
            }
        }
    }
}
