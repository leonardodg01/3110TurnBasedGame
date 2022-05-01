using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupportAbility : Abilities
{
    public override void RandomAbility()
    {
        selectedAbliity = 0; //randomize later
        switch (selectedAbliity)
        {
            case 0:
                selectedAbliity = 0;
                abiltiyName = "Heal";
                abilityDescription = "Doubles current health";
                break;
        };
    }

    public override void RunAbility()
    {
        switch (selectedAbliity)
        {
            case 0:
                heal();
                break;
        };
    }

    private void heal()
    {
        playerCharacter.health *= 2;
    }

}
