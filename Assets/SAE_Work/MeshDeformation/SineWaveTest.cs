﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SineWaveTest : MonoBehaviour
{
    public float testNum;
    public float mag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + ((transform.up * Mathf.Sin(Time.time * testNum)) * mag);

    }
}
