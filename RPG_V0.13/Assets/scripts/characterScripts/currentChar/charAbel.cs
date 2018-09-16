using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charAbel : charClass
{


   void Awake()
    {

        Name = ("Abel");

        LVL = 100;

        PrimaryType = 1;
        SecondaryType = 0;

        typeWeekness[0] = 3;
        typeWeekness[1] = 6;
        typeWeekness[2] = 8;

        typeStrength[0] = 4;
        typeStrength[1] = 7;

        HP = 300;
        ATK = 600;
        DEF = 350;
        sATK = 200;
        sDEF = 200;
        SPD = 750;

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






    }



}
