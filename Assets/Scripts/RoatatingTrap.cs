﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoatatingTrap : MonoBehaviour
{
    void Update()
    {
        //roterar transformen i z led
        transform.Rotate(0f, 0f, 100f * Time.deltaTime, Space.World);
    }
}
