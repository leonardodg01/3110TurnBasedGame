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
                abilityName = "Heal";
                abilityDescription = "Adds +50 health (Stops at 100)";
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
        if (playerCharacter.health < 100)
            playerCharacter.health += 50;
    }

}
