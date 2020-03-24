using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalToNextLevel : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider collision)
    {
        
        if (collision.gameObject.tag == "Boulder" || collision.gameObject.tag == "Rubber")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

       

    }
}
