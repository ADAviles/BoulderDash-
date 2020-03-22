using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Boulder"))
        {
            Application.Quit();
        }
        if (other.CompareTag("Rubber"))
        {
            Application.Quit();
        }
    }
}
