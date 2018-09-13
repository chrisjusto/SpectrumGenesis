﻿using System.Collections;
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

        maxHealth = HP * 2;

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
    }
	

}
