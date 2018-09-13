
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class CharRuby : charClass
{

    


    void Awake()
    {

        charSprite = Resources.Load<Sprite>("char/ruby");

        spriteR = gameObject.GetComponent<SpriteRenderer>();

        spriteR.sprite = charSprite;

        spriteLocation = "char/ruby";

        Name = ("Ruby");

        LVL = 100;

        myType = 1;
    
        



        HP = 200;
        ATK = 600;
        DEF = 250;
        sATK = 475;
        sDEF = 275;
        SPD = 600;

        maxHealth = HP * 2;

        currentHealth = maxHealth;

        attackOneName = "Lightning";
        Type01 = 7;
        acc01 = 85;
        target01 = true;
        atkType01 = 0;
        dmgType01 = 3;
        dmg01 = 25;
        status01 = 3;
        buff01 = false;

        attackTwoName = "Flame Slash";
        Type02 = 1;
        acc02 = 95;
        target02 = true;
        atkType02 = 0;
        dmgType02 = 0;
        dmg02 = 30;
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

        attackFourName = "Agility";
        Type04 = 0;
        acc04 = 95;
        target04 = true;
        atkType04 = 1;
        dmgType04 = 4;
        dmg04 = 50;
        status04 = 0;
        buff04 = true;




        attackFiveName = "Goad";
        Type05 = 6;
        acc05 = 80;
        target05 = true;
        atkType05 = 1;
        dmgType05 = 0;
        dmg05 = 100;
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
