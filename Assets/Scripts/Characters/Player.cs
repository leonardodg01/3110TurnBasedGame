using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Player : Character
{
    public WeaponList Weapon;

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
        ResultText.enabled = true;
        ResultText.text = "YOU LOST...";
        StartCoroutine(functionWait());
        SceneManager.LoadScene("MainScene");
    }

    //Gets weapon from current location of mapList
    public void setWeapon(WeaponList newWeapon)
    {
        Weapon = newWeapon;
        currentPrefab =  Instantiate(Weapon.weaponPrefab, gameObject.transform.position, Quaternion.Euler(0, 0, -10), gameObject.transform);
        currentPrefab.transform.localScale = new Vector3(Weapon.size, Weapon.size, Weapon.size);
        currentPrefab.transform.localPosition = new Vector3(0.2f, 1.15f, -0.15f);

        damage = Weapon.baseDamage;
    }
}
