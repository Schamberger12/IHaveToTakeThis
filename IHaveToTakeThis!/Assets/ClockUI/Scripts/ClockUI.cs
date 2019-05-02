

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockUI : MonoBehaviour {

    private const float REAL_SECONDS_PER_INGAME_DAY = 60f;

    private Transform clockHandTransform;
    private float day;

    private float resetTime = 60f;
    private float timer = 0f;

    

    private void Awake() {
        clockHandTransform = transform.Find("clockHand");
    }

    private void Update() {

        day += Time.deltaTime / REAL_SECONDS_PER_INGAME_DAY;

        float dayNormalized = day % 1f;

        float rotationDegreesPerDay = 360f;
        clockHandTransform.eulerAngles = new Vector3(0, 0, -dayNormalized * rotationDegreesPerDay);
    }

    public void resetClock()
    {
        day = 0f;
        clockHandTransform.eulerAngles = new Vector3(0, 0, 0);
    }
}
