﻿///////////////////////////////////////////////////////////////////////
//
//      Hadou.cs
//      CompSci 40S, 2017-2018, Yaroslav Mikhaylik - HaselLoyance
//
///////////////////////////////////////////////////////////////////////

using UnityEngine;

public class Hadou : MonoBehaviour
{
    GMComponent gmc;

    void Start()
    {
        gmc = GetComponent<GMComponent>();

        gmc.ImageSpeed = 0.0f;

        Invoke("Alarm0", 1.0f / GM.fps);
    }

    public void StartAlarm(string alarmName, float frames)
    {
        Invoke(alarmName, 1.0f / GM.fps * frames);
    }

    public void StopAlarm(string alarmName)
    {
        CancelInvoke(alarmName);
    }

    public void Alarm0()
    {
        gmc.ImageAlpha -= 0.025f;

        Invoke("Alarm0", 1.0f / GM.fps);
    }
}
