using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AAROB_materialSwap : MonoBehaviour
{
    private float speed;

    private Rigidbody rb;

    private Renderer rend;

    private Collider col;

    public Material mat1;
    public Material mat2;

    public PhysicMaterial regular;
    public PhysicMaterial rubber;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = mat1;
        rb = GetComponent<Rigidbody>();
    }

    private void rubberball()
    {
        speed = 10.0f;

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);

        GetComponent<Collider>().material = rubber;
        transform.gameObject.tag = "Rubber";
    }

    private void stoneball()
    {
        speed = 1.0f;

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);

        GetComponent<Collider>().material = regular;
        transform.gameObject.tag = "Boulder";
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            rend.sharedMaterial = mat2;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            rend.sharedMaterial = mat1;
        }

        if (rend.sharedMaterial == mat2)
        {
            rubberball();
        }

        if (rend.sharedMaterial == mat1)
        {
            stoneball();
        }
    }
}
