using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDataBase : MonoBehaviour {

    public static WeaponDataBase weapons;

    public string[] WeaponName = new string[] {"", "sword of princes", "royal greatsword", "Archmages Bow", "Tome of Waves", "throwing Knives", "Striking Tome", "Staff of Angels", "Poison Tipped Knife" };
    public string[] WeaponDesc = new string[] {"", "Atk 60/100 matches type of user","Atk Normal 60/100","sAtk Archane 40/100","sAtk Water 60/100","Atk Normal 40/100 Increased Crit Chance", "sAtk Electric 60/100 5% chance to paralyze","sAtk Light 120/100 takes 1 turn to charge", "atk nature 30/100 5% chance to poison"};

    void Awake()
    {
        if (weapons == null)
        {
            weapons = this;
            
        }
        else if (weapons != this)
        {

        }
    }

}
