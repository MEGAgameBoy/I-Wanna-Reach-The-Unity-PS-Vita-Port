﻿///////////////////////////////////////////////////////////////////////
//
//      Gottjiki.cs
//      CompSci 40S, 2017-2018, Yaroslav Mikhaylik - HaselLoyance
//
///////////////////////////////////////////////////////////////////////

using UnityEngine;

public class Gottjiki : MonoBehaviour
{
    GMComponent gmc;

    void Start()
    {
        gmc = GetComponent<GMComponent>();

        gmc.ImageSpeed = 0.0f;
    }

    void FixedUpdate()
    {
        gmc.ImageAngle = gmc.Direction;
    }
}
