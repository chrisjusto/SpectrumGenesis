using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharClass : MonoBehaviour {

    public Types.Char CharIndex;
    public string Name;

    public int Exp;
    public int ExpToNextLVL;
    public int LVL;

    public Types.WeaponClass WeaponClass;

    public Types.CharTyping[] Type = new Types.CharTyping[2];
    public Types.CharTyping[] Weakness = new Types.CharTyping[5];
    public Types.CharTyping[] Strength = new Types.CharTyping[5];

    public Types.Spells[] LearnableSpells = new Types.Spells[10];
    public Types.Spells[] LearnedSpells = new Types.Spells[10];
    public Types.Spells[] EquipedSpells = new Types.Spells[4];
    public int[] SpellUses = new int[4];

    public Types.Armor EquipedArmor;

    public Types.Weapon EquipedWeapon;

    public Types.Ability CharAbility;

    public int HP;
    public int ATK;
    public int DEF;
    public int sATK;
    public int sDEF;
    public int SPD;
    public float ACCMOD;
    public float ATKMOD;
    public float DEFMOD;
    public float SATKMOD;
    public float SDEFMOD;
    public float SPDMOD;

    public int MaxHP;
    public int CurrentHP;

    public Sprite FrontSprite;
    public Sprite BackSprite;
    public Sprite Portrait;

}
