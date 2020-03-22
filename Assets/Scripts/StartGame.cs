using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Boulder"))
        {
            SceneManager.LoadScene(2);
        }
        if (other.CompareTag("Rubber"))
        {
            SceneManager.LoadScene(2);
        }
    }
}
