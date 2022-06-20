using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class TimeManager : MonoBehaviour
{

    public TextMeshProUGUI TimerText;

    // Start is called before the first frame update
    void Start()
    {
        GameTimer();
    }

    void GameTimer()
    {
        TimeSpan timeSpan = TimeSpan.FromSeconds(Time.realtimeSinceStartup);
        TimerText.text = "Your Time: " + timeSpan.Hours + " : " + timeSpan.Minutes + " : " + timeSpan.Seconds;
    }

}
