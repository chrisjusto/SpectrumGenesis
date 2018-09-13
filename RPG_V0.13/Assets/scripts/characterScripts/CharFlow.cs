using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



    
public class CharFlow : charClass{


    


    void Awake()
    {

        Name = ("Flow");

        LVL = 100;

        myType = 2;

        spriteLocation = "char/flow";


        HP = 250;
        ATK = 250;
        DEF = 275;
        sATK = 600;
        sDEF = 550;
        SPD = 475;

        maxHealth = HP * 2;

        currentHealth = maxHealth;



        attackOneName = "Water Whip";
        Type01 = 2;
        acc01 = 100;
        target01 = true;
        atkType01 = 0;
        dmgType01 = 2;
        dmg01 = 30;
        status01 = 0;
        buff01 = false;

        attackTwoName = "Ice Shard";
        Type02 = 3;
        acc02 = 90;
        target02 = true;
        atkType02 = 0;
        dmgType02 = 2;
        dmg02 = 30;
        status02 = 0;
        buff02 = false;


        attackThreeName = "Mana Drain";
        Type03 = 0;
        acc03 = 80;
        target03 = true;
        atkType03 = 1;
        dmgType03 = 2;
        dmg03 = 150;
        status03 = 0;
        buff03 = false;

        attackFourName = "Healing Wtr";
        Type04 = 2;
        acc04 = 100;
        target04 = true;
        atkType04 = 2;
        dmgType04 = 4;
        dmg04 = maxHealth/4;
        status04 = 0;
        buff04 = true;




        attackFiveName = "Mage Blast";
        Type05 = 8;
        acc05 = 85;
        target05 = true;
        atkType05 = 0;
        dmgType05 =2;
        dmg05 = 60;
        status05 = 0;
        buff05 = false;



    }


    // Use this for initialization
    void Start () {



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
