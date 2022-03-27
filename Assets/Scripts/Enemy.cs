using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public EnemyList currentEnemy; //Gets an object derived from EnemyList

    void Start()
    {
        //Creates the enemy using values from Enemylist object
        DisplayName = currentEnemy.DisplayName;
        health = currentEnemy.health;
        damage = currentEnemy.damage;

        Instantiate(currentEnemy.enemyPrefab, gameObject.transform.position,Quaternion.Euler(0,-90,0), gameObject.transform);
        
        DisplayHP();
    }

    public override void ZeroHP()
    {
        ResultText.enabled = true;
        ResultText.text = "YOU WON!";
    }
}
