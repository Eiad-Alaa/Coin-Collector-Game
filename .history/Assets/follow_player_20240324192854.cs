using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_player : MonoBehaviour
{
    public Transform player;
    public Vector3 
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position;
    }
}
