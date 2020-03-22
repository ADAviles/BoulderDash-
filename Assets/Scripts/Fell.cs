using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fell : MonoBehaviour
{
    public Vector3 place;

    private void Start()
    {
        place = new Vector3(0, 5, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Boulder"))
        {
            other.transform.position = place;
            other.attachedRigidbody.velocity = new Vector3(0,0,0);
        }

        if (other.gameObject.CompareTag("Rubber"))
        {
            other.transform.position = place;
            other.attachedRigidbody.velocity = new Vector3(0, 0, 0);
        }
    }
}
