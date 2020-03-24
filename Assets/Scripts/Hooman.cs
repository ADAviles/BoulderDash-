using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hooman : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Boulder"))
        {
            anim.SetBool("hit", true);
        }
    }
}
