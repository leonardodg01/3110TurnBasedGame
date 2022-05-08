using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialAbility : Abilities
{
    public override void RandomAbility()
    {
        int selectedAbliity = 0;
        switch (selectedAbliity)
        {
            case 0:
                selectedAbliity = 0;
                abilityName = "Weapon UP";
                abilityDescription = "Creates a clone of your current weapon that does half damage";
                break;
        };
    }

    public override void RunAbility()
    {
        switch (selectedAbliity)
        {
            case 0:
                WeaponUp();
                break;
        };
    }

    public void WeaponUp() //Instantiates a clone of the weapon the player currently has
    {
        GameObject cloneWeapon = Instantiate(playerCharacter.currentPrefab, playerCharacter.transform.position, Quaternion.Euler(0, 0, 0), playerCharacter.gameObject.transform);
        cloneWeapon.transform.localPosition = new Vector3(Random.Range(-2f, 2f), Random.Range(-2f, 2f), Random.Range(-2f, 2f));

        playerCharacter.damage += playerCharacter.Weapon.baseDamage/2; //Increases damage by base damage of weapon
    }
}
