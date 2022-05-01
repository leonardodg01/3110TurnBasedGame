using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class Enemy : Character
{
    public EnemyList currentEnemy; //Gets an object derived from EnemyList
    public UnityEvent enemyDefeated; //Runs all functions when player defeats enemy

    void Start()
    {
    }

    public override void ZeroHP()
    {
        ResultText.enabled = true;
        ResultText.text = "YOU WON!";

        StartCoroutine(functionWait());
        enemyDefeated.Invoke();
    }

    //Gets enemy from current location of mapList
    public void setEnemy(EnemyList newEnemy)
    {
        currentEnemy = newEnemy;
        DisplayName = currentEnemy.DisplayName;
        health = currentEnemy.health;
        damage = currentEnemy.damage;

        //Creates the enemy using values from Enemylist object
        currentPrefab = Instantiate(currentEnemy.enemyPrefab, gameObject.transform.position, Quaternion.Euler(0, -90, 0), gameObject.transform);

        DisplayHP();
    }
}
