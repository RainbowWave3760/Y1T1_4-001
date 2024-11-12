using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSort : MonoBehaviour
{
    //Array created for Bubble Sort
    int[] BSArray = { 7, 3, 2, 5, 6, 9, 10 };

    
    

    // Start is called before the first frame update
    void Start()
    {
        //Prints to Debug.Log
        Debug.Log("Unsorted Array: " + ATS(BSArray));
        BubbleSorting(BSArray);
        Debug.Log("Sorted Array: " + ATS(BSArray));
    }

    //Bubble Sort method for largest number to smallest
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

    // Update is called once per frame
    void Update()
    {

    }
    //Int to string
    string ATS(int[] arr)
    {  
        return string.Join(", ", arr);
    }
}
