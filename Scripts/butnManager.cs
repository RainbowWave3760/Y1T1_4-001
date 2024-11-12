using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class butnManager : MonoBehaviour
{

    public GameObject pauseCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewLevelButn(string newLevel)
    { 
        SceneManager.LoadScene(newLevel);
    }

    public void ExitGameButn()
    {
        Application.Quit();
    }
}
