using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class AttackButton : MonoBehaviour
{
    public UnityEvent Attack; //Event that handles all functions that run when Attack is pressed

    //Invokes Attack event, all functions can be found under the Attack button in the editor
    public void ClickedAttack()
    {
        Attack.Invoke();
    }
}
