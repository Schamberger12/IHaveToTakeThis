using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    float timeLeft = 15.0f;
    float countDownLose = 3.0f;

    public GameObject text;
    public Score scoreManager;
    public bool isAnswered;
    public Image exclamationPoint1;
    public Image exclamationPoint2;
    public Image exclamationPoint3;
    public Text timer;
    public Image phoneAnswer;

    private void Awake()
    {
        text.SetActive(false);
        isAnswered = false;
        exclamationPoint1.enabled = false;
        exclamationPoint2.enabled = false;
        exclamationPoint3.enabled = false;
    }



    void Update()
    {
        int soundLevel = scoreManager.getSoundLevel();
        timeLeft -= Time.deltaTime;
        timer.text = string.Format("{0:0.0}", timeLeft);
        
        if (!isAnswered) {
            if ((int)timeLeft % 2 == 0)
            {
                phoneAnswer.gameObject.SetActive(true);
            }
            else
            {
                phoneAnswer.gameObject.SetActive(false);
            }
            if (timeLeft < 0.0f)
            {
                LoseGame();
            }
        }
        else
        {
            phoneAnswer.gameObject.SetActive(true);
            if(soundLevel > 2)
            {
                countDownLose -= Time.deltaTime;
                if (countDownLose <= 1.0f)
                {
                    exclamationPoint3.enabled = true;
                }
                if (countDownLose <= 2.0f)
                {
                    exclamationPoint2.enabled = true;
                }
                if (countDownLose <= 3.0f)
                {
                    exclamationPoint1.enabled = true;
                }
                
            }

            if((timeLeft >= 30f) && (soundLevel > 2) && (countDownLose <= 0f))
            {
                //text.SetActive(true);
                // StartCoroutine(Quit());
                LoseGame();
            }
            if ((timeLeft >= 15f) && (timeLeft <= 30f) && (soundLevel > 2) && (countDownLose <= 0f))
            {
                WinGamePartial();
            }
            if (timeLeft <= 15f && soundLevel > 2 && countDownLose <= 0f)
            {
                WinGame();
            }
            if (timeLeft <= 0f)
            {
                WinGame();
            }
            if (soundLevel <= 2)
            {
                resetCountdown();
            }

        }
        
        
    }


    public void resetCountdown()
    {
        countDownLose = 1.5f;
        exclamationPoint1.enabled = false;
        exclamationPoint2.enabled = false;
        exclamationPoint3.enabled = false;
    }

    public void LoseGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void WinGamePartial()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void WinGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    public void resetTimer()
    {
        timeLeft = 60.0f;
    }

    public bool Answered()
    {
        return isAnswered;
    }

    public void setAnswered(bool phoneAnswered)
    {
        isAnswered = phoneAnswered;
    }


}