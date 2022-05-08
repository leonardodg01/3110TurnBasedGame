using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy", menuName = "Enemy")]
public class EnemyList : ScriptableObject
{
    public string DisplayName;
    public int health;
    public int damage;
    public float yPosOffset; //The y position the object must take to touch the ground

    public GameObject enemyPrefab;
}
