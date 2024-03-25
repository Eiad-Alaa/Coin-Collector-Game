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
    }
}
