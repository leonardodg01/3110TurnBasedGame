using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class AbilityQueue : MonoBehaviour
{
    Queue<int> aQueue = new Queue<int>(); //Queue that holds abilities to be displayed;
    public Player playerCharacter;
    public Enemy enemyCharacter;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 2; i ++) //Places 3 abilities into queue at start
            aQueue.Enqueue(ChooseType());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Runs when turn ends, invoked by TurnEvent
    public void NextTurn() 
    {
        //Removes current ability and place another at back of queue
        aQueue.Dequeue();
        aQueue.Enqueue(ChooseType());
    }

    int ChooseType() //Randomly chooses ability type to be passed, return type must be what is being placed in queue
    {
        int random = Random.Range(1, 5);

        if (random >= 1 && random <= 2)
            return 50;
        else if (random >= 3 && random <= 4)
            return 25;
        else
            return 75;
            
    }
}
