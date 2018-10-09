using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharClass : MonoBehaviour {

    public string Name;
    public int Exp;
    public int ExpToNextLVL;
    public int LVL;
    public Types.CharTyping[] Type = new Types.CharTyping[2];
    public Types.CharTyping[] Weakness = new Types.CharTyping[5];
    public Types.CharTyping[] Strength = new Types.CharTyping[5];
    public int[] LearnableSpells = new int[10];
    public int[] LearnedSpells = new int[10];
    public int[] EquipedSpells = new int[4];
    public WhatWeapon.Weapon WeaponClass;








}
