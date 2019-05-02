using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int soundLevel;
    public AudioLevelController audioLevel;

    void Awake()
    {
        SetLevel(1);
    }

    public void SetLevel(int newLevel)
    {
        soundLevel = newLevel;

        audioLevel.changeLevel(newLevel);

    }

    public int getSoundLevel()
    {
        return soundLevel;
    }
}
