using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charGrimace : charClass {

	// Use this for initialization
	void Awake() {
        Name = "Grimace";
        LVL = 100;

        PrimaryType = 11;
        SecondaryType = 0;

        typeWeekness[0] = 9;
        typeWeekness[1] =12;

        typeStrength[0] = 1;
        typeStrength[1] = 10;


        HP = 600;
        ATK = 200;
        DEF = 400;
        sATK = 300;
        sDEF = 600;
        SPD = 300;

        maxHealth = HP * 2;
        currentHealth = HP * 2;

        frontSprite = "char/charFront/06_grimace";
        backSprite = "char/charBack/06_grimace";
        portrait = Resources.Load<Sprite>("char/charFrame/06_grimacePortrait");

        typeSprite01 = Resources.Load<Sprite>("char/charTyping/11_typePsychic");
        typeSprite02 = Resources.Load<Sprite>("char/charTyping/14_typeNone");

        Weapon = 6;
        Equipment = 5;
        ability = 6;
        Attack01 = 21;
        Attack02 = 22;
        Attack03 = 23;
        Attack04 = 24;

        attackUses[0] = AttackDatabase.attacks.AttackUses[EquipedAttacks[0]];
        attackUses[1] = AttackDatabase.attacks.AttackUses[EquipedAttacks[1]];
        attackUses[2] = AttackDatabase.attacks.AttackUses[EquipedAttacks[2]];
        attackUses[3] = AttackDatabase.attacks.AttackUses[EquipedAttacks[3]];
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
