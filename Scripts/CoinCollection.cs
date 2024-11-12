using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CoinPosition : MonoBehaviour
{
    
   
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            GameManager gameManager = FindObjectOfType <GameManager>();
            if (gameManager !=null)
            {
                gameManager.AddCollectedCoin(1);
            }
            Destroy(gameObject);
        }
    }
}

