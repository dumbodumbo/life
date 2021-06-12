using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
{

    public Rigidbody rb2b;

    public float speed = 9f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey("j"))
            rb2b.transform.position -= transform.right * Time.deltaTime * speed;
       
        if (Input.GetKey("l"))
            rb2b.transform.position += transform.right * Time.deltaTime * speed;
       
        if (Input.GetKey("k"))
            rb2b.transform.position -= transform.forward * Time.deltaTime * speed;
       
        if (Input.GetKey("i"))
            rb2b.transform.position += transform.forward * Time.deltaTime * speed;
    }
}
