using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_player : MonoBehaviour
{
    public Transform player;
    public vector
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position;
    }
}
