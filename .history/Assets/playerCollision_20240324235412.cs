using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public int score;
    void OnCollisionEnter(Collision body)
    {
        if(body.collider.tag == "Coin")
        {
            score++;
            Debug.Log("Coin!!");
            Destroy(body)
        }
        
    }
}
