using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float backwardForce = 2000f;
    public float sideForce = 2000f;

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey("w"))
        {
            rb.AddForce(0,0,forwardForce * Time.deltaTime);
        }
        if(Input.GetKey("s"))
        {
            rb.AddForce(0,0,-forwardForce * Time.deltaTime);
        }
        if(Input.GetKey("d"))
        {
            rb.AddForce(si,0,0);
        }
            if(Input.GetKey("w"))
        {
            rb.AddForce(0,0,forwardForce * Time.deltaTime);
        }
    }
}