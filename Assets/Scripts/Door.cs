using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public DisplaySpeed DS;
    public float RequiredSpeed;
    public bool Speed1;
    public bool Speed2;
    public GameObject Together;
    public GameObject Broken;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpeedCheck();
        BreakDoor();
    }

    public void SpeedCheck()
    {
        if (DS.speed >= RequiredSpeed)
        {
            Speed1 = true;
        }
        if (DS.speed < RequiredSpeed)
        {
            Speed1 = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Boulder"))
        {
            Speed2 = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Boulder"))
        {
            Speed2 = false;
        }
    }

    public void BreakDoor()
    {
        if (Speed1 == true && Speed2 == true)
        {
            Together.SetActive(false);
            Broken.SetActive(true);
        }
    }
}
