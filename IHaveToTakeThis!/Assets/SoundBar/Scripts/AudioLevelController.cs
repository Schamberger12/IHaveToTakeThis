using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioLevelController : MonoBehaviour
{

    public Slider SoundBar;
    public float Level = 100f; 

    public void changeLevel(int level){

        float soundLevel = ((float)level / 5f) * 100f;

        SoundBar.value = soundLevel; 


    }



}
