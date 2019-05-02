using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerPhone : MonoBehaviour
{

    public GameObject character;
    public AudioClip RingClip;
    public AudioSource RingSource;
    private bool isRinging;

    public Timer timer;

    private void Awake()
    {
        RingSource.clip = RingClip;
        isRinging = true;
    }

    // Update is called once per frame
    void Update()
    {
        bool isAnswered = timer.Answered();
        if (Input.GetKeyDown(KeyCode.E)){
            if (!isAnswered)
            {
                timer.setAnswered(true);
                timer.resetTimer();
                startStopLooping(false);
            }
        }
    }

    void startStopLooping(bool looping)
    {
        RingSource.loop = looping;
        if (looping == false)
        {
            RingSource.Stop();
        }
        else
        {
            RingSource.Play();
        }
    }


}
