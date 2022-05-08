using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string DisplayName;
    public int health;
    public int damage;
    public MapList map;
    public GameObject currentPrefab; //Current prefab that character instantiated
    
    public Character opponent; //Character that this character is fighting
    private int opponentDamage;

    public TMP_Text characterInfo; //Text that comes up on screen showing DisplayName and health
    public Button ResultText; //Text that shows up on screen telling player if they won or lost

    //This is called by Attack event
    public void TakeDamage() 
    {
        if (health > 0)
        {
            opponentDamage = opponent.damage; //Take damage according to opponent damage
            health -= opponentDamage;
        }
        if(health <= 0)
            ZeroHP();
    }

    //This is called by Attack event
    public void DisplayHP()
    {
        characterInfo.text = DisplayName + " HP: " + health;
    }

    //Implemented in child classes, runs when character reaches 0 health
    public virtual void ZeroHP() {}

    //Called by EnemyDefeated event, deletes current prefab so that the next one gets instantiated on its own
    public void destroyPrefab()
    {
        Destroy(currentPrefab);
    }
}
