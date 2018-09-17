using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charKirah : charClass {

	// Use this for initialization
	void Awake() {
        Name = "Ki'Rah";
        LVL = 100;

        PrimaryType = 6;
        SecondaryType = 1;

        typeWeekness[0] = 11;
        typeWeekness[1] = 8;

        typeStrength[0] = 5;


        HP = 350;
        ATK = 650;
        DEF = 200;
        sATK = 200;
        sDEF = 200;
        SPD = 800;

        maxHealth = HP * 2;
        currentHealth = HP * 2;

        frontSprite = "char/charFront/05_kirah";
        backSprite = "char/charBack/05_kirah";
        portrait = Resources.Load<Sprite>("char/charFrame/05_kirahPortrait");

        typeSprite01 = Resources.Load<Sprite>("char/charTyping/07_typeAir");
        typeSprite02 = Resources.Load<Sprite>("char/charTyping/01_typeNormal");

        Weapon = 5;
        Equipment = 3;
        ability = 5;
        Attack01 = 17;
        Attack02 = 18;
        Attack03 = 19;
        Attack04 = 20;

        attackUses[0] = AttackDatabase.attacks.AttackUses[EquipedAttacks[0]];
        attackUses[1] = AttackDatabase.attacks.AttackUses[EquipedAttacks[1]];
        attackUses[2] = AttackDatabase.attacks.AttackUses[EquipedAttacks[2]];
        attackUses[3] = AttackDatabase.attacks.AttackUses[EquipedAttacks[3]];
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
