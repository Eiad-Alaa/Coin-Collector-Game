using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{

    void OnCollisionEnter(Collision body)
    {
        if(body.collider.tag == "Coin")
        {
            
        }
        
    }
}
