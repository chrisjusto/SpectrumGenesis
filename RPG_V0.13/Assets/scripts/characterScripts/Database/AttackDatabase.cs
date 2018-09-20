using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackDatabase : MonoBehaviour {

    public static AttackDatabase attacks;

    //MOVES THAT NEED TWEEKING GUST! TAUNT! HEALING TAG!


    public string[] AttackName = new string[33] { "", "OriginSlash", "Sharpen", "Psychic Blade", "Scortch", "Block", "Stone Armour", "Earth Bash", "Taunt", "psychic shot", "poison arrow", "Bear Trap", "Elvish Song", "thunder storm", "meditate","gust","grave Blast","swift strike","scoff","only punch","hone mind","psychic torment","Phycic shock","beam cannon","hone mind","ice shard","healing light","holy fire","blessing","triple strike","darkness","paralyze powder","cheep shot" };
    public string[] AttackType = new string[33] {"","archane","Normal","psychic","fire","normal","Earth","Earth","Dark","psychic","Nature","normal","light","electric","psychic","air","dark","air","normal","normal","psychic","psychic","psychic","archane","psychic","ice","light","fire","light","normal","dark","nature","dark" };
    public int[] AttackTypeValue = new int[33];
    public string[] AttackPowerAcc = new string[33];
    public int[] AttackUses = new int[33];
    public string[] AttackDesc = new string[33];
    public bool[] AttackPriority = new bool[33];
    public bool[] AttackSuperPriority = new bool[33];
    public float stab;
    public float effective;
    public string wasEffective;

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
        AttackDesc[8] = "ATTACK NOT AVAILABLE";
        AttackTypeValue[8] = 10;

        AttackName[9] = "psychic shot";
        AttackType[9] = "psychic";
        AttackPowerAcc[9] = "120/100";
        AttackUses[9] = 5;
        AttackDesc[9] = "the user stabalizes there aim taking one turn to charge launching a powerful shot";
        AttackTypeValue[9] = 11;

        AttackName[10] = "Poison Arrow";
        AttackType[10] = "Nature";
        AttackPowerAcc[10] = "30/100";
        AttackUses[10] = 20;
        AttackDesc[10] = "shoot a poison tipped arrow with a 25% chance to poinson the target";
        AttackTypeValue[10] = 4;

        AttackName[11] = " frozen bear trap";
        AttackType[11] = "ice";
        AttackPowerAcc[11] = "x/50";
        AttackUses[11] = 5;
        AttackDesc[11] = "freeze target";
        AttackTypeValue[11] = 7;

        AttackName[12] = "elvish song";
        AttackType[12] = "light";
        AttackPowerAcc[12] = "x/100";
        AttackUses[12] = 10;
        AttackDesc[12] = "call upon the old elvish divine to heal the user";
        AttackTypeValue[12] = 9;

        AttackName[13] = "thunder storm";
        AttackType[13] = "electric";
        AttackPowerAcc[13] = "40/100";
        AttackUses[13] = 10;
        AttackDesc[13] = "a storm of lightning that always hits his mark, all of the active players";
        AttackTypeValue[13] = 8;

        AttackName[14] = "meditate";
        AttackType[14] = "psychic";
        AttackPowerAcc[14] = "x/100";
        AttackUses[14] = 20;
        AttackDesc[14] = "calm ones mind to raise special attack and defense";
        AttackTypeValue[14] = 11;

        AttackName[15] = "gust";
        AttackType[15] = "air";
        AttackPowerAcc[15] = "40/100";
        AttackUses[15] = 10;
        AttackDesc[15] = "attack not available";
        AttackTypeValue[15] = 6;

        AttackName[16] = "grave energy";
        AttackType[16] = "dark";
        AttackPowerAcc[16] = "80/100";
        AttackUses[16] = 5;
        AttackDesc[16] = "make a pact with the dark gods to deal a powerful blast of energy at the cost of users own defense";
        AttackTypeValue[16] = 10;

        AttackName[17] = "swift strike";
        AttackType[17] = "normal";
        AttackPowerAcc[17] = "40/100";
        AttackUses[17] = 15;
        AttackDesc[17] = "with nimble percision the user hits the target, this attack always goes first";
        AttackPriority[17] = true;
        AttackTypeValue[17] = 1;

        AttackName[18] = "scoff";
        AttackType[18] = "normal";
        AttackPowerAcc[18] = "x/100";
        AttackUses[18] = 15;
        AttackDesc[18] = "the user mocks the opponent lowering their defense";
        AttackTypeValue[18] = 1;

        AttackName[19] = "only punch";
        AttackType[19] = "normal";
        AttackPowerAcc[19] = "120/100";
        AttackUses[19] = 5;
        AttackDesc[19] = "focus all of the users fighting power into a single punch, takes one turn to charge";
        AttackTypeValue[19] = 1;

        AttackName[20] = "hone body";
        AttackType[20] = "normal";
        AttackPowerAcc[20] = "x/100";
        AttackUses[20] = 10;
        AttackDesc[20] = "the user looks deep within to raise there attack";
        AttackTypeValue[20] = 1;

        AttackName[21] = "psychic torment";
        AttackType[21] = "psychic";
        AttackPowerAcc[21] = "x/100";
        AttackUses[21] = 10;
        AttackDesc[21] = "the user torments the mind of the target lowering their special defense";
        AttackTypeValue[21] = 11;

        AttackName[22] = "psychic shock";
        AttackType[22] = "psychic";
        AttackPowerAcc[22] = "40/100";
        AttackUses[22] = 15;
        AttackDesc[22] = "the users invades the mind of the target invoking real life pain";
        AttackTypeValue[22] = 11;

        AttackName[23] = "beam cannon";
        AttackType[23] = "archane";
        AttackPowerAcc[23] = "90/85";
        AttackUses[23] = 5;
        AttackDesc[23] = "user shoots a powerful beam, a technic known throughout the ages";
        AttackTypeValue[23] = 12;

        AttackName[24] = "psychic defense";
        AttackType[24] = "psychic";
        AttackPowerAcc[24] = "x/100";
        AttackUses[24] = 5;
        AttackDesc[24] = "create a wall of psychic energy raising the users special defense";
        AttackTypeValue[24] = 11;

        AttackName[25] = "ice shard";
        AttackType[25] = "ice";
        AttackPowerAcc[25] = "40/100";
        AttackUses[25] = 15;
        AttackDesc[25] = "launch a shard of ice at the target with a 5% chance to freeze them";
        AttackTypeValue[25] = 7;

        AttackName[26] = "healing tag";
        AttackType[26] = "light";
        AttackPowerAcc[26] = "x/100";
        AttackUses[26] = 5;
        AttackDesc[26] = "attack not available";
        AttackTypeValue[26] = 9;

        AttackName[27] = "holy fire";
        AttackType[27] = "fire";
        AttackPowerAcc[27] = "60/100";
        AttackUses[27] = 15;
        AttackDesc[27] = "the user calls upon the fire of the gods, unfortunatly the divine touch does have a chance to cure status effects";
        AttackTypeValue[27] = 2;

        AttackName[28] = "blessing";
        AttackType[28] = "light";
        AttackPowerAcc[28] = "x/100";
        AttackUses[28] = 10;
        AttackDesc[28] = "the user blesses the party, raising everybodys special defense for 5 turns";
        AttackTypeValue[28] = 9;

        AttackName[29] = "triple strike";
        AttackType[29] = "normal";
        AttackPowerAcc[29] = "15/100";
        AttackUses[29] = 20;
        AttackDesc[29] = "the user unleashes a nimble strike allowing for 3 hits before the target can use an attack";
        AttackTypeValue[29] = 1;

        AttackName[30] = "darkness";
        AttackType[30] = "dark";
        AttackPowerAcc[30] = "x/100";
        AttackUses[30] = 10;
        AttackDesc[30] = "reduce the accuracy of the target";
        AttackTypeValue[30] = 10;

        AttackName[31] = "sleep powder";
        AttackType[31] = "nature";
        AttackPowerAcc[31] = "x/85";
        AttackUses[31] = 10;
        AttackDesc[31] = "a special poison that puts the target to sleep";
        AttackTypeValue[231] = 4;

        AttackName[32] = "cheep shot";
        AttackType[32] = "dark";
        AttackPowerAcc[32] = "20/100";
        AttackUses[32] = 15;
        AttackDesc[32] = "the user sucker punches the target, always going first (even if the target is swutching out)";
        AttackSuperPriority[32] = true;
        AttackTypeValue[32] = 10;




    }


    public void Attack(charClass AttackingPlayer, charClass DefendingPlayer, int SelectedAttack, GameObject resaultstext, BattleManager Manager)
    {

        switch (SelectedAttack)
        {
            case 1:

                //ORIGIN SLASH 60/100 ARCHANE 20 USES

                var attackDamage = 60;

                var Damage = (((AttackingPlayer.LVL + attackDamage) * 2) * (AttackingPlayer.ATK / DefendingPlayer.DEF)) / 3;

                var Type = AttackTypeValue[1];

                // DID ATTACK HIT?
                if ((100 + AttackingPlayer.ACCMOD) >= Random.Range(1, 100))
                {
                    if (Type == AttackingPlayer.Type01 || Type == AttackingPlayer.Type02)
                    {
                        stab = 1.5F;
                    }
                    else if (Type != AttackingPlayer.Type01 && Type != AttackingPlayer.Type02)
                    {
                        stab = 1;
                    }
                    foreach (int n in DefendingPlayer.typeWeekness)
                    {
                        if (n == 0)
                        {

                        }
                        else if (n != 0)
                        {
                            if (n == Type)
                            {
                                effective = 2;
                                wasEffective = "super effective";

                                break;
                            }
                            else if (n != Type)
                            {
                                effective = 1;
                                wasEffective = "effective";
                            }
                        }

                    }
                    if (effective != 2)
                    {
                        foreach (int n in DefendingPlayer.typeStrength)
                        {
                            if (n == Type)
                            {
                                effective = 0.5F;
                                wasEffective = "not very effective";
                                break;
                            }
                            else if (n != Type)
                            {
                                effective = 1;
                                wasEffective = "effective";
                            }
                        }
                    }

                    var critChance = 95;
                    var crit = 1F;

                    if (critChance > Random.Range(0, 100))
                    {
                        crit = 1.5F;
                    }
                    else
                    {
                        crit = 1F;
                    }


                    var finalDamage = Damage * effective * stab * crit;

                    DefendingPlayer.currentHealth = DefendingPlayer.currentHealth - finalDamage;

                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[1] + " is was " + wasEffective + "!";

                    if (DefendingPlayer.currentHealth < 0)
                    {
                        DefendingPlayer.currentHealth = 0;
                    }

                }
                else
                {
                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[1] + ",  and missed";
                }

                break;
            case 2:
                //SHARPEN X/100 20 USES NORMAL INCREASES ATTACK .2 (MAX INCREASE .8)(4 USES)

                var BaseIncerase = 0.2F;
                var actualIncrease = 1.2F;

                if (AttackingPlayer.ATKMOD == 2.6)
                {
                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used sharpen, and it failed!";
                }
                else
                {
                    AttackingPlayer.ATKMOD = AttackingPlayer.ATKMOD + BaseIncerase;

                    AttackingPlayer.ATK = AttackingPlayer.ATK * actualIncrease;

                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used sharpen, and raised their attack!";

                }
                break;
            case 3:
                //PSYCHIC BLADE PSYCHIC 40/100 20USES 11

                attackDamage = 40;

                Damage = (((AttackingPlayer.LVL + attackDamage) * 2) * (AttackingPlayer.ATK / DefendingPlayer.DEF)) / 3;

                Type = AttackTypeValue[3];

                // DID ATTACK HIT?
                if ((100 + AttackingPlayer.ACCMOD) >= Random.Range(1, 100))
                {
                    if (Type == AttackingPlayer.Type01 || Type == AttackingPlayer.Type02)
                    {
                        stab = 1.5F;
                    }
                    else if (Type != AttackingPlayer.Type01 && Type != AttackingPlayer.Type02)
                    {
                        stab = 1;
                    }
                    foreach (int n in DefendingPlayer.typeWeekness)
                    {
                        if (n == 0)
                        {

                        }
                        else if (n != 0)
                        {
                            if (n == Type)
                            {
                                effective = 2;
                                wasEffective = "super effective";

                                break;
                            }
                            else if (n != Type)
                            {
                                effective = 1;
                                wasEffective = "effective";
                            }
                        }

                    }
                    if (effective != 2)
                    {
                        foreach (int n in DefendingPlayer.typeStrength)
                        {
                            if (n == Type)
                            {
                                effective = 0.5F;
                                wasEffective = "not very effective";
                                break;
                            }
                            else if (n != Type)
                            {
                                effective = 1;
                                wasEffective = "effective";
                            }
                        }
                    }

                    var critChance = 95;
                    var crit = 1F;

                    if (critChance > Random.Range(0, 100))
                    {
                        crit = 1.5F;
                    }
                    else
                    {
                        crit = 1F;
                    }


                    var finalDamage = Damage * effective * stab * crit;

                    DefendingPlayer.currentHealth = DefendingPlayer.currentHealth - finalDamage;

                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[3] + " is was " + wasEffective + "!";

                    if (DefendingPlayer.currentHealth < 0)
                    {
                        DefendingPlayer.currentHealth = 0;
                    }

                }
                else
                {
                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[3] + ",  and missed";
                }

                break;
            case 4:
                //SCORTCH FIRE X/85 USES 10 INFLICTS TARGET WITH BURN

                if (DefendingPlayer.StatusEffect != 0)
                {
                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[4] + " and failed!";
                }
                else if (DefendingPlayer.StatusEffect == 0)
                {
                    if (Random.Range(0,100) < 85) //ATTACK HIT
                    {
                        DefendingPlayer.StatusEffect = 1;
                        resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[4] + " and " + DefendingPlayer.Name + " has been burned!";

                    }
                    else // ATTACK MISSED
                    {
                        resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[4] + " and failed!";
                    }
                }
                break;
            case 5:
                //BLOCK X/100 normal blocks a weapon based attack, may fail on repeat uses

                if (AttackingPlayer.hasBlockedThisRound == false)
                {
                    AttackingPlayer.blocked = true;
                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " has prepaired a block!";

                }
                else if (AttackingPlayer.hasBlockedThisRound == true)
                {
                    if (Random.Range (1,100) > 50)
                    {
                        AttackingPlayer.blocked = true;
                        resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " has prepaired a block!";
                    }
                    else
                    {
                        resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + "'s prepaired block has failed!";
                    }
                }
                break;
            case 6:
                //STONE ARMOUR EARTH X/100 15 USES RAISES DEFENSE .4
                BaseIncerase = 0.4F;
                actualIncrease = 1.4F;

                if (AttackingPlayer.DEFMOD == 2.6)
                {
                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[6] +  " and it failed!";
                }
                else
                {
                    AttackingPlayer.DEFMOD = AttackingPlayer.DEFMOD + BaseIncerase;

                    AttackingPlayer.DEF = AttackingPlayer.DEF * actualIncrease;

                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[6] + ", and raised their DEFENSE GREATLY!";

                }
                break;
            case 7:
                //EARTH BASH
                attackDamage = 60;

                Damage = (((AttackingPlayer.LVL + attackDamage) * 2) * (AttackingPlayer.ATK / DefendingPlayer.DEF)) / 3;

                Type = AttackTypeValue[7];

                // DID ATTACK HIT?
                if ((100 + AttackingPlayer.ACCMOD) >= Random.Range(1, 100))
                {
                    if (Type == AttackingPlayer.Type01 || Type == AttackingPlayer.Type02)
                    {
                        stab = 1.5F;
                    }
                    else if (Type != AttackingPlayer.Type01 && Type != AttackingPlayer.Type02)
                    {
                        stab = 1;
                    }
                    foreach (int n in DefendingPlayer.typeWeekness)
                    {
                        if (n == 0)
                        {

                        }
                        else if (n != 0)
                        {
                            if (n == Type)
                            {
                                effective = 2;
                                wasEffective = "super effective";

                                break;
                            }
                            else if (n != Type)
                            {
                                effective = 1;
                                wasEffective = "effective";
                            }
                        }

                    }
                    if (effective != 2)
                    {
                        foreach (int n in DefendingPlayer.typeStrength)
                        {
                            if (n == Type)
                            {
                                effective = 0.5F;
                                wasEffective = "not very effective";
                                break;
                            }
                            else if (n != Type)
                            {
                                effective = 1;
                                wasEffective = "effective";
                            }
                        }
                    }

                    var critChance = 95;
                    var crit = 1F;

                    if (critChance > Random.Range(0, 100))
                    {
                        crit = 1.5F;
                    }
                    else
                    {
                        crit = 1F;
                    }


                    var finalDamage = Damage * effective * stab * crit;

                    DefendingPlayer.currentHealth = DefendingPlayer.currentHealth - finalDamage;

                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[7] + " is was " + wasEffective + "!";

                    if (DefendingPlayer.currentHealth < 0)
                    {
                        DefendingPlayer.currentHealth = 0;
                    }

                }
                else
                {
                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[7] + ",  and missed";
                }
                break;
            case 9:
                if (AttackingPlayer.charging == true)
                {
                    attackDamage = 120;

                    Damage = (((AttackingPlayer.LVL + attackDamage) * 2) * (AttackingPlayer.sATK / DefendingPlayer.sDEF)) / 3;

                    Type = AttackTypeValue[9];

                    if (DefendingPlayer.blocked == true)
                    {
                        resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " has used " + AttackName[9] + ", but " + DefendingPlayer.Name + "has blocked the attack!";
                    }
                    else if (DefendingPlayer.blocked == false)
                    {
                        // DID ATTACK HIT?
                        if ((100 + AttackingPlayer.ACCMOD) >= Random.Range(1, 100))
                        {
                            if (Type == AttackingPlayer.Type01 || Type == AttackingPlayer.Type02)
                            {
                                stab = 1.5F;
                            }
                            else if (Type != AttackingPlayer.Type01 && Type != AttackingPlayer.Type02)
                            {
                                stab = 1;
                            }
                            foreach (int n in DefendingPlayer.typeWeekness)
                            {
                                if (n == Type)
                                {
                                    effective = 2;
                                    wasEffective = "super effective";
                                    break;
                                }
                                else if (n != Type)
                                {
                                    effective = 1;
                                    wasEffective = "effective";
                                }



                            }
                            if (effective != 2)
                            {
                                foreach (int n in DefendingPlayer.typeStrength)
                                {
                                    if (n == Type)
                                    {
                                        effective = 0.5F;
                                        wasEffective = "not very effective";
                                        break;
                                    }
                                    else if (n != Type)
                                    {
                                        effective = 1;
                                        wasEffective = "effective";
                                    }
                                }
                            }

                            var critChance = 95;
                            var crit = 1.0F;

                            if (critChance > Random.Range(0, 100))
                            {
                                crit = 1.5F;
                            }
                            else
                            {
                                crit = 1F;
                            }

                            var finalDamage = Damage * effective * stab * crit;

                            DefendingPlayer.currentHealth = DefendingPlayer.currentHealth - finalDamage;

                            AttackingPlayer.charging = false;

                            resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[9] + wasEffective + "!";

                            if (DefendingPlayer.currentHealth < 0)
                            {
                                DefendingPlayer.currentHealth = 0;
                            }



                        }
                        else
                        {
                            AttackingPlayer.charging = false;
                            resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[9] + ",  and missed";
                        }

                    }

                }
                else if (AttackingPlayer.charging == false)
                {
                    AttackingPlayer.charging = true;
                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " is charging a powerful attack!";
                }
                break;
            case 10:
                //POISON ARROW
                attackDamage = 30;

                Damage = (((AttackingPlayer.LVL + attackDamage) * 2) * (AttackingPlayer.ATK / DefendingPlayer.DEF)) / 3;

                Type = AttackTypeValue[10];

                if ((100 + AttackingPlayer.ACCMOD) >= Random.Range(1, 100))
                {
                    if (Type == AttackingPlayer.Type01 || Type == AttackingPlayer.Type02)
                    {
                        stab = 1.5F;
                    }
                    else if (Type != AttackingPlayer.Type01 && Type != AttackingPlayer.Type02)
                    {
                        stab = 1;
                    }
                    foreach (int n in DefendingPlayer.typeWeekness)
                    {
                        if (n == Type)
                        {
                            effective = 2;
                            wasEffective = "super effective";
                            break;
                        }
                        else if (n != Type)
                        {
                            effective = 1;
                            wasEffective = "effective";
                        }



                    }
                    if (effective != 2)
                    {
                        foreach (int n in DefendingPlayer.typeStrength)
                        {
                            if (n == Type)
                            {
                                effective = 0.5F;
                                wasEffective = "not very effective";
                                break;
                            }
                            else if (n != Type)
                            {
                                effective = 1;
                                wasEffective = "effective";
                            }
                        }
                    }

                    var critChance = 95;
                    var crit = 1.0F;

                    if (critChance > Random.Range(0, 100))
                    {
                        crit = 1.5F;
                    }
                    else
                    {
                        crit = 1F;
                    }

                    //CHECK IF ABILTY POISONED THE DEFENDING PLAYER

                    var finalDamage = Damage * effective * stab * crit;

                    if (Random.Range(0, 100) >= 70)
                    {

                        if (DefendingPlayer.StatusEffect == 0)
                        {
                            DefendingPlayer.currentHealth = DefendingPlayer.currentHealth - finalDamage;

                            DefendingPlayer.StatusEffect = 2;

                            resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " USED " + AttackName[10] + ", it was " + wasEffective + "! " + DefendingPlayer.Name + " was poisoned!";

                            if (DefendingPlayer.currentHealth < 0)
                            {
                                DefendingPlayer.currentHealth = 0;
                            }
                        }
                        else if (DefendingPlayer.StatusEffect != 0)
                        {
                            DefendingPlayer.currentHealth = DefendingPlayer.currentHealth - finalDamage;

                            resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " USED " + AttackName[10] + ", it was " + wasEffective + "!";

                            if (DefendingPlayer.currentHealth < 0)
                            {
                                DefendingPlayer.currentHealth = 0;
                            }
                        }

                    }
                    else
                    {
                        DefendingPlayer.currentHealth = DefendingPlayer.currentHealth - finalDamage;

                        resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " USED " + AttackName[10] + ", it was " + wasEffective + "!";
                    }


                }
                else
                {
                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " USED " + AttackName[10] + ", and missed";
                }

                break;
            case 11:
                //BEARTRAP freezes enemy
                if (DefendingPlayer.StatusEffect != 0)
                {
                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[11] + " and failed!";
                }
                else if (DefendingPlayer.StatusEffect == 0)
                {
                    if (Random.Range(0, 100) < 50) //ATTACK HIT
                    {
                        DefendingPlayer.StatusEffect = 4;
                        resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[11] + " and " + DefendingPlayer.Name + " has been frozen!";

                    }
                    else // ATTACK MISSED
                    {
                        resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[11] + " and failed!";
                    }
                }
                break;
            case 12:
                //elvish song

                AttackingPlayer.currentHealth = AttackingPlayer.currentHealth + (AttackingPlayer.maxHealth * 1 / 4);
                if (AttackingPlayer.currentHealth >= AttackingPlayer.maxHealth)
                {
                    AttackingPlayer.currentHealth = AttackingPlayer.maxHealth;
                }

                resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[12] + " and restored some heath!";

                break;
            case 13:
                //thunderStorm
                attackDamage = 60;

                Damage = (((AttackingPlayer.LVL + attackDamage) * 2) * (AttackingPlayer.sATK / DefendingPlayer.sDEF)) / 3;

                Type = AttackTypeValue[13];

                // DID ATTACK HIT?
                if ((100 + AttackingPlayer.ACCMOD) >= Random.Range(1, 100))
                {
                    if (Type == AttackingPlayer.Type01 || Type == AttackingPlayer.Type02)
                    {
                        stab = 1.5F;
                    }
                    else if (Type != AttackingPlayer.Type01 && Type != AttackingPlayer.Type02)
                    {
                        stab = 1;
                    }
                    foreach (int n in DefendingPlayer.typeWeekness)
                    {
                        if (n == 0)
                        {

                        }
                        else if (n != 0)
                        {
                            if (n == Type)
                            {
                                effective = 2;
                                wasEffective = "super effective";

                                break;
                            }
                            else if (n != Type)
                            {
                                effective = 1;
                                wasEffective = "effective";
                            }
                        }

                    }
                    if (effective != 2)
                    {
                        foreach (int n in DefendingPlayer.typeStrength)
                        {
                            if (n == Type)
                            {
                                effective = 0.5F;
                                wasEffective = "not very effective";
                                break;
                            }
                            else if (n != Type)
                            {
                                effective = 1;
                                wasEffective = "effective";
                            }
                        }
                    }

                    var critChance = 95;
                    var crit = 1F;

                    if (critChance > Random.Range(0, 100))
                    {
                        crit = 1.5F;
                    }
                    else
                    {
                        crit = 1F;
                    }


                    var finalDamage = Damage * effective * stab * crit;

                    DefendingPlayer.currentHealth = DefendingPlayer.currentHealth - finalDamage;

                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[13] + " is was " + wasEffective + "!";

                    if (DefendingPlayer.currentHealth < 0)
                    {
                        DefendingPlayer.currentHealth = 0;
                    }

                }
                else
                {
                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[13] + ",  and missed";
                }
                break;
            case 14:
                // medititate
                BaseIncerase = 0.2F;
                actualIncrease = 1.2F;

                if (AttackingPlayer.SATKMOD == 2.6 || AttackingPlayer.SDEFMOD == 2.6)
                {
                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used MEDITATE, and it failed!";
                }
                else
                {
                    AttackingPlayer.SATKMOD = AttackingPlayer.SATKMOD + BaseIncerase;

                    AttackingPlayer.SDEFMOD = AttackingPlayer.SDEFMOD + BaseIncerase;

                    AttackingPlayer.sATK = AttackingPlayer.sATK * actualIncrease;

                    AttackingPlayer.sDEF = AttackingPlayer.DEF * actualIncrease;

                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used sharpen, and raised their SPECIAL attack AND SPECIAL DEFENSE!";

                }
                break;
            case 15:
                ////GUST
                //attackDamage = 40;

                //Damage = (((AttackingPlayer.LVL + attackDamage) * 2) * (AttackingPlayer.sATK / DefendingPlayer.sDEF)) / 3;

                //Type = AttackTypeValue[15];

                //// DID ATTACK HIT?
                //if ((100 + AttackingPlayer.ACCMOD) >= Random.Range(1, 100))
                //{
                //    if (Type == AttackingPlayer.Type01 || Type == AttackingPlayer.Type02)
                //    {
                //        stab = 1.5F;
                //    }
                //    else if (Type != AttackingPlayer.Type01 && Type != AttackingPlayer.Type02)
                //    {
                //        stab = 1;
                //    }
                //    foreach (int n in DefendingPlayer.typeWeekness)
                //    {
                //        if (n == 0)
                //        {

                //        }
                //        else if (n != 0)
                //        {
                //            if (n == Type)
                //            {
                //                effective = 2;
                //                wasEffective = "super effective";

                //                break;
                //            }
                //            else if (n != Type)
                //            {
                //                effective = 1;
                //                wasEffective = "effective";
                //            }
                //        }

                //    }
                //    if (effective != 2)
                //    {
                //        foreach (int n in DefendingPlayer.typeStrength)
                //        {
                //            if (n == Type)
                //            {
                //                effective = 0.5F;
                //                wasEffective = "not very effective";
                //                break;
                //            }
                //            else if (n != Type)
                //            {
                //                effective = 1;
                //                wasEffective = "effective";
                //            }
                //        }
                //    }

                //    var critChance = 95;
                //    var crit = 1F;

                //    if (critChance > Random.Range(0, 100))
                //    {
                //        crit = 1.5F;
                //    }
                //    else
                //    {
                //        crit = 1F;
                //    }


                //    var finalDamage = Damage * effective * stab * crit;

                //    DefendingPlayer.currentHealth = DefendingPlayer.currentHealth - finalDamage;


                //    if (DefendingPlayer.currentHealth <= 0)
                //    {
                //        DefendingPlayer.currentHealth = 0;
                //    }
                //    else
                //    {
                //        if (DefendingPlayer == Data.partyData.ActiveEnemy)
                //        {
                //            Manager.EnemyDied();
                //            resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[15] + " on " + DefendingPlayer.Name + " is was " + wasEffective + "! the gust of wind swept them away and " + Data.partyData.ActiveEnemy.Name + " has replaced them in battle!";

                //        }
                //        else if (DefendingPlayer == Data.partyData.ActiveChar)
                //        {
                //            Manager.PlayerDied();
                //            resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[15] + " on " + DefendingPlayer.Name + " is was " + wasEffective + "! the gust of wind swept them away and " + Data.partyData.ActiveEnemy.Name + " has replaced them in battle!";

                //        }
                //    }

                //}
                //else
                //{
                //    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[15] + ",  and missed";
                //}
                break;
            case 16:
                attackDamage = 80;

                Damage = (((AttackingPlayer.LVL + attackDamage) * 2) * (AttackingPlayer.sATK / DefendingPlayer.sDEF)) / 3;

                Type = AttackTypeValue[16];

                // DID ATTACK HIT?
                if ((100 + AttackingPlayer.ACCMOD) >= Random.Range(1, 100))
                {
                    if (Type == AttackingPlayer.Type01 || Type == AttackingPlayer.Type02)
                    {
                        stab = 1.5F;
                    }
                    else if (Type != AttackingPlayer.Type01 && Type != AttackingPlayer.Type02)
                    {
                        stab = 1;
                    }
                    foreach (int n in DefendingPlayer.typeWeekness)
                    {
                        if (n == 0)
                        {

                        }
                        else if (n != 0)
                        {
                            if (n == Type)
                            {
                                effective = 2;
                                wasEffective = "super effective";

                                break;
                            }
                            else if (n != Type)
                            {
                                effective = 1;
                                wasEffective = "effective";
                            }
                        }

                    }
                    if (effective != 2)
                    {
                        foreach (int n in DefendingPlayer.typeStrength)
                        {
                            if (n == Type)
                            {
                                effective = 0.5F;
                                wasEffective = "not very effective";
                                break;
                            }
                            else if (n != Type)
                            {
                                effective = 1;
                                wasEffective = "effective";
                            }
                        }
                    }

                    var critChance = 95;
                    var crit = 1F;

                    if (critChance > Random.Range(0, 100))
                    {
                        crit = 1.5F;
                    }
                    else
                    {
                        crit = 1F;
                    }


                    var finalDamage = Damage * effective * stab * crit;

                    DefendingPlayer.currentHealth = DefendingPlayer.currentHealth - finalDamage;

                    if (AttackingPlayer.DEFMOD <= 0.2)
                    {
                        resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[16] + " is was " + wasEffective + " thier defense cant get any lower!";
                    }
                    else
                    {
                        AttackingPlayer.DEFMOD = AttackingPlayer.DEFMOD - 0.2F;
                        AttackingPlayer.DEF = AttackingPlayer.DEF * 0.8F;
                        resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[16] + " is was " + wasEffective + " AND THIER DEFENSE WAS LOWEERED AS A RESAULT OF THE DARK PACT!";
                    }


                    if (DefendingPlayer.currentHealth < 0)
                    {
                        DefendingPlayer.currentHealth = 0;
                    }

                }
                else
                {
                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[16] + ",  and missed";
                }
                break;
            case 17:
                attackDamage = 40;

                Damage = (((AttackingPlayer.LVL + attackDamage) * 2) * (AttackingPlayer.ATK / DefendingPlayer.DEF)) / 3;

                Type = AttackTypeValue[17];

                // DID ATTACK HIT?
                if ((100 + AttackingPlayer.ACCMOD) >= Random.Range(1, 100))
                {
                    if (Type == AttackingPlayer.Type01 || Type == AttackingPlayer.Type02)
                    {
                        stab = 1.5F;
                    }
                    else if (Type != AttackingPlayer.Type01 && Type != AttackingPlayer.Type02)
                    {
                        stab = 1;
                    }
                    foreach (int n in DefendingPlayer.typeWeekness)
                    {
                        if (n == 0)
                        {

                        }
                        else if (n != 0)
                        {
                            if (n == Type)
                            {
                                effective = 2;
                                wasEffective = "super effective";

                                break;
                            }
                            else if (n != Type)
                            {
                                effective = 1;
                                wasEffective = "effective";
                            }
                        }

                    }
                    if (effective != 2)
                    {
                        foreach (int n in DefendingPlayer.typeStrength)
                        {
                            if (n == Type)
                            {
                                effective = 0.5F;
                                wasEffective = "not very effective";
                                break;
                            }
                            else if (n != Type)
                            {
                                effective = 1;
                                wasEffective = "effective";
                            }
                        }
                    }

                    var critChance = 95;
                    var crit = 1F;

                    if (critChance > Random.Range(0, 100))
                    {
                        crit = 1.5F;
                    }
                    else
                    {
                        crit = 1F;
                    }


                    var finalDamage = Damage * effective * stab * crit;

                    DefendingPlayer.currentHealth = DefendingPlayer.currentHealth - finalDamage;

                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[17] + " is was " + wasEffective + "!";

                    if (DefendingPlayer.currentHealth < 0)
                    {
                        DefendingPlayer.currentHealth = 0;
                    }

                }
                else
                {
                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[17] + ",  and missed";
                }
                break;
            case 18:
                BaseIncerase = 0.2F;
                actualIncrease = 0.8f;

                if (DefendingPlayer.DEFMOD <= 0.2)
                {
                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used scoff, and it failed!";
                }
                else
                {


                    DefendingPlayer.DEFMOD = DefendingPlayer.DEFMOD - BaseIncerase;



                    DefendingPlayer.DEF = DefendingPlayer.DEF * actualIncrease;

                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[18] + " and lowered " + DefendingPlayer.Name + "'s defense";

                }
                break;
            case 19:
                if (AttackingPlayer.charging == true)
                {
                    attackDamage = 120;

                    Damage = (((AttackingPlayer.LVL + attackDamage) * 2) * (AttackingPlayer.ATK / DefendingPlayer.DEF)) / 3;

                    Type = AttackTypeValue[19];

                    if (DefendingPlayer.blocked == true)
                    {
                        resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " has used " + AttackName[19] + ", but " + DefendingPlayer.Name + "has blocked the attack!";
                    }
                    else if (DefendingPlayer.blocked == false)
                    {
                        // DID ATTACK HIT?
                        if ((100 + AttackingPlayer.ACCMOD) >= Random.Range(1, 100))
                        {
                            if (Type == AttackingPlayer.Type01 || Type == AttackingPlayer.Type02)
                            {
                                stab = 1.5F;
                            }
                            else if (Type != AttackingPlayer.Type01 && Type != AttackingPlayer.Type02)
                            {
                                stab = 1;
                            }
                            foreach (int n in DefendingPlayer.typeWeekness)
                            {
                                if (n == Type)
                                {
                                    effective = 2;
                                    wasEffective = "super effective";
                                    break;
                                }
                                else if (n != Type)
                                {
                                    effective = 1;
                                    wasEffective = "effective";
                                }



                            }
                            if (effective != 2)
                            {
                                foreach (int n in DefendingPlayer.typeStrength)
                                {
                                    if (n == Type)
                                    {
                                        effective = 0.5F;
                                        wasEffective = "not very effective";
                                        break;
                                    }
                                    else if (n != Type)
                                    {
                                        effective = 1;
                                        wasEffective = "effective";
                                    }
                                }
                            }

                            var critChance = 95;
                            var crit = 1.0F;

                            if (critChance > Random.Range(0, 100))
                            {
                                crit = 1.5F;
                            }
                            else
                            {
                                crit = 1F;
                            }

                            var finalDamage = Damage * effective * stab * crit;

                            DefendingPlayer.currentHealth = DefendingPlayer.currentHealth - finalDamage;

                            AttackingPlayer.charging = false;

                            resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[19] + wasEffective + "!";

                            if (DefendingPlayer.currentHealth < 0)
                            {
                                DefendingPlayer.currentHealth = 0;
                            }



                        }
                        else
                        {
                            AttackingPlayer.charging = false;
                            resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[19] + ",  and missed";
                        }

                    }

                }
                else if (AttackingPlayer.charging == false)
                {
                    AttackingPlayer.charging = true;
                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " is charging a powerful attack!";
                }
                break;
            case 20:
                BaseIncerase = 0.2F;
                actualIncrease = 1.2f;

                if (AttackingPlayer.ATKMOD >= 2.6)
                {
                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used hone body, and it failed!";
                }
                else
                {


                    AttackingPlayer.ATKMOD = AttackingPlayer.ATKMOD + BaseIncerase;



                    AttackingPlayer.ATK = AttackingPlayer.ATK * actualIncrease;

                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[20] + " and raised their defense!";
                }
                    break;
            case 21:
                BaseIncerase = 0.2F;
                actualIncrease = 0.8f;

                if (DefendingPlayer.SDEFMOD <= 0.2)
                {
                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used psychic torment, and it failed!";
                }
                else
                {
                    Debug.Log("callPhycic tormernt");

                    DefendingPlayer.SDEFMOD = DefendingPlayer.SDEFMOD - BaseIncerase;



                    DefendingPlayer.sDEF = DefendingPlayer.sDEF * actualIncrease;

                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[21] + " and lowered " + DefendingPlayer.Name + "'s special defense";

                }
                break;
            case 22:
                attackDamage = 40;

                Damage = (((AttackingPlayer.LVL + attackDamage) * 2) * (AttackingPlayer.sATK / DefendingPlayer.sDEF)) / 3;

                Type = AttackTypeValue[22];

                // DID ATTACK HIT?
                if ((100 + AttackingPlayer.ACCMOD) >= Random.Range(1, 100))
                {
                    if (Type == AttackingPlayer.Type01 || Type == AttackingPlayer.Type02)
                    {
                        stab = 1.5F;
                    }
                    else if (Type != AttackingPlayer.Type01 && Type != AttackingPlayer.Type02)
                    {
                        stab = 1;
                    }
                    foreach (int n in DefendingPlayer.typeWeekness)
                    {
                        if (n == 0)
                        {

                        }
                        else if (n != 0)
                        {
                            if (n == Type)
                            {
                                effective = 2;
                                wasEffective = "super effective";

                                break;
                            }
                            else if (n != Type)
                            {
                                effective = 1;
                                wasEffective = "effective";
                            }
                        }

                    }
                    if (effective != 2)
                    {
                        foreach (int n in DefendingPlayer.typeStrength)
                        {
                            if (n == Type)
                            {
                                effective = 0.5F;
                                wasEffective = "not very effective";
                                break;
                            }
                            else if (n != Type)
                            {
                                effective = 1;
                                wasEffective = "effective";
                            }
                        }
                    }

                    var critChance = 95;
                    var crit = 1F;

                    if (critChance > Random.Range(0, 100))
                    {
                        crit = 1.5F;
                    }
                    else
                    {
                        crit = 1F;
                    }


                    var finalDamage = Damage * effective * stab * crit;

                    DefendingPlayer.currentHealth = DefendingPlayer.currentHealth - finalDamage;

                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[22] + " is was " + wasEffective + "!";

                    if (DefendingPlayer.currentHealth < 0)
                    {
                        DefendingPlayer.currentHealth = 0;
                    }

                }
                else
                {
                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[22] + ",  and missed";
                }
                break;
            case 23:
                Debug.Log("call beam cannon");
                attackDamage = 90;

                Damage = (((AttackingPlayer.LVL + attackDamage) * 2) * (AttackingPlayer.sATK / DefendingPlayer.sDEF)) / 3;

                Type = AttackTypeValue[23];

                // DID ATTACK HIT?
                if ((85 + AttackingPlayer.ACCMOD) <= Random.Range(1, 100))
                {
                    if (Type == AttackingPlayer.Type01 || Type == AttackingPlayer.Type02)
                    {
                        stab = 1.5F;
                    }
                    else if (Type != AttackingPlayer.Type01 && Type != AttackingPlayer.Type02)
                    {
                        stab = 1;
                    }
                    foreach (int n in DefendingPlayer.typeWeekness)
                    {
                        if (n == 0)
                        {

                        }
                        else if (n != 0)
                        {
                            if (n == Type)
                            {
                                effective = 2;
                                wasEffective = "super effective";

                                break;
                            }
                            else if (n != Type)
                            {
                                effective = 1;
                                wasEffective = "effective";
                            }
                        }

                    }
                    if (effective != 2)
                    {
                        foreach (int n in DefendingPlayer.typeStrength)
                        {
                            if (n == Type)
                            {
                                effective = 0.5F;
                                wasEffective = "not very effective";
                                break;
                            }
                            else if (n != Type)
                            {
                                effective = 1;
                                wasEffective = "effective";
                            }
                        }
                    }

                    var critChance = 95;
                    var crit = 1F;

                    if (critChance > Random.Range(0, 100))
                    {
                        crit = 1.5F;
                    }
                    else
                    {
                        crit = 1F;
                    }


                    var finalDamage = Damage * effective * stab * crit;

                    DefendingPlayer.currentHealth = DefendingPlayer.currentHealth - finalDamage;

                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[23] + " is was " + wasEffective + "!";

                    if (DefendingPlayer.currentHealth < 0)
                    {
                        DefendingPlayer.currentHealth = 0;
                    }

                }
                else
                {
                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[23] + ",  and missed";
                }
                break;
            case 24:
                BaseIncerase = 0.2F;
                actualIncrease = 1.2F;

                if (AttackingPlayer.SDEFMOD == 2.6)
                {
                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used psychic defense, and it failed!";
                }
                else
                {


                    AttackingPlayer.SDEFMOD = AttackingPlayer.SDEFMOD + BaseIncerase;



                    AttackingPlayer.sDEF = AttackingPlayer.DEF * actualIncrease;

                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used psychic defense, and raised their SPECIAL DEFENSE!";
                }
                break;
            case 25:
                attackDamage = 40;

                Damage = (((AttackingPlayer.LVL + attackDamage) * 2) * (AttackingPlayer.sATK / DefendingPlayer.sDEF)) / 3;

                Type = AttackTypeValue[25];

                if ((100 + AttackingPlayer.ACCMOD) >= Random.Range(1, 100))
                {
                    if (Type == AttackingPlayer.Type01 || Type == AttackingPlayer.Type02)
                    {
                        stab = 1.5F;
                    }
                    else if (Type != AttackingPlayer.Type01 && Type != AttackingPlayer.Type02)
                    {
                        stab = 1;
                    }
                    foreach (int n in DefendingPlayer.typeWeekness)
                    {
                        if (n == Type)
                        {
                            effective = 2;
                            wasEffective = "super effective";
                            break;
                        }
                        else if (n != Type)
                        {
                            effective = 1;
                            wasEffective = "effective";
                        }



                    }
                    if (effective != 2)
                    {
                        foreach (int n in DefendingPlayer.typeStrength)
                        {
                            if (n == Type)
                            {
                                effective = 0.5F;
                                wasEffective = "not very effective";
                                break;
                            }
                            else if (n != Type)
                            {
                                effective = 1;
                                wasEffective = "effective";
                            }
                        }
                    }

                    var critChance = 95;
                    var crit = 1.0F;

                    if (critChance > Random.Range(0, 100))
                    {
                        crit = 1.5F;
                    }
                    else
                    {
                        crit = 1F;
                    }

                    //CHECK IF ABILTY POISONED THE DEFENDING PLAYER

                    var finalDamage = Damage * effective * stab * crit;

                    if (Random.Range(0, 100) >= 95)
                    {

                        if (DefendingPlayer.StatusEffect == 0)
                        {
                            DefendingPlayer.currentHealth = DefendingPlayer.currentHealth - finalDamage;

                            DefendingPlayer.StatusEffect = 4;

                            resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " USED " + AttackName[25] + ", it was " + wasEffective + "! " + DefendingPlayer.Name + " was frozen!";

                            if (DefendingPlayer.currentHealth < 0)
                            {
                                DefendingPlayer.currentHealth = 0;
                            }
                        }
                        else if (DefendingPlayer.StatusEffect != 0)
                        {
                            DefendingPlayer.currentHealth = DefendingPlayer.currentHealth - finalDamage;

                            resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " USED " + AttackName[25] + ", it was " + wasEffective + "!";

                            if (DefendingPlayer.currentHealth < 0)
                            {
                                DefendingPlayer.currentHealth = 0;
                            }
                        }

                    }
                    else
                    {
                        DefendingPlayer.currentHealth = DefendingPlayer.currentHealth - finalDamage;

                        resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " USED " + AttackName[25] + ", it was " + wasEffective + "!";
                    }


                }
                else
                {
                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " USED " + AttackName[25] + ", and missed";
                }
                break;
            case 26:
                ////HEALLING TAG!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

                //if (AttackingPlayer == Data.partyData.ActiveChar)
                //{
                //    Manager.PlayerDied();
                //    Data.partyData.ActiveChar.currentHealth = Data.partyData.ActiveChar.currentHealth + (Data.partyData.ActiveChar.maxHealth / 4);
                //    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " CALLED ON " + Data.partyData.ActiveChar.Name + " and bestowed them with a healing blessing!"; 

                //}
                //else if (AttackingPlayer == Data.partyData.ActiveEnemy)
                //{
                //    Manager.EnemyDied();
                //    Data.partyData.ActiveChar.currentHealth = Data.partyData.ActiveChar.currentHealth + (Data.partyData.ActiveChar.maxHealth / 4);
                //    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " CALLED ON " + Data.partyData.ActiveChar.Name + " and bestowed them with a healing blessing!";
                //}
                break;
            case 27:
                //cleansing fire
                attackDamage = 60;

                Damage = (((AttackingPlayer.LVL + attackDamage) * 2) * (AttackingPlayer.sATK / DefendingPlayer.sDEF)) / 3;

                Type = AttackTypeValue[27];

                if ((100 + AttackingPlayer.ACCMOD) >= Random.Range(1, 100))
                {
                    if (Type == AttackingPlayer.Type01 || Type == AttackingPlayer.Type02)
                    {
                        stab = 1.5F;
                    }
                    else if (Type != AttackingPlayer.Type01 && Type != AttackingPlayer.Type02)
                    {
                        stab = 1;
                    }
                    foreach (int n in DefendingPlayer.typeWeekness)
                    {
                        if (n == Type)
                        {
                            effective = 2;
                            wasEffective = "super effective";
                            break;
                        }
                        else if (n != Type)
                        {
                            effective = 1;
                            wasEffective = "effective";
                        }



                    }
                    if (effective != 2)
                    {
                        foreach (int n in DefendingPlayer.typeStrength)
                        {
                            if (n == Type)
                            {
                                effective = 0.5F;
                                wasEffective = "not very effective";
                                break;
                            }
                            else if (n != Type)
                            {
                                effective = 1;
                                wasEffective = "effective";
                            }
                        }
                    }

                    var critChance = 95;
                    var crit = 1.0F;

                    if (critChance > Random.Range(0, 100))
                    {
                        crit = 1.5F;
                    }
                    else
                    {
                        crit = 1F;
                    }

                    //CHECK IF there is a status effect

                    var finalDamage = Damage * effective * stab * crit;

                    if (Random.Range(0, 100) >= 50)
                    {

                        if (DefendingPlayer.StatusEffect == 0)
                        {
                            DefendingPlayer.currentHealth = DefendingPlayer.currentHealth - finalDamage;


                            resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " USED " + AttackName[27] + ", it was " + wasEffective + "! ";

                            if (DefendingPlayer.currentHealth < 0)
                            {
                                DefendingPlayer.currentHealth = 0;
                            }
                        }
                        else if (DefendingPlayer.StatusEffect != 0)
                        {
                            DefendingPlayer.currentHealth = DefendingPlayer.currentHealth - finalDamage;

                            DefendingPlayer.StatusEffect = 0;

                            resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " USED " + AttackName[27] + ", it was " + wasEffective + "! and cured " + DefendingPlayer.Name + "'s status effect!";

                            if (DefendingPlayer.currentHealth < 0)
                            {
                                DefendingPlayer.currentHealth = 0;
                            }
                        }

                    }
                    else
                    {
                        DefendingPlayer.currentHealth = DefendingPlayer.currentHealth - finalDamage;


                        resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " USED " + AttackName[27] + ", it was " + wasEffective + "! ";

                        if (DefendingPlayer.currentHealth < 0)
                        {
                            DefendingPlayer.currentHealth = 0;
                        }
                    }
                }
                else
                {
                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " USED " + AttackName[27] + ", and missed";
                }

                break;
            case 28:
                BaseIncerase = 0.4F;
                actualIncrease = 1.4f;

                if (DefendingPlayer.SDEFMOD <= 2.6)
                {
                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used blessing, and it failed!";
                }
                else
                {


                    DefendingPlayer.SDEFMOD = DefendingPlayer.SDEFMOD + BaseIncerase;



                    DefendingPlayer.sDEF = DefendingPlayer.sDEF * actualIncrease;

                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[28] + " and raised their special defense!" ;

                }
                break;
            case 29:
                if ( AttackingPlayer.tripleStrike[0] == false)
                {
                    attackDamage = 30;

                    Damage = (((AttackingPlayer.LVL + attackDamage) * 2) * (AttackingPlayer.ATK / DefendingPlayer.DEF)) / 3;

                    Type = AttackTypeValue[29];

                    // DID ATTACK HIT?
                    if ((100 + AttackingPlayer.ACCMOD) >= Random.Range(1, 100))
                    {
                        if (Type == AttackingPlayer.Type01 || Type == AttackingPlayer.Type02)
                        {
                            stab = 1.5F;
                        }
                        else if (Type != AttackingPlayer.Type01 && Type != AttackingPlayer.Type02)
                        {
                            stab = 1;
                        }
                        foreach (int n in DefendingPlayer.typeWeekness)
                        {
                            if (n == 0)
                            {

                            }
                            else if (n != 0)
                            {
                                if (n == Type)
                                {
                                    effective = 2;
                                    wasEffective = "super effective";

                                    break;
                                }
                                else if (n != Type)
                                {
                                    effective = 1;
                                    wasEffective = "effective";
                                }
                            }

                        }
                        if (effective != 2)
                        {
                            foreach (int n in DefendingPlayer.typeStrength)
                            {
                                if (n == Type)
                                {
                                    effective = 0.5F;
                                    wasEffective = "not very effective";
                                    break;
                                }
                                else if (n != Type)
                                {
                                    effective = 1;
                                    wasEffective = "effective";
                                }
                            }
                        }

                        var critChance = 95;
                        var crit = 1F;

                        if (critChance > Random.Range(0, 100))
                        {
                            crit = 1.5F;
                        }
                        else
                        {
                            crit = 1F;
                        }


                        var finalDamage = Damage * effective * stab * crit;

                        DefendingPlayer.currentHealth = DefendingPlayer.currentHealth - finalDamage;

                        AttackingPlayer.tripleStrike[0] = true;

                        if (AttackingPlayer == Data.partyData.ActiveChar)
                        {
                            Manager.PlayerUsedAction = false;

                        }
                        else if (AttackingPlayer == Data.partyData.ActiveEnemy)
                        {

                            Manager.EnemyUsedAction = false;

                        }

                        resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[29] + " is was " + wasEffective + "!";

                        if (DefendingPlayer.currentHealth < 0)
                        {
                            DefendingPlayer.currentHealth = 0;
                        }



                    }
                    else
                    {
                        resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[29] + ",  and missed";
                        AttackingPlayer.tripleStrike[0] = false;
                        AttackingPlayer.tripleStrike[1] = false;
                        AttackingPlayer.tripleStrike[2] = false;
                    }
                }
                else if (AttackingPlayer.tripleStrike[1] == false)
                {
                    if (Random.Range(1, 4) <= 2)
                    {
                        attackDamage = 30;

                        Damage = (((AttackingPlayer.LVL + attackDamage) * 2) * (AttackingPlayer.sATK / DefendingPlayer.sDEF)) / 3;

                        Type = AttackTypeValue[29];

                        // DID ATTACK HIT?
                        if ((100 + AttackingPlayer.ACCMOD) >= Random.Range(1, 100))
                        {
                            if (Type == AttackingPlayer.Type01 || Type == AttackingPlayer.Type02)
                            {
                                stab = 1.5F;
                            }
                            else if (Type != AttackingPlayer.Type01 && Type != AttackingPlayer.Type02)
                            {
                                stab = 1;
                            }
                            foreach (int n in DefendingPlayer.typeWeekness)
                            {
                                if (n == 0)
                                {

                                }
                                else if (n != 0)
                                {
                                    if (n == Type)
                                    {
                                        effective = 2;
                                        wasEffective = "super effective";

                                        break;
                                    }
                                    else if (n != Type)
                                    {
                                        effective = 1;
                                        wasEffective = "effective";
                                    }
                                }

                            }
                            if (effective != 2)
                            {
                                foreach (int n in DefendingPlayer.typeStrength)
                                {
                                    if (n == Type)
                                    {
                                        effective = 0.5F;
                                        wasEffective = "not very effective";
                                        break;
                                    }
                                    else if (n != Type)
                                    {
                                        effective = 1;
                                        wasEffective = "effective";
                                    }
                                }
                            }

                            var critChance = 95;
                            var crit = 1F;

                            if (critChance > Random.Range(0, 100))
                            {
                                crit = 1.5F;
                            }
                            else
                            {
                                crit = 1F;
                            }


                            var finalDamage = Damage * effective * stab * crit;

                            DefendingPlayer.currentHealth = DefendingPlayer.currentHealth - finalDamage;

                            AttackingPlayer.tripleStrike[1] = true;

                            if (AttackingPlayer == Data.partyData.ActiveChar)
                            {
                                Manager.PlayerUsedAction = false;

                            }
                            else if (AttackingPlayer == Data.partyData.ActiveEnemy)
                            {

                                Manager.EnemyUsedAction = false;

                            }

                            resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[29] + " is was " + wasEffective + "!";

                            if (DefendingPlayer.currentHealth < 0)
                            {
                                DefendingPlayer.currentHealth = 0;
                            }



                        }
                        else
                        {
                            resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[29] + ",  and missed";
                            AttackingPlayer.tripleStrike[0] = false;
                            AttackingPlayer.tripleStrike[1] = false;
                            AttackingPlayer.tripleStrike[2] = false;
                        }
                    }
                    else
                    {
                        AttackingPlayer.tripleStrike[0] = false;
                        AttackingPlayer.tripleStrike[1] = false;
                        AttackingPlayer.tripleStrike[2] = false;

                        Manager.TurnManager();

                    }
                }
                else if (AttackingPlayer.tripleStrike[2] == false)
                {
                    if (Random.Range(1, 4) <= 1)
                    {
                        attackDamage = 30;

                        Damage = (((AttackingPlayer.LVL + attackDamage) * 2) * (AttackingPlayer.sATK / DefendingPlayer.sDEF)) / 3;

                        Type = AttackTypeValue[29];

                        // DID ATTACK HIT?
                        if ((100 + AttackingPlayer.ACCMOD) >= Random.Range(1, 100))
                        {
                            if (Type == AttackingPlayer.Type01 || Type == AttackingPlayer.Type02)
                            {
                                stab = 1.5F;
                            }
                            else if (Type != AttackingPlayer.Type01 && Type != AttackingPlayer.Type02)
                            {
                                stab = 1;
                            }
                            foreach (int n in DefendingPlayer.typeWeekness)
                            {
                                if (n == 0)
                                {

                                }
                                else if (n != 0)
                                {
                                    if (n == Type)
                                    {
                                        effective = 2;
                                        wasEffective = "super effective";

                                        break;
                                    }
                                    else if (n != Type)
                                    {
                                        effective = 1;
                                        wasEffective = "effective";
                                    }
                                }

                            }
                            if (effective != 2)
                            {
                                foreach (int n in DefendingPlayer.typeStrength)
                                {
                                    if (n == Type)
                                    {
                                        effective = 0.5F;
                                        wasEffective = "not very effective";
                                        break;
                                    }
                                    else if (n != Type)
                                    {
                                        effective = 1;
                                        wasEffective = "effective";
                                    }
                                }
                            }

                            var critChance = 95;
                            var crit = 1F;

                            if (critChance > Random.Range(0, 100))
                            {
                                crit = 1.5F;
                            }
                            else
                            {
                                crit = 1F;
                            }


                            var finalDamage = Damage * effective * stab * crit;

                            DefendingPlayer.currentHealth = DefendingPlayer.currentHealth - finalDamage;

                            AttackingPlayer.tripleStrike[0] = true;

                            resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[29] + " is was " + wasEffective + "!";

                            if (DefendingPlayer.currentHealth < 0)
                            {
                                DefendingPlayer.currentHealth = 0;
                            }

                        }
                        else
                        {
                            resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[29] + ",  and missed";
                            AttackingPlayer.tripleStrike[0] = false;
                            AttackingPlayer.tripleStrike[1] = false;
                            AttackingPlayer.tripleStrike[2] = false;
                        }

                        AttackingPlayer.tripleStrike[0] = false;
                        AttackingPlayer.tripleStrike[1] = false;
                        AttackingPlayer.tripleStrike[2] = false;
                    }
                    else
                    {
                        AttackingPlayer.tripleStrike[0] = false;
                        AttackingPlayer.tripleStrike[1] = false;
                        AttackingPlayer.tripleStrike[2] = false;

                        Manager.TurnManager();
                    }
                }
                break;
            case 30:
                if (DefendingPlayer.ACCMOD == -80.00){

                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used darkness, and it failed!";
                }
                else if (DefendingPlayer.ACCMOD > -80.00)
                {

                    if (DefendingPlayer.ACCMOD == 1)
                    {
                        DefendingPlayer.ACCMOD = 0;
                    }
                    else
                    {

                        DefendingPlayer.ACCMOD = DefendingPlayer.ACCMOD - 20;
                        resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used darkness, and lowered " + DefendingPlayer.Name + " accuracy!";

                    }

                }
                break;
            case 31:
                //sleep powder
                if (DefendingPlayer.StatusEffect != 0)
                {
                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[31] + " and failed!";
                }
                else if (DefendingPlayer.StatusEffect == 0)
                {
                    if (Random.Range(0, 100) < 85) //ATTACK HIT
                    {
                        DefendingPlayer.StatusEffect = 3;
                        resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[31] + " and " + DefendingPlayer.Name + " has been put to sleep";

                    }
                    else // ATTACK MISSED
                    {
                        resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[31] + " and failed!";
                    }
                }

                break;
            case 32:
                attackDamage = 40;

                Damage = (((AttackingPlayer.LVL + attackDamage) * 2) * (AttackingPlayer.ATK / DefendingPlayer.DEF)) / 3;

                Type = AttackTypeValue[32];

                // DID ATTACK HIT?
                if ((100 + AttackingPlayer.ACCMOD) >= Random.Range(1, 100))
                {
                    if (Type == AttackingPlayer.Type01 || Type == AttackingPlayer.Type02)
                    {
                        stab = 1.5F;
                    }
                    else if (Type != AttackingPlayer.Type01 && Type != AttackingPlayer.Type02)
                    {
                        stab = 1;
                    }
                    foreach (int n in DefendingPlayer.typeWeekness)
                    {
                        if (n == 0)
                        {

                        }
                        else if (n != 0)
                        {
                            if (n == Type)
                            {
                                effective = 2;
                                wasEffective = "super effective";

                                break;
                            }
                            else if (n != Type)
                            {
                                effective = 1;
                                wasEffective = "effective";
                            }
                        }

                    }
                    if (effective != 2)
                    {
                        foreach (int n in DefendingPlayer.typeStrength)
                        {
                            if (n == Type)
                            {
                                effective = 0.5F;
                                wasEffective = "not very effective";
                                break;
                            }
                            else if (n != Type)
                            {
                                effective = 1;
                                wasEffective = "effective";
                            }
                        }
                    }

                    var critChance = 95;
                    var crit = 1F;

                    if (critChance > Random.Range(0, 100))
                    {
                        crit = 1.5F;
                    }
                    else
                    {
                        crit = 1F;
                    }


                    var finalDamage = Damage * effective * stab * crit;

                    DefendingPlayer.currentHealth = DefendingPlayer.currentHealth - finalDamage;

                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[32] + " is was " + wasEffective + "!";

                    if (DefendingPlayer.currentHealth < 0)
                    {
                        DefendingPlayer.currentHealth = 0;
                    }

                }
                else
                {
                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " used " + AttackName[32] + ",  and missed";
                }
                break;

        }

    }

}
