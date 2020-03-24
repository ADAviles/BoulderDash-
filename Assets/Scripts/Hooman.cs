using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hooman : MonoBehaviour
{
    private Animator anim;
    public AudioSource splat;

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

    public void Splat()
    {
        splat.Play();
    }

    public void Delete()
    {
        Destroy(gameObject);
    }
}
