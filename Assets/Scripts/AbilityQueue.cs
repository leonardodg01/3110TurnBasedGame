using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class AbilityQueue : MonoBehaviour
{
    Queue<Abilities> aQueue = new Queue<Abilities>(); //Queue that holds abilities to be displayed;


    public Abilities[] abilityTypes;
    public Image[] imageQueue;

    public TMP_Text aName;
    public TMP_Text aDescription;

    bool AbilityUsed = false;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 2; i >= 0; i--) //Places 3 abilities into queue at start
        {
            int typeChosen = ChooseType();
            aQueue.Enqueue(abilityTypes[typeChosen]);

            imageQueue[i].overrideSprite = abilityTypes[typeChosen].abilityIcon;
        }

        //Lets player see current ability in UI
        aQueue.Peek().RandomAbility();
        aName.text = aQueue.Peek().abiltiyName;
        aDescription.text = aQueue.Peek().abilityDescription;
    }

    //Activates when player clicks "Accept" button in AbilitySelection UI
    public void UseAbility()
    {
        aQueue.Dequeue().RunAbility();
        AbilityUsed = true;
    }

    //Runs when turn ends, invoked by TurnEvent
    public void NextTurn() 
    {
        //Removes current ability (if it was discarded) and place another at back of queue
        if (AbilityUsed == false)
        {
            aQueue.Dequeue();
        }
        else
            AbilityUsed = false;

        
        int typeChosen = ChooseType();
        
        aQueue.Enqueue(abilityTypes[typeChosen]);

        //Reorganize image queue to fit with ability that was just queued.
        imageQueue[0].overrideSprite = imageQueue[1].overrideSprite;
        imageQueue[1].overrideSprite = imageQueue[2].overrideSprite;
        imageQueue[2].overrideSprite = abilityTypes[typeChosen].abilityIcon;

        aQueue.Peek().RandomAbility();
        aName.text = aQueue.Peek().abiltiyName;
        aDescription.text = aQueue.Peek().abilityDescription;
    }

    int ChooseType() //Randomly chooses ability type to be passed, return type must be what is being placed in queue
    {
        int random = Random.Range(1, 100);

        if (random >= 0 && random <= 40)
            return 0;
        else if (random > 40 && random <= 80)
            return 1;
        else
            return 2;
            
    }
}
