using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour
{
    public GameObject ball;
    public float ballSpeed;
    public float requiredSpeed;
    // Update is called once per frame
    void Update()
    {
        ballSpeed = ball.GetComponent<DisplaySpeed>().speed;
    }

    private void OnTriggerEnter(Collider collision)
    {
        //Check if ball is "Boulder" and speed of ball is fast enough here
        if (collision.gameObject.tag == "Boulder" && ballSpeed >= requiredSpeed)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        //If the ball speed is 0 for too long a period of time, then reset player to start of level

    }
}
