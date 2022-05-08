using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.Events;
using UnityEngine;

public class MapList : MonoBehaviour
{
    public struct Map //Will be held in map Linked List
    {
        public WeaponList unlockableWeapon;
        public EnemyList enemy;
    }

    public GameObject mapUI;
    public Enemy enemyChar;
    public Player playerChar;
    public EnemyList[] PossibleEcounters;
    public WeaponList[] PossibleWeapons;
    public TMP_Text[] UiText;
    public UnityEvent GameComplete;

    LinkedList<Map> mapList = new LinkedList<Map>();
    LinkedList<Map>.Enumerator mapEm;

    // Start is called before the first  frame update
    void Start()
    {
        for (int i = 0; i < Random.Range(5, 10); i++) //Populate linked list
        {
            mapList.AddLast(randomSelect(i));
        }

        mapEm = mapList.GetEnumerator(); //Set enumerator to front of list
        mapEm.MoveNext();

        enemyChar.setEnemy(GetEnemy());
        playerChar.setWeapon(GetWeapon());

    }

    Map randomSelect(int index) //Randomly selects weapon and enemy that will appear
    {
        int enemyLevel = 0; //Max index of possible enounters that player is allowed to see
        if (index >= 0 && index <= 2)
            enemyLevel = 1;
        else if (index >= 3 && index <= 4)
            enemyLevel = 3;
        else if (index >= 5)
            enemyLevel = PossibleEcounters.Length;

        Map temp;
        temp.enemy = PossibleEcounters[Random.Range(0, enemyLevel)];
        temp.unlockableWeapon = PossibleWeapons[Random.Range(0, PossibleWeapons.Length)];

        return temp;
    }

    //Updates enumerator and UI, will be called during EnemyDefeated Unity event
    public void updateMap()
    {
        if(!mapEm.MoveNext()) //Moves to next node in list, game is over if there is no more.
        {
            GameComplete.Invoke();
        }

        //Update UI to show player what is up next
        UiText[0].text = mapEm.Current.enemy.DisplayName;
        UiText[1].text = mapEm.Current.unlockableWeapon.DisplayName + ": " + mapEm.Current.unlockableWeapon.baseDamage +" damage";

        enemyChar.setEnemy(GetEnemy());
        playerChar.setWeapon(GetWeapon());
    }

    public EnemyList GetEnemy()
    {
        return mapEm.Current.enemy;
    }

    public WeaponList GetWeapon()
    {
        return mapEm.Current.unlockableWeapon;
    }
}
