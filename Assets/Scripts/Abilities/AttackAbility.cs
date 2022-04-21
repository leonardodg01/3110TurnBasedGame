using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAbility : Abilities
{
    public override void RandomAbility()
    {
        int random = 0;
        switch (random)
        {
            case 0:
                increaseDamage();
                break;
        };
    }

    public void increaseDamage() //Increases player damage for rest of fight
    {
        abiltiyName = "Damage UP";
        abilityDescription = "Increases damage by 25% for rest of fight";
        playerCharacter.damage += playerCharacter.damage / 4;
    }
}
