﻿///////////////////////////////////////////////////////////////////////
//
//      Mizu.cs
//      CompSci 40S, 2017-2018, Yaroslav Mikhaylik - HaselLoyance
//
///////////////////////////////////////////////////////////////////////

using UnityEngine;

public class Mizu : MonoBehaviour
{
    GMComponent gmc;

    void Start()
    {
        gmc = GetComponent<GMComponent>();
        
        gmc.ImageSpeed = 0;
        gmc.ImageScaleX = 1.5f;
        gmc.ImageScaleY = 1.5f;
        gmc.ImageIndex = 5;
    }
}
