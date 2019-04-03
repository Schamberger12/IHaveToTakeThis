using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public int soundLevel;

    void Start()
    {
        soundLevel = 1;
        scoreText.text = "Sound Level: " + soundLevel;
    }

    public void SetLevel(int newLevel)
    {
        soundLevel = newLevel;

        scoreText.text = "Sound Level: " + soundLevel;


    }
}
