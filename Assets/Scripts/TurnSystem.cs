using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class TurnSystem : MonoBehaviour
{
    int turnCount;
    public UnityEvent TurnEvent;

    // Start is called before the first frame update
    void Start()
    {
        turnCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Runs when next turn starts and invokes TurnEvent event
    //This is run either when an ability is selected or the player attacks
    public void NextTurn() 
    {
        turnCount++;
        TurnEvent.Invoke();
    }
}
