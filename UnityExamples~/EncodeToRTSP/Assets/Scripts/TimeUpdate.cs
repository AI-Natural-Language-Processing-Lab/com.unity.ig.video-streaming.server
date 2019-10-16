using UnityEngine;
using UnityEngine.UI;

public class TimeUpdate : MonoBehaviour
{
    public int frameRate = 30;
    
    void Update()
    {
        var t = Time.unscaledTime;
        var seconds = (int)t;
        var h = seconds / 3600;
        var hInSec = h * 3600;
        var m = (seconds - hInSec) / 60;
        var mInSec = m * 60;
        var s = (seconds - (hInSec + mInSec));
        var framesDouble = frameRate * (t - (double) seconds);
        var f = (int)framesDouble;
        //var frac = 100 * (framesDouble - f) / frameRate;
        GetComponent<Text>().text = $"{h:00}:{m:00}:{s:00}:{f:00}";
    }
}