using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_player : MonoBehaviour
{
    public Transform player;
    public float speed;
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
        transform.Rotate(new Vector3(Input.GetAxis("Mouse Y"), , 0) * Time.deltaTime * speed);

    }
}
