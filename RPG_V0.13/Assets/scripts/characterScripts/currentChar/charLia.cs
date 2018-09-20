﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charLia : charClass {


    void Awake()
    {
        Name = "Lia";
        LVL = 100;

        PrimaryType = 12;
        SecondaryType = 0;

        typeWeekness[0] = 8;
        typeWeekness[1] = 4;

        typeStrength[0] = 2;
        typeStrength[1] = 7;


        HP = 300;
        ATK = 200;
        DEF = 300;
        sATK = 450;
        sDEF = 550;
        SPD = 600;

        ACCMOD = 1;
        ATKMOD = 1;
        DEFMOD = 1;
        SDEFMOD = 1;
        SATKMOD = 1;
        SPDMOD = 1;

        maxHealth = HP * 2;
        currentHealth = HP * 2;

        frontSprite = "char/charFront/03_lia";
        backSprite = "char/charBack/03_lia";
        portrait = Resources.Load<Sprite>("char/charFrame/03_liaPortrait");

        typeSprite01 = Resources.Load<Sprite>("char/charTyping/12_typeArchane");
        typeSprite02 = Resources.Load<Sprite>("char/charTyping/14_typeNone");

        Weapon = 3;
        Equipment = 3;
        ability = 3;
        Attack01 = 9;
        Attack02 = 10;
        Attack03 = 11;
        Attack04 = 12;

        EquipedAttacks[0] = 9;
        EquipedAttacks[1] = 10;
        EquipedAttacks[2] = 11;
        EquipedAttacks[3] = 12;

        attackUses[0] = AttackDatabase.attacks.AttackUses[EquipedAttacks[0]];
        attackUses[1] = AttackDatabase.attacks.AttackUses[EquipedAttacks[1]];
        attackUses[2] = AttackDatabase.attacks.AttackUses[EquipedAttacks[2]];
        attackUses[3] = AttackDatabase.attacks.AttackUses[EquipedAttacks[3]];
    }

}
