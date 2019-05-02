using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HighScoreScript : MonoBehaviour
{

    int score = 100;
    float time = 0;
    public Text text;

    // Start is called before the first frame update
    void Awake()
    {
        text.text = "Score:" + score + " Points";
    }

    // Update is called once per frame
    void Update()
    {
        trackTime();
        updateScore();
        text.text = "Score: " + score + " Points";
    }

    void trackTime()
    {
        time += Time.deltaTime; 
    }

    void updateScore()
    {
        score += 100;
    }



    IEnumerator updateScoreEverySecond()
    {

        //Pause for a second
        yield return new WaitForSeconds(1);

        
    }
}
