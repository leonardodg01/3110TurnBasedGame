using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    Player()
    {
        DisplayName = "Player";
        health = 100;
        damage = 20;
    }

    // Start is called before the first frame update
    void Start()
    {
        DisplayHP(); //Display initial health for character
    }

    public override void ZeroHP()
    {
        ResultText.enabled = true;
        ResultText.text = "YOU LOST...";
    }
}
