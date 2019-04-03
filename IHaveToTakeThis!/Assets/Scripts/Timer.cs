using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour
{
    float timeLeft = 60.0f;

    public Text text;
    public Score scoreManager;

    public bool phoneAnswered;

    private void Awake()
    {
        phoneAnswered = false;
    }



    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (!phoneAnswered) {
            text.text = "Answer:" + Mathf.Round(timeLeft);
            if (timeLeft < 0.0f)
            {
                phoneAnswered = true;
            }
        }
        else
        {
            text.text = "Call: " + Mathf.Round(timeLeft);
            if((timeLeft < 0.0f) || (scoreManager.soundLevel > 2))
            {
                text.text = "YOU LOSE";
                Application.Quit();
            }
        }
        
        
    }

    public void resetTimer()
    {
        timeLeft = 60.0f;
    }
}