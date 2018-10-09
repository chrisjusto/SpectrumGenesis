using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharAbel : CharClass {


    void Awake()
    {
        CharIndex = Types.Char.Abel;
        Name = "Abel";

        LVL = 100;
        Exp = 0;
        ExpToNextLVL = LVL * 10000;

        WeaponClass = Types.WeaponClass.SwordAndShield;

        Type[0] = Types.CharTyping.Fire;
        Type[1] = Types.CharTyping.None;

        Weakness[0] = Types.CharTyping.Water;
        Weakness[1] = Types.CharTyping.Earth;
        Weakness[2] = Types.CharTyping.Air;

        Strength[0] = Types.CharTyping.Nature;
        Strength[1] = Types.CharTyping.Ice;

        LearnableSpells[0] = Types.Spells.Block;
        LearnableSpells[1] = Types.Spells.HolyFire;
        LearnableSpells[2] = Types.Spells.FlameSlash;
        LearnableSpells[3] = Types.Spells.OriginSlash;
        LearnableSpells[4] = Types.Spells.Sharpen;
        LearnableSpells[5] = Types.Spells.PsychicBlade;
        LearnableSpells[6] = Types.Spells.Scortch;

        LearnedSpells[0] = Types.Spells.Block;
        LearnedSpells[1] = Types.Spells.HolyFire;
        LearnedSpells[2] = Types.Spells.FlameSlash;
        LearnedSpells[3] = Types.Spells.OriginSlash;
        LearnedSpells[4] = Types.Spells.Sharpen;
        LearnedSpells[5] = Types.Spells.PsychicBlade;
        LearnedSpells[6] = Types.Spells.Scortch;

        EquipedSpells[0] = Types.Spells.OriginSlash;
        EquipedSpells[1] = Types.Spells.Sharpen;
        EquipedSpells[2] = Types.Spells.PsychicBlade;
        EquipedSpells[3] = Types.Spells.Scortch;

        EquipedArmor = Types.Armor.PrincesGarb;
        EquipedWeapon = Types.Weapon.PrincesSword;

        CharAbility = Types.Ability.Adaptability;

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

        MaxHP = HP * 2;
        CurrentHP = HP * 2;

        var Sprite = Resources.LoadAll<Sprite>("CharSprite/front/frontSprite_normal");
        FrontSprite = Sprite[0];
        Sprite = Resources.LoadAll<Sprite>("CharSprite/back/backSprite_normal");
        BackSprite = Sprite[0];
        Sprite = Resources.LoadAll<Sprite>("CharSprite/portrait/Portraits");
        Portrait = Sprite[0];



    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
