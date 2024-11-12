using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{
    
    // Start is called before the first frame update
    
    private int CollectedCoin = 0;
    private bool isPaused = false;

    //step 1
    public void AddCollectedCoin(int amount)
    {
        CollectedCoin += amount;
        if (CollectedCoin >= 15)
        {
            SceneManager.LoadScene("You Win Yippee!!!!");
        }
    }

    void update()
    {
        Pause();
    }

void Pause()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isPaused)
            {
                Time.timeScale = 1.0f;
            }
            else
            {
                Time.timeScale = 0.0f;
            }
            isPaused = !isPaused;
        }
    }


}
