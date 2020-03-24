using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplaySpeed : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    public int requiredspeed;
    private AudioSource auS;
    public bool play;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        auS = GetComponent<AudioSource>();
    }

    private void Update()
    {
        speed = rb.velocity.magnitude;
        SoundCheck();
        
    }

    void OnGUI()
    {
        GUI.Box(new Rect(10, 10, 150, 70), "Momentum");

        GUI.Label(new Rect(40, 40, 80, 20), "      " + Mathf.Round(speed) + " " + "m/s");
        GUI.Label(new Rect(30, 55, 120, 20), "Required Speed: " + requiredspeed);

        
    }

    public void SoundCheck()
    {
        if (speed > 2 && play == true)
        {
            auS.enabled = true;
        }
        if (speed < 1)
        {
            auS.enabled = false;
        }
        if (play == false)
        {
            auS.enabled = false;
        }

    }

    private void OnTriggerStay(Collider other)
    {
        play = true;
    }
    private void OnTriggerExit(Collider other)
    {
        play = false;
    }
}
