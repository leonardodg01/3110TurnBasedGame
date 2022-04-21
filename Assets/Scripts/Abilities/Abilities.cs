using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public abstract class Abilities : MonoBehaviour
{
    public Sprite abilityIcon;
    public Player playerCharacter;
    public Enemy enemyCharacter;

    public string abiltiyName;
    public string abilityDescription;

    public abstract void RandomAbility(); //Select random ability, implemented in child classes
}