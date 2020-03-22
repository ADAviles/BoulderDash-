using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplaySpeed : MonoBehaviour
{
    private float speed;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdated()
    {
        speed = rb.velocity.magnitude;
    }

    void OnGUI()
    {
        GUI.Box(new Rect(10, 10, 100, 90), "Momentum");

        GUI.Label(new Rect(20, 40, 80, 20), speed + "m/s");
    }

}
