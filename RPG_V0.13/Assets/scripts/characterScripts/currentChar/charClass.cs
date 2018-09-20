using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity;



public class charClass : MonoBehaviour {

    public partyManager party;

    public string Name;
    public int LVL;

    // 0 = none 1 =normal 2=fire 3=water 4=nature 5=earth 6=air 7=ice 8=electric 9=light 10=dark 11=psychic 12=archane 13=celestial

    public int PrimaryType;
    public int SecondaryType;

    public int Weapon;
    public int Equipment;
    public int ability;
    public int Attack01;
    public int Attack02;
    public int Attack03;
    public int Attack04;
    public int[] EquipedAttacks = new int[4];
    public int[] attackUses = new int[4];


    public Sprite typeSprite01;
    public Sprite typeSprite02;


    public int myType;
    public int[] typeWeekness = new int[13];
    public int[] typeStrength = new int[13];

    public float HP;
    public float ATK;
    public float DEF;
    public float sATK;
    public float sDEF;
    public float SPD;

    public int xp;
    public int xpToNextLvl;

    public float currentHealth;
    public float maxHealth;

    public string frontSprite;
    public string backSprite;
    public Sprite portrait;

    //mofifiers

    public float ACCMOD = 1;
    public float ATKMOD = 1;
    public float DEFMOD = 1;
    public float SDEFMOD = 1;
    public float SATKMOD = 1;
    public float SPDMOD = 1;

    public float baseATK;
    public float baseDEF;
    public float baseSDEF;
    public float baseSATK;
    public float baseSPD;

    //status effects 0=none 1=burn 2=poison 3=sleep 4=freeze 5=paralyze
    public int StatusEffect;
    public bool charging;
    public bool blocked;
    public bool hasBlockedThisRound;


    /// <summary>
    /// ////////
    /// </summary>

    public Sprite charSprite;
    public string spriteLocation;
    public SpriteRenderer spriteR;

    public bool dead;

    public bool isActive;

    public int attack01;
    public int attack02;
    public int attack03;
    public int attack04;
    public int attack05;

    public int armour;
    public int weapon;


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

    // type of move 0=attack 1=buff/debuff effect 2=heal

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


    public bool buff01;
    public bool buff02;
    public bool buff03;
    public bool buff04;
    public bool buff05;













    // Use this for initialization
    void Start () {
    
       

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ActivatePlayer(bool Active)
    {

        if (Active == false)
        {
            charSprite = Resources.Load<Sprite>(spriteLocation);

            spriteR = gameObject.GetComponent<SpriteRenderer>();

            spriteR.sprite = charSprite;

            isActive = true;
        }

        else
        {
            isActive = false;
        }

    }
    //public void SetAttacksLeft()
    //{
    //    foreach (int uses in attackUses)
    //    {
    //        attackUses[uses] = AttackDatabase.attacks.AttackUses[uses];
    //    }

    //}

    public void Ability()
    {

    }

    // public void ActivateCharacter()
    //{
    // Debug.Log("noAcvtivePlayer");

    //  }

}


