using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplaySpeed : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
       
        speed = rb.velocity.magnitude;
        speed = Mathf.PI;

    }

    void OnGUI()
    {
        GUI.Box(new Rect(10, 10, 100, 90), "Momentum");

        GUI.Label(new Rect(20, 40, 80, 20), speed + "m/s");
    }

}
