using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyClass : MonoBehaviour {


    public string Name;
    public int LVL;

    // 0=Normal 1=Fire 2=Water 3=Ice 4=Dark 5=Light 6=Psycic 7=Electric

    public int myType;
    public int[] typeWeekness;
    public int[] typeStrength;

    public float HP;
    public float ATK;
    public float DEF;
    public float sATK;
    public float sDEF;
    public float SPD;


    public float currentHealth;
    public float maxHealth;


    public Sprite charSprite;



    public bool isActive;

    //attackName

    public string attackOneName;
    public string attackTwoName;
    public string attackThreeName;
    public string attackFourName;
    public string attackFiveName;

    //see myType for chart

    public int Type01;
    public int Type02;
    public int Type03;
    public int Type04;
    public int Type05;

    // accuracy

    public float acc01;
    public float acc02;
    public float acc03;
    public float acc04;
    public float acc05;

    //target = true (target the enemy)

    public bool target01;
    public bool target02;
    public bool target03;
    public bool target04;
    public bool target05;

    // type of move 0=attack 1=status effect 2=heal

    public int atkType01;
    public int atkType02;
    public int atkType03;
    public int atkType04;
    public int atkType05;

    //damage type 0=atk 1=def 2=sAtk 3=sDef 4=SPD 

    public int dmgType01;
    public int dmgType02;
    public int dmgType03;
    public int dmgType04;
    public int dmgType05;

    //amount of power an attack has (if status effect how much a stat is boosted or hp healed)

    public float dmg01;
    public float dmg02;
    public float dmg03;
    public float dmg04;
    public float dmg05;

    //status effect implimented( if attached to attack 5% chance if attached to status effect 100% chance
    // 0=none 1=burn 2=freeze 3=paralyze

    public int status01;
    public int status02;
    public int status03;
    public int status04;
    public int status05;




    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
