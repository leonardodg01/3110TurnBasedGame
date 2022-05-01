using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Weapon")]
public class WeaponList : ScriptableObject
{
    public string DisplayName;
    public int baseDamage;
    public float size;

    public GameObject weaponPrefab;
}
