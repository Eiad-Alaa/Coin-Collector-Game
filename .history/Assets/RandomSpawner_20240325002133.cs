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
        if(OnGround <= 25)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-148,149),2,Random.Range(-148,149));
            Instantiate(Coin,randomSpawnPosition,Quaternion.identity);
            o
        }
    }
}
