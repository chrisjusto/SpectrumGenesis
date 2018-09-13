using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackDatabase : MonoBehaviour {

    public static AttackDatabase attacks;


    public string[] AttackName = new string[33] { "", "OriginSlash", "Sharpen", "Psychic Blade", "Scortch", "Block", "Stone Armour", "Earth Bash", "Taunt", "psychic shot", "poison arrow", "Bear Trap", "Elvish Song", "thunder storm", "meditate","gust","grave Blast","swift strike","scoff","only punch","hone mind","psychic torment","Phycic shock","beam cannon","hone mind","ice shard","healing light","holy fire","blessing","triple strike","darkness","paralyze powder","cheep shot" };
    public string[] AttackType = new string[33] {"","archane","Normal","psychic","fire","normal","Earth","Earth","Dark","psychic","Nature","normal","light","electric","psychic","air","dark","air","normal","normal","psychic","psychic","psychic","archane","psychic","ice","light","fire","light","normal","dark","nature","dark" };
    public string[] AttackPowerAcc = new string[33];
    public int[] AttackUses = new int[33];
    public string[] AttackDesc = new string[33];

    void Awake()
    {
        
        if (attacks == null)
        {
            attacks = this;
        }
        else if (attacks != this)
        {

        }

        AttackName[1] = "origin slash";
        AttackType[1] = "Archane";
        AttackPowerAcc[1] = "60/100";
        AttackUses[1] = 15;
        AttackDesc[1] = "a swift slash drawing from ancient archane power";

        AttackName[2] = "sharpen";
        AttackType[2] = "normal";
        AttackPowerAcc[2] = "x/100";
        AttackUses[2] = 20;
        AttackDesc[2] = "raises users attack";

        AttackName[3] = "Psychic blade";
        AttackType[3] = "psychic";
        AttackPowerAcc[3] = "40/100";
        AttackUses[3] = 20;
        AttackDesc[3] = "psychic energy with the percision to slice hairs";

        AttackName[4] = "Scortch";
        AttackType[4] = "fire";
        AttackPowerAcc[4] = "x/85";
        AttackUses[4] = 10;
        AttackDesc[4] = "inflicts target with burn";












    }
}
