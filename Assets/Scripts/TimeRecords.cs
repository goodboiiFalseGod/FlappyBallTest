using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeRecords
{
    private float _levelTime;

    public TimeRecords()
    {
        _levelTime = 0;
    }

    public void SetLevelTtme(float time) => _levelTime = time;
    public float GetLevelTtme() => _levelTime;
}
