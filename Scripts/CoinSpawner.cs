using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coin;
    public int numberToSpawn = 10;
    public float distanceCoin = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        for (var i = 0; i < numberToSpawn; i++)
        {
            Instantiate(coin, new Vector3(i * distanceCoin, 0, 0), Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
