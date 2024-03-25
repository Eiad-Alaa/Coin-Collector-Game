using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject Coin;
    public int OnGround;

    void start()
    {
        OnGround = 0;
    }
    void Update()
    {
        if(OnGround <= 20)
        {
            Vector3 randomSpacePosition = new Vector3(Random.Range(-150,151),Random.Range);
        }
    }
}
