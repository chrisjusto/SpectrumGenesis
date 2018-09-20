using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charEvenese : charClass {

	// Use this for initialization
	void Awake() {
        Name = "Evenese";
        LVL = 100;

        PrimaryType = 9;
        SecondaryType = 7;

        typeWeekness[0] = 10;
        typeWeekness[1] = 12;

        typeStrength[0] = 9;


        HP = 400;
        ATK = 200;
        DEF = 425;
        sATK = 600;
        sDEF = 425;
        SPD = 350;

        maxHealth = HP * 2;
        currentHealth = HP * 2;

        frontSprite = "char/charFront/07_evenese";
        backSprite = "char/charBack/07_evenese";
        portrait = Resources.Load<Sprite>("char/charFrame/07_evenesePortrait");

        typeSprite01 = Resources.Load<Sprite>("char/charTyping/09_typeLight");
        typeSprite02 = Resources.Load<Sprite>("char/charTyping/06_typeIce");

        Weapon = 7;
        Equipment = 6;
        ability = 7;
        Attack01 = 25;
        Attack02 = 26;
        Attack03 = 27;
        Attack04 = 28;

        EquipedAttacks[0] = 25;
        EquipedAttacks[1] = 26;
        EquipedAttacks[2] = 27;
        EquipedAttacks[3] = 28;

        attackUses[0] = AttackDatabase.attacks.AttackUses[EquipedAttacks[0]];
        attackUses[1] = AttackDatabase.attacks.AttackUses[EquipedAttacks[1]];
        attackUses[2] = AttackDatabase.attacks.AttackUses[EquipedAttacks[2]];
        attackUses[3] = AttackDatabase.attacks.AttackUses[EquipedAttacks[3]];
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
