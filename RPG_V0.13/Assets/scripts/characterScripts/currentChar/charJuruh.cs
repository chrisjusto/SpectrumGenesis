using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charJuruh : charClass {

	// Use this for initialization
	void Awake () {
        Name = "Jur'Uh";
        LVL = 100;

        PrimaryType = 8;
        SecondaryType = 3;

        typeWeekness[0] = 4;
        typeWeekness[1] = 8;

        typeStrength[0] = 2;
        typeStrength[1] = 7;
        typeStrength[2] = 5;

        HP = 250;
        ATK = 200;
        DEF = 350;
        sATK = 700;
        sDEF = 300;
        SPD = 600;

        ACCMOD = 1;
        ATKMOD = 1;
        DEFMOD = 1;
        SDEFMOD = 1;
        SATKMOD = 1;
        SPDMOD = 1;

        maxHealth = HP * 2;
        currentHealth = HP * 2;

        frontSprite = "char/charFront/04_juruh";
        backSprite = "char/charBack/04_juruh";
        portrait = Resources.Load<Sprite>("char/charFrame/04_juruhPortrait");

        typeSprite01 = Resources.Load<Sprite>("char/charTyping/08_typeElectric");
        typeSprite02 = Resources.Load<Sprite>("char/charTyping/03_typeWater");

        Weapon = 4;
        Equipment = 4;
        ability = 4;
        Attack01 = 13;
        Attack02 = 14;
        Attack03 = 15;
        Attack04 = 16;

        EquipedAttacks[0] = 13;
        EquipedAttacks[1] = 14;
        EquipedAttacks[2] = 15;
        EquipedAttacks[3] = 16;

        attackUses[0] = AttackDatabase.attacks.AttackUses[EquipedAttacks[0]];
        attackUses[1] = AttackDatabase.attacks.AttackUses[EquipedAttacks[1]];
        attackUses[2] = AttackDatabase.attacks.AttackUses[EquipedAttacks[2]];
        attackUses[3] = AttackDatabase.attacks.AttackUses[EquipedAttacks[3]];
    }
	

}
