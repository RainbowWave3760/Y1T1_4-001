using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager2 : MonoBehaviour
{

    private Target[] targets;
    private int[] hpValues;
    // Start is called before the first frame update
    void Start()
    {
        targets = FindObjectsOfType<Target>();
        hpValues = new int[targets.Length];
        for (int i = 0; i < targets.Length; i++)
        {
            hpValues[i] = targets[i].GetHealthPoints();
        }

        BubbleSorting(hpValues);
    }

    void BubbleSorting(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] < arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    public int[] GetSortedHPValues()
    {
        return hpValues; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
