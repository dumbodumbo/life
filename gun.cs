using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{

    //public Rigidbody rb;

    public float movementspeed = 1f;

    private Rigidbody rb;

        // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetButtonDown("Fire2"))
            rb.AddForce(new Vector3(movementspeed,0f, 0f));

        if (Input.GetButtonUp("Fire2"))
            rb.AddForce(new Vector3(200f,0f, 0f));
       


    }
}
