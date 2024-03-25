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
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-90,91),2,Random.Range(-90,91));
            Instantiate(Coin,randomSpawnPosition,Quaternion.identity);
            OnGround++;
        }
    }
}
