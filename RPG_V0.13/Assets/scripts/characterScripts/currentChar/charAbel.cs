using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charAbel : charClass
{


   void Awake()
    {

        Name = ("Abel");

        LVL = 100;

        PrimaryType = 2;
        SecondaryType = 0;

        typeWeekness[0] = 3;
        typeWeekness[1] = 5;
        typeWeekness[2] = 6;

        typeStrength[0] = 4;
        typeStrength[1] = 7;

        baseATK = 600;
        baseDEF = 350;
        baseSATK = 200;
        baseSDEF = 200;
        baseSPD = 750;

        HP = 300;
        ATK = 600;
        DEF = 350;
        sATK = 200;
        sDEF = 200;
        SPD = 750;

        ACCMOD = 1;
        ATKMOD = 1;
        DEFMOD = 1;
        SDEFMOD = 1;
        SATKMOD = 1;
        SPDMOD = 1;


        maxHealth = HP * 2;
        currentHealth = HP * 2;

        frontSprite = "char/charFront/01_abelFire";
        backSprite = "char/charBack/01_abelFire";
        portrait = Resources.Load<Sprite>("char/charFrame/01_abelPortrait");

        typeSprite01 = Resources.Load<Sprite>("char/charTyping/02_typeFire");
        typeSprite02 = Resources.Load<Sprite>("char/charTyping/14_typeNone");

        Weapon = 1;
        Equipment = 1;
        ability = 1;
        Attack01 = 1;
        Attack02 = 2;
        Attack03 = 3;
        Attack04 = 4;

        EquipedAttacks[0] = 1;
        EquipedAttacks[1] = 2;
        EquipedAttacks[2] = 3;
        EquipedAttacks[3] = 4;

        attackUses[0] = AttackDatabase.attacks.AttackUses[EquipedAttacks[0]];
        attackUses[1] = AttackDatabase.attacks.AttackUses[EquipedAttacks[1]];
        attackUses[2] = AttackDatabase.attacks.AttackUses[EquipedAttacks[2]];
        attackUses[3] = AttackDatabase.attacks.AttackUses[EquipedAttacks[3]];


        




    }



}
