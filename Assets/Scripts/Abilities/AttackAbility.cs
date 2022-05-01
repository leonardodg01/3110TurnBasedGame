using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAbility : Abilities
{
    public override void RandomAbility()
    {
        selectedAbliity = 0; //randomize later
        switch (selectedAbliity)
        {
            case 0:
                selectedAbliity = 0;
                abiltiyName = "Damage UP";
                abilityDescription = "Increases damage by 25% for rest of fight";
                break;
        };
    }

    public override void RunAbility()
    {
        switch (selectedAbliity)
        {
            case 0:
                increaseDamage();
                break;
        };
    }

    public void increaseDamage() //Increases player damage for rest of fight
    {
        playerCharacter.damage += playerCharacter.damage / 4;
    }
}
