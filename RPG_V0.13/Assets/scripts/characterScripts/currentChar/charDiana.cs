using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charDiana : charClass {

	// Use this for initialization
	void Awake () {

        Name = "Diana";       
        LVL = 100;

        PrimaryType = 5;
        SecondaryType = 0;

        typeWeekness[0] = 3;
        typeWeekness[1] = 4;
        typeWeekness[2] = 7;

        typeStrength[0] = 2;
        typeStrength[1] = 6;
        typeStrength[2] = 8;
        typeStrength[3] = 1;

        HP = 650;
        ATK = 200;
        DEF = 600;
        sATK = 200;
        sDEF = 450;
        SPD = 300;

        maxHealth = HP * 2;
        currentHealth = HP * 2;

        frontSprite = "char/charFront/02_diana";
        backSprite = "char/charBack/02_diana";
        portrait = Resources.Load<Sprite>("char/charFrame/02_dianaPortrait");

        typeSprite01 = Resources.Load<Sprite>("char/charTyping/05_typeEarth");
        typeSprite02 = Resources.Load<Sprite>("char/charTyping/14_typeNone");

        Weapon = 2;
        Equipment = 2;
        ability = 2;
        Attack01 = 5;
        Attack02 = 6;
        Attack03 = 7;
        Attack04 = 8;

        EquipedAttacks[0] = 5;
        EquipedAttacks[1] = 6;
        EquipedAttacks[2] = 7;
        EquipedAttacks[3] = 8;

        attackUses[0] = AttackDatabase.attacks.AttackUses[EquipedAttacks[0]];
        attackUses[1] = AttackDatabase.attacks.AttackUses[EquipedAttacks[1]];
        attackUses[2] = AttackDatabase.attacks.AttackUses[EquipedAttacks[2]];
        attackUses[3] = AttackDatabase.attacks.AttackUses[EquipedAttacks[3]];

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
