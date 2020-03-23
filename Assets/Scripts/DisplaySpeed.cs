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
        GUI.Box(new Rect(10, 10, 150, 70), "Momentum");

        GUI.Label(new Rect(40, 40, 80, 20), "      " + Mathf.Round(speed) + " " + "m/s");
        GUI.Label(new Rect(30, 55, 120, 20), "Required Speed: " + requiredspeed);

        
    }

}
