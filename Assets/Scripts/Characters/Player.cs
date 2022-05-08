using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Player : Character
{
    public WeaponList Weapon;
    public GameObject hands; //Included so that weapon follows player animation

    Player()
    {
        DisplayName = "Player";
        health = 100;
    }

    // Start is called before the first frame update
    void Start()
    {
        DisplayHP(); //Display initial health for character
    }

    public override void ZeroHP()
    {
        ResultText.gameObject.SetActive(true);
    }

    //Gets weapon from current location of mapList
    public void setWeapon(WeaponList newWeapon)
    {
        WeaponList oldWeapon = Weapon;
        if (newWeapon.baseDamage > oldWeapon.baseDamage || damage == 0) //Only runs if new weapon does more damage
        {
            Weapon = newWeapon;
        }
        currentPrefab = Instantiate(Weapon.weaponPrefab, hands.transform.position, Quaternion.Euler(0, 0, 0), hands.transform);
        currentPrefab.transform.localScale = new Vector3(Weapon.size, Weapon.size, Weapon.size);
        currentPrefab.transform.localRotation = Quaternion.Euler(70, 180, 10); //Sets correct rotation

        if (damage != 0) //Does not run when game starts
            damage += Weapon.baseDamage - oldWeapon.baseDamage;
        else
            damage = Weapon.baseDamage;
    }
}
