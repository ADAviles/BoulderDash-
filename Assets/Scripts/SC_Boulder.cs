﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Boulder : MonoBehaviour
{
    public float rightspeed = 5f;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(rightspeed, 0.0f, 0.0f);

        rb.AddForce(movement);
    }
}
