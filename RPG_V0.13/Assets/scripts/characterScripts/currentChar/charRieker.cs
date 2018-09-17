using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charRieker : charClass {

	// Use this for initialization
	void Awake() {

        Name = "Rieker";
        LVL = 100;

        PrimaryType = 10;
        SecondaryType = 4;

        typeWeekness[0] = 2;
        typeWeekness[1] = 7;
        typeWeekness[2] = 9;

        typeStrength[0] = 3;
        typeStrength[1] = 4;
        typeStrength[2] = 8;
        typeStrength[3] = 12;

        HP = 375;
        ATK = 550;
        DEF = 475;
        sATK = 200;
        sDEF = 200;
        SPD = 600;

        maxHealth = HP * 2;
        currentHealth = HP * 2;

        frontSprite = "char/charFront/08_rieker";
        backSprite = "char/charBack/08_rieker";
        portrait = Resources.Load<Sprite>("char/charFrame/08_riekerPortrait");

        typeSprite01 = Resources.Load<Sprite>("char/charTyping/10_typeDark");
        typeSprite02 = Resources.Load<Sprite>("char/charTyping/04_typeNature");

        Weapon = 8;
        Equipment = 7;
        ability = 8;
        Attack01 = 29;
        Attack02 = 30;
        Attack03 = 31;
        Attack04 = 32;

        attackUses[0] = AttackDatabase.attacks.AttackUses[EquipedAttacks[0]];
        attackUses[1] = AttackDatabase.attacks.AttackUses[EquipedAttacks[1]];
        attackUses[2] = AttackDatabase.attacks.AttackUses[EquipedAttacks[2]];
        attackUses[3] = AttackDatabase.attacks.AttackUses[EquipedAttacks[3]];
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
