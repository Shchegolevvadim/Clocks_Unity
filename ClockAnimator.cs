using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;


public class ClockAnimator : MonoBehaviour
{
    private DateTime time; // Переменная с временем из Интернета
    public Transform hours, minutes, seconds;
        private const float
        hoursToDegrees = 360f / 12f,
        minutesToDegrees = 360f / 60f,
        secondsToDegrees = 360f / 60f;
    //public Transform ClockHandTransform;
    
    
   
    
    // Start is called before the first frame update
    private void Awake()
    {
       
        
    }
    void Start()
    {
        
    }

    
    // Update is called once per frame
    void Update()
    {
        
        
        TimeSpan timespan = DateTime.Now.TimeOfDay;
        hours.localRotation =
            Quaternion.Euler(0f,0f,(float)timespan.TotalHours * -hoursToDegrees);
        minutes.localRotation =
            Quaternion.Euler(0f,0f,(float)timespan.TotalMinutes * -minutesToDegrees);
        seconds.localRotation =
            Quaternion.Euler(0f,0f,(float)timespan.TotalSeconds * -secondsToDegrees);
        
        
    }
    
   
}

