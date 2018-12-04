﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FPSDisplay : MonoBehaviour
{
    Rect fpsRect;
    GUIStyle style;

    void Start()
    {
        fpsRect = new Rect(100, 100, 400, 100);
        style = new GUIStyle();
        style.fontSize = 30;
    }

    void Update()
    {
    
    }

    void OnGUI()
    {
        float fps = 1 / Time.deltaTime;
        GUI.Label(fpsRect, "FPS: " + fps);
    }

}
