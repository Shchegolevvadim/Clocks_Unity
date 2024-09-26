using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;




public class DigitTime : MonoBehaviour
{
    float secondsNew = 60f, minutesNew = 60f, hoursNew = 12f;
    public Text second;
    public Text minutes;
    public Text hours;
    private DateTime time; 
	private float timeHours, timeMinutes, timeSeconds;
	private IEnumerator CheckTime()
{
    time = CheckGlobalTime();
    yield return new WaitForSeconds(3600f); // здесь раз в час
}
    // Start is called before the first frame update
    void Start()
    {
        time = CheckGlobalTime();
    }

    // Update is called once per frame
    void Update()
    {
        DateTime time = DateTime.Now;
 

        second.text = ""+(time.Second * (60f / secondsNew));
        minutes.text = "" + (time.Minute * (60f / minutesNew)) + "      :";
        hours.text = "" + (time.Hour * (12f / hoursNew)) + "      :";
        
    }
    private DateTime CheckGlobalTime()
    {
        DateTime globDateTime;
 
        var www = new WWW("google.com");
 
        while (!www.isDone && www.error == null)
        {
            Thread.Sleep(1);
        }
 
        var timeStr = www.responseHeaders["Date"];
 
        print(timeStr);
        
        if (!DateTime.TryParse(timeStr, out globDateTime))
        {
            return DateTime.MinValue;
        }
 
        return globDateTime.ToUniversalTime();
    }
}
