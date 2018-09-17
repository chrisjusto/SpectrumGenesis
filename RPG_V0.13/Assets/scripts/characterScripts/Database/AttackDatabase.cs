using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackDatabase : MonoBehaviour {

    public static AttackDatabase attacks;


    public string[] AttackName = new string[33] { "", "OriginSlash", "Sharpen", "Psychic Blade", "Scortch", "Block", "Stone Armour", "Earth Bash", "Taunt", "psychic shot", "poison arrow", "Bear Trap", "Elvish Song", "thunder storm", "meditate","gust","grave Blast","swift strike","scoff","only punch","hone mind","psychic torment","Phycic shock","beam cannon","hone mind","ice shard","healing light","holy fire","blessing","triple strike","darkness","paralyze powder","cheep shot" };
    public string[] AttackType = new string[33] {"","archane","Normal","psychic","fire","normal","Earth","Earth","Dark","psychic","Nature","normal","light","electric","psychic","air","dark","air","normal","normal","psychic","psychic","psychic","archane","psychic","ice","light","fire","light","normal","dark","nature","dark" };
    public int[] AttackTypeValue = new int[33];
    public string[] AttackPowerAcc = new string[33];
    public int[] AttackUses = new int[33];
    public string[] AttackDesc = new string[33];
    public bool[] AttackPriority = new bool[33];
    public bool[] AttackSuperPriority = new bool[33];

    void Awake()
    {
        
        if (attacks == null)
        {
            attacks = this;
        }
        else if (attacks != this)
        {

        }
        // 0 = none 1 =normal 2=fire 3=water 4=nature 5=earth 6=air 7=ice 8=electric 9=light 10=dark 11=psychic 12=archane 13=celestial
        AttackName[1] = "origin slash";
        AttackType[1] = "Archane";
        AttackPowerAcc[1] = "60/100";
        AttackUses[1] = 15;
        AttackDesc[1] = "a swift slash drawing from ancient archane power";
        AttackTypeValue[1] = 12;

        AttackName[2] = "sharpen";
        AttackType[2] = "normal";
        AttackPowerAcc[2] = "x/100";
        AttackUses[2] = 20;
        AttackDesc[2] = "raises users attack";
        AttackTypeValue[2] = 1;

        AttackName[3] = "Psychic blade";
        AttackType[3] = "psychic";
        AttackPowerAcc[3] = "40/100";
        AttackUses[3] = 20;
        AttackDesc[3] = "psychic energy with the percision to slice hairs";
        AttackTypeValue[3] = 11;

        AttackName[4] = "Scortch";
        AttackType[4] = "fire";
        AttackPowerAcc[4] = "x/85";
        AttackUses[4] = 10;
        AttackDesc[4] = "inflicts target with burn";
        AttackTypeValue[4] = 2;

        AttackName[5] = "block";
        AttackType[5] = "Normal";
        AttackPowerAcc[5] = "x/100";
        AttackUses[5] = 5;
        AttackDesc[5] = "always takes priority, blocks an attack, repeat uses may fail";
        AttackPriority[5] = true;
        AttackTypeValue[5] = 1;

        AttackName[6] = "stone armor";
        AttackType[6] = "earth";
        AttackPowerAcc[6] = "x/100";
        AttackUses[6] = 15;
        AttackDesc[6] = "coats the user in an aura with the strength of stone greatly raising there defense";
        AttackTypeValue[6] = 5;

        AttackName[7] = "earth bash";
        AttackType[7] = "earth";
        AttackPowerAcc[7] = "60/100";
        AttackUses[7] = 15;
        AttackDesc[7] = "with the weight of the strongest boulder the user smashes into the target";
        AttackTypeValue[7] = 5;

        AttackName[8] = "Taunt";
        AttackType[8] = "dark";
        AttackPowerAcc[8] = "x/100";
        AttackUses[8] = 10;
        AttackDesc[8] = "taunts the target forcing them to only use damaging moves";
        AttackTypeValue[8] = 10;

        AttackName[9] = "psychic shot";
        AttackType[9] = "psychic";
        AttackPowerAcc[9] = "120/100";
        AttackUses[9] = 5;
        AttackDesc[9] = "the user stabalizes there aim taking one turn to charge launching a powerful shot";

        AttackName[10] = "Poison Arrow";
        AttackType[10] = "Nature";
        AttackPowerAcc[10] = "30/100";
        AttackUses[10] = 20;
        AttackDesc[10] = "shoot a poison tipped arrow with a 25% chance to poinson the target";

        AttackName[11] = "bear trap";
        AttackType[11] = "normal";
        AttackPowerAcc[11] = "x/50";
        AttackUses[11] = 5;
        AttackDesc[11] = "target does not get an action on the next turn";

        AttackName[12] = "elvish song";
        AttackType[12] = "light";
        AttackPowerAcc[12] = "x/100";
        AttackUses[12] = 10;
        AttackDesc[12] = "call upon the old elvish divine to heal the user";

        AttackName[13] = "thunder storm";
        AttackType[13] = "electric";
        AttackPowerAcc[13] = "40/100";
        AttackUses[13] = 10;
        AttackDesc[13] = "a storm of lightning that always hits his mark, all of the active players";

        AttackName[14] = "meditate";
        AttackType[14] = "psychic";
        AttackPowerAcc[14] = "x/100";
        AttackUses[14] = 20;
        AttackDesc[14] = "calm ones mind to raise special attack and defense";

        AttackName[15] = "gust";
        AttackType[15] = "air";
        AttackPowerAcc[15] = "40/100";
        AttackUses[15] = 10;
        AttackDesc[15] = "switches target out with another random party member";

        AttackName[16] = "grave energy";
        AttackType[16] = "dark";
        AttackPowerAcc[16] = "80/100";
        AttackUses[16] = 5;
        AttackDesc[16] = "make a pact with the dark gods to deal a powerful blast of energy at the cost of users own defense";

        AttackName[17] = "swift strike";
        AttackType[17] = "normal";
        AttackPowerAcc[17] = "40/100";
        AttackUses[17] = 15;
        AttackDesc[17] = "with nimble percision the user hits the target, this attack always goes first";
        AttackPriority[17] = true;

        AttackName[18] = "scoff";
        AttackType[18] = "normal";
        AttackPowerAcc[18] = "x/100";
        AttackUses[18] = 15;
        AttackDesc[18] = "the user mocks the opponent lowering their defense";

        AttackName[19] = "only punch";
        AttackType[19] = "normal";
        AttackPowerAcc[19] = "120/100";
        AttackUses[19] = 5;
        AttackDesc[19] = "focus all of the users fighting power into a single punch, takes one turn to charge";

        AttackName[20] = "hone body";
        AttackType[20] = "normal";
        AttackPowerAcc[20] = "x/100";
        AttackUses[20] = 10;
        AttackDesc[20] = "the user looks deep within to raise there attack";

        AttackName[21] = "psychic torment";
        AttackType[21] = "psychic";
        AttackPowerAcc[21] = "x/100";
        AttackUses[21] = 10;
        AttackDesc[21] = "the user torments the mind of the target lowering their special defense";

        AttackName[22] = "psychic shock";
        AttackType[22] = "psychic";
        AttackPowerAcc[22] = "40/100";
        AttackUses[22] = 15;
        AttackDesc[22] = "the users invades the mind of the target invoking real life pain that has a 5% chance to parlyze";

        AttackName[23] = "beam cannon";
        AttackType[23] = "archane";
        AttackPowerAcc[23] = "90/85";
        AttackUses[23] = 5;
        AttackDesc[23] = "user shoots a powerful beam, a technic known throughout the ages";

        AttackName[24] = "psychic defense";
        AttackType[24] = "psychic";
        AttackPowerAcc[24] = "x/100";
        AttackUses[24] = 5;
        AttackDesc[24] = "create a wall of psychic energy raising the users special defense";

        AttackName[25] = "ice shard";
        AttackType[25] = "ice";
        AttackPowerAcc[25] = "40/100";
        AttackUses[25] = 15;
        AttackDesc[25] = "launch a shard of ice at the target with a 5% chance to freeze them";

        AttackName[26] = "healing tag";
        AttackType[26] = "light";
        AttackPowerAcc[26] = "x/100";
        AttackUses[26] = 5;
        AttackDesc[26] = "call upon a teamate to replace the user in battle healing them";

        AttackName[27] = "holy fire";
        AttackType[27] = "fire";
        AttackPowerAcc[27] = "60/100";
        AttackUses[27] = 15;
        AttackDesc[27] = "the user calls upon the fire of the gods, unfortunatly the divine touch does have a chance to cure status effects";

        AttackName[28] = "blessing";
        AttackType[28] = "light";
        AttackPowerAcc[28] = "x/100";
        AttackUses[28] = 10;
        AttackDesc[28] = "the user blesses the party, raising everybodys special defense for 5 turns";

        AttackName[29] = "triple strike";
        AttackType[29] = "normal";
        AttackPowerAcc[29] = "15/100";
        AttackUses[29] = 20;
        AttackDesc[29] = "the user unleashes a nimble strike allowing for 3 hits before the target can use an attack";

        AttackName[30] = "darkness";
        AttackType[30] = "dark";
        AttackPowerAcc[30] = "x/100";
        AttackUses[30] = 10;
        AttackDesc[30] = "shrouds the battlefield in darkness lowering the accuracy of all non-dark types for 5 turns";

        AttackName[31] = "paralyze powder";
        AttackType[31] = "nature";
        AttackPowerAcc[31] = "x/85";
        AttackUses[31] = 10;
        AttackDesc[31] = "a special poison that parlyzes the taget";

        AttackName[32] = "cheep shot";
        AttackType[32] = "dark";
        AttackPowerAcc[32] = "20/100";
        AttackUses[32] = 15;
        AttackDesc[32] = "the user sucker punches the target, always going first (even if the target is swutching out)";
        AttackSuperPriority[32] = true;




    }
}
