using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Rigidbody rb;

    

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,200 * Time.deltaTime);
    }
}
