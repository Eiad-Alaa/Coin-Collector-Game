using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{

    void OnCollisionEnter(Collision body)
    {if

        Debug.Log(body.collider.name);
    }
}
