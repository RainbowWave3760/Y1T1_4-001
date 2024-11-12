using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    //SerializeField prevents editing from other scripts
    [SerializeField] private int healthPoints;

    //Calls for the value healthPoints in other scripts if called
    public int GetHealthPoints()
    {
        return healthPoints;
    }
}
