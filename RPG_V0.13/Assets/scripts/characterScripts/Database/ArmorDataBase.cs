using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorDataBase : MonoBehaviour {

    public static ArmorDataBase Equip;

    public string[] EquipName = new string[] { "", "princes garb","golden armour","trinket of defense","boots of swiftness","trinket of fortitude","Holy Trinket","cloak of darkness" };
    public string[] EquipDesc = new string[] { "", "raises defense and speed", "raises defense greatly", "raises defense and special def", "raises speed greatlly", "raises special defense greatly", "raises special atack and special defense", "lowers defense raises evasion" };


    void Awake()
    {
        if (Equip == null)
        {
            Equip = this;
        }
        else if (Equip != this)
        {

        }
    }

}
