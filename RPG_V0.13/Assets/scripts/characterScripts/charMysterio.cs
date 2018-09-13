using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMysterio : charClass {

    
  


 


    void Awake()
    {

        spriteLocation = "char/mysterio";

        Name = ("Mysterio");

        LVL = 100;

        myType = 5;
        



        HP = 450;
        ATK = 200;
        DEF = 250;
        sATK = 600;
        sDEF = 700;
        SPD = 200;

        maxHealth = HP * 2;

        currentHealth = maxHealth;

        attackOneName = "Solar Flare";
        Type01 = 5;
        acc01 = 100;
        target01 = true;
        atkType01 = 0;
        dmgType01 = 2;
        dmg01 = 25;
        status01 = 3;
        buff01 = false;

        attackTwoName = "Pacify";
        Type02 = 1;
        acc02 = 100;
        target02 = true;
        atkType02 = 1;
        dmgType02 = 0;
        dmg02 = 100;
        status02 = 0;
        buff02 = false;

        attackThreeName = "Meditate";
        Type03 = 6;
        acc03 = 95;
        target03 = true;
        atkType03 = 1;
        dmgType03 = 2;
        dmg03 = 100;
        status03 = 0;
        buff03 = true;

        attackFourName = "Angelic Lt";
        Type04 = 5;
        acc04 = 100;
        target04 = true;
        atkType04 = 2;
        dmgType04 = 1;
        dmg04 = (maxHealth/4);
        status04 = 0;
        buff04 = true;

        attackFiveName = "Celestial F.";
        Type05 = 9;
        acc05 = 100;
        target05 = true;
        atkType05 = 0;
        dmgType05 = 2;
        dmg05 = 75;
        status05 = 0;
        buff05 = false;



    }


    // Use this for initialization
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {


        //deathCheck
        if (currentHealth < 0 || currentHealth == 0)
        {



        }


    }




}
