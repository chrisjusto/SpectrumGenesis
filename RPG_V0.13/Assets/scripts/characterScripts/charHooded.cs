using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharHooded : charClass {

   
 


  


    void Awake()
    {

        spriteLocation = "char/hooded";

        Name = ("Hooded");

        LVL = 100;

        myType = 4;
     



        HP = 200;
        ATK = 200;
        DEF = 275;
        sATK = 650;
        sDEF = 275;
        SPD = 800;

        maxHealth = HP * 2;

        currentHealth = maxHealth;

        attackOneName = "Telekenisis";
        Type01 = 6;
        acc01 = 100;
        target01 = true;
        atkType01 = 0;
        dmgType01 = 2;
        dmg01 = 20;
        status01 = 0;
        buff01 = false;

        attackTwoName = "Blood Slash";
        Type02 = 4;
        acc02 = 95;
        target02 = true;
        atkType02 = 0;
        dmgType01 = 2;
        dmg02 = 20;
        status02 = 0;
        buff02 = false;


        attackThreeName = "Leaf Shurikin";
        Type03 = 10;
        acc03 = 95;
        target03 = true;
        atkType03 = 0;
        dmgType03 = 2;
        dmg03 = 20;
        status03 = 0;
        buff03 = false;

        attackFourName = "Agility";
        Type04 = 0;
        acc04 = 95;
        target04 = true;
        atkType04 = 1;
        dmgType04 = 4;
        dmg04 = 50;
        status04 = 0;
        buff04 = true;




        attackFiveName = "Dark Pact";
        Type05 = 4;
        acc05 = 100;
        target05 = true;
        atkType05 = 1;
        dmgType05 = 2;
        dmg05 = 200;
        status05 = 0;
        buff05 = true;



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
