using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float forwardFo    public float forwardForce = 2000f;
rce = 2000f;

    public float forwardForce = 2000f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,200 * Time.deltaTime);
    }
}
