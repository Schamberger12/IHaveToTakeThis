using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeLightColor : MonoBehaviour
{

    Light lt;

    // Start is called before the first frame update
    void Start()
    {
        lt = GetComponent<Light>();   

    }

    // Update is called once per frame
    void Update()
    {
        lt.color = Color.Lerp(Color.red, Color.blue, 5.0f);
    }
}
