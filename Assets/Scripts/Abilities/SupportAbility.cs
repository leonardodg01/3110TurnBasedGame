using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupportAbility : Abilities
{
    public override void RandomAbility()
    {
        int random = 0;
        switch (random)
        {
            case 0:
                heal();
                break;
        };
    }

    private void heal()
    {
        abiltiyName = "Heal";
        abilityDescription = "Doubles current health";
        playerCharacter.health *= 2;
    }

}
