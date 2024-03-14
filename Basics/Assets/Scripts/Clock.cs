using System;
using UnityEngine;

public class Clock : MonoBehaviour {
    const float hoursToDegrees = -30f;
    const float minutesToDegrees = -6f;
    const float secondsToDegrees = -6f;

    [SerializeField]
    private Transform hoursPivot, minutesPivot, secondsPivot;

    void Update() {
        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, (float)(hoursToDegrees * time.TotalHours));
        minutesPivot.localRotation = Quaternion.Euler(0f, 0f, (float)(minutesToDegrees * time.TotalMinutes));
        secondsPivot.localRotation = Quaternion.Euler(0f, 0f, (float)(secondsToDegrees * time.TotalSeconds));
    }
}