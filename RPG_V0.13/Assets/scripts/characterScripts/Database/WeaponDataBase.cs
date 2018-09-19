using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponDataBase : MonoBehaviour {

    public static WeaponDataBase weapons;

    public string[] WeaponName = new string[] { "", "sword of princes", "royal greatsword", "Archmages Bow", "Tome of Waves", "throwing Knives", "Striking Tome", "Staff of Angels", "Poison Tipped Knife" };
    public string[] WeaponDesc = new string[] { "", "Atk 60/100 matches type of user", "Atk Normal 60/100", "sAtk Archane 40/100", "sAtk Water 60/100", "Atk Normal 40/100 Increased Crit Chance", "sAtk Electric 60/100 5% chance to paralyze", "sAtk Light 120/100 takes 1 turn to charge", "atk nature 30/100 5% chance to poison" };
    public bool[] weaponPriority = new bool[13];
    public bool[] weaponSuperPriority = new bool[13];



    public float effective;
    public float stab;
    public string wasEffective;
    



    void Awake()
    {
        if (weapons == null)
        {
            weapons = this;
            
        }
        else if (weapons != this)
        {

        }
    }


    // 0 = none 1 =normal 2=fire 3=water 4=nature 5=earth 6=air 7=ice 8=electric 9=light 10=dark 11=psychic 12=archane 13=celestial
    public void AttackFunction(charClass AttackingPlayer, charClass DefendingPlayer, int SelectedAttack, GameObject resaultstext)
    {
        switch (SelectedAttack)
        {
            case 1:
                //Sword Of princes 60ATK Matchest type of user
                var attackDamage = 60;

                var Damage = (((AttackingPlayer.LVL + attackDamage) * 2) * (AttackingPlayer.ATK / DefendingPlayer.DEF)) / 3;

                var Type = AttackingPlayer.Type01;

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
                        if (DefendingPlayer.typeWeekness[n] == 0)
                        {

                        }
                        else if (DefendingPlayer.typeWeekness[n] != 0)
                        {
                            if (DefendingPlayer.typeWeekness[n] == Type)
                            {
                                effective = 2;
                                wasEffective = "super effective";

                                break;
                            }
                            else if (DefendingPlayer.typeWeekness[n] != Type)
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

                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " attacked with sword of princes, it was " + wasEffective + "!";

                }
                else
                {
                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " attacked with sword of princes,  and missed";
                }
                break;
            case 2:
                //ROYAL GREATSWORD 60/100 EARTH ATK
                attackDamage = 60;

                Damage = (((AttackingPlayer.LVL + attackDamage) * 2) * (AttackingPlayer.ATK / DefendingPlayer.DEF)) / 3;

                Type = 5;
                

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

                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " attacked with a royal greatsword, it was " + wasEffective + "!";

                }
                else
                {
                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " attacked with a royal greatsword,  and missed";
                }
                break;
            case 3:
                //ARCHMAGE BOW 60/100 SATK ARCHANE
                attackDamage = 60;

                Damage = (((AttackingPlayer.LVL + attackDamage) * 2) * (AttackingPlayer.sATK / DefendingPlayer.sDEF)) / 3;

                Type = 12;
               

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
                            Debug.Log("weekness" + n);
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

                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " attacked with the archmages bow it was " + wasEffective + "!";

                }
                else
                {
                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " attacked with the archmages bow,  and missed";
                }
                break;
            case 4:
                //TOME OF WAVES 60/100 SATK WATER
                attackDamage = 60;

                Damage = (((AttackingPlayer.LVL + attackDamage) * 2) * (AttackingPlayer.sATK / DefendingPlayer.sDEF)) / 3;

                Type = 3;
                

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

                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " casted a spell from the Tome of waves, " + wasEffective + "!";

                }
                else
                {
                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " casted a spell from the tome fo waves,  and missed";
                }
                break;
            case 5:
                //tHROWING KNIVES ATK 40/100 NORMAL +CRITCHANCE
                attackDamage = 40;

                Damage = (((AttackingPlayer.LVL + attackDamage) * 2) * (AttackingPlayer.ATK / DefendingPlayer.DEF)) / 3;

                Type = 1;
                

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

                    var critChance = 85;
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

                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " threw a knife, " + wasEffective + "!";

                }
                else
                {
                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " threw a knige,  and missed";
                }
                break;
            case 6:
                //STRIKING TOME 60/100 ELECTRIC SATK
                attackDamage = 60;

                Damage = (((AttackingPlayer.LVL + attackDamage) * 2) * (AttackingPlayer.sATK / DefendingPlayer.sDEF)) / 3;

                Type = 8;
                

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

                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " casted a spell from the striking tome, " + wasEffective + "!";

                }
                else
                {
                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " casted a spell from the strinking tome,  and missed";
                }
                break;
            case 7:
                //STAFF OF ANGELS SATK 120/100 LIGHT TAKES 1 TURN TO CHARGE


                if (AttackingPlayer.charging == true)
                {
                    attackDamage = 120;

                    Damage = (((AttackingPlayer.LVL + attackDamage) * 2) * (AttackingPlayer.sATK / DefendingPlayer.sDEF)) / 3;

                    Type = 9;
                    

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

                        resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " casted a spell using a staff of angels, " + wasEffective + "!";



                    }
                    else
                    {
                        AttackingPlayer.charging = false;
                        resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " casted a spell using a staff of angels,  and missed";
                    }
                }
                else if (AttackingPlayer.charging == false)
                {
                    AttackingPlayer.charging = true;
                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " is charging a powerful attack!";
                }


               
                break;
            case 8:
                //Poison Knife 30/100 Nature 10% chance to poison
                attackDamage = 30;

                Damage = (((AttackingPlayer.LVL + attackDamage) * 2) * (AttackingPlayer.sATK / DefendingPlayer.sDEF)) / 3;

                Type = 4;


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

                    //CHECK IF ABILTY POISONED THE DEFENDING PLAYER

                    var finalDamage = Damage * effective * stab * crit;

                    if (Random.Range (0,100) >= 70)
                    {

                        if (DefendingPlayer.StatusEffect == 0)
                        {
                            DefendingPlayer.currentHealth = DefendingPlayer.currentHealth - finalDamage;

                            DefendingPlayer.StatusEffect = 2;

                            resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " attacked with a poison tipped knife, it was " + wasEffective + "! " + DefendingPlayer.Name + " was poisoned!";
                        }
                        else if (DefendingPlayer.StatusEffect != 0)
                        {
                            DefendingPlayer.currentHealth = DefendingPlayer.currentHealth - finalDamage;

                            resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " attacked with a poison tipped knife, it was " + wasEffective + "!";
                        }

                    }
                    else
                    {
                        DefendingPlayer.currentHealth = DefendingPlayer.currentHealth - finalDamage;

                        resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " attacked with a posion knife, it was " + wasEffective + "!";
                    }


                }
                else
                {
                    resaultstext.GetComponent<Text>().text = AttackingPlayer.Name + " attacked with a poison knife,  and missed";
                }
                break;


        }
    }

}
