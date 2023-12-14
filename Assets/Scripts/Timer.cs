using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timer = 60.0f;
    public int time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("My delta time value is: " + Time.deltaTime);
        timer -= Time.deltaTime;
        time = (int)timer;

        Debug.Log(timer);
        Debug.Log("Timer: " + timer.ToString("000"));
    }
}
