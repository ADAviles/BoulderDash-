using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplaySpeed : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    public int requiredspeed;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        speed = rb.velocity.magnitude;
        
    }

    void OnGUI()
    {
        GUI.Box(new Rect(10, 10, 100, 50), "Momentum");

        GUI.Label(new Rect(20, 40, 80, 20), "      " + Mathf.Round(speed) + " " + "m/s");

        GUI.Box(new Rect(1000, 10, 120, 50), "Required Speed: " + requiredspeed);
    }

}
