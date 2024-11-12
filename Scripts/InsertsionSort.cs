using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsertsionSort : MonoBehaviour
{
    //New list is made
    List<int> NumList = new List<int> { 7, 6, 3, 2, 5, 9, 10};

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Original List: " + LTS(NumList));   //outputs into the Dubug.Log
        ISL(NumList);   //Calls for the created method
        Debug.Log("sorted List: " + LTS(NumList));   //outputs into the Dubug.Log
    }

    //New method for the algorithm (Insertion)
    void ISL(List<int> list)
    {
        int n = list.Count;
        for (int i = 1; i < n; i++)
        {
            int key = list[i];
            int j = i - 1;

            while (j >= 0 && list[j] > key)
            {
                list[j + 1] = list[j];
                j = j - 1;
            }
            list[j + 1] = key;
        }
    }

    //Changes the List<int> into a string
    string LTS(List<int> list)
    {
        return string.Join(", ", list);
    }
}
