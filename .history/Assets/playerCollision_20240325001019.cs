using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public PlayerScore s;
    public
    void OnCollisionEnter(Collision body)
    {
        if(body.collider.tag == "Coin")
        {
            s.score++;
            Debug.Log("Coin!!");
            Destroy(body.collider);
        }
        
    }
}
