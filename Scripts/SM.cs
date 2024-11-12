using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SM : MonoBehaviour
{
    //Character states of movement
    private enum State
    {
        Idle,
        Walking,
        Jumping
    }
    private State currentState;

    void Start()
    {
        //Starting the game in the Idle State
        currentState = State.Idle;
    }

    void Update()
    {
        HandleState();

        
            if(Input.GetKeyDown(KeyCode.W))
            {
                //Changes the state to the Walking State once the W key is pressed 
                ChangeState(State.Walking);
            }
            else if(Input.GetKeyDown(KeyCode.Space))
            {
                ChangeState(State.Jumping);
            }
            else if(Input.GetKeyDown(KeyCode.S))
            {
                ChangeState(State.Idle);
            }
        
        
    }

    private void HandleState()
    {
        switch (currentState)
        {
            case State.Idle:
                Debug.Log("Insert Idle Animation Here");
                break;

            case State.Walking:
                Debug.Log("Insert Walking Animation Here");
                break;

            case State.Jumping:
                Debug.Log("Insert Jumping Animation Here");
                break;
        }
    }

    private void ChangeState(State newState)
    {
        //Allows for state change in the script
        currentState = newState;
        Debug.Log("Changed state to: " + currentState);
    }
    
 
}
