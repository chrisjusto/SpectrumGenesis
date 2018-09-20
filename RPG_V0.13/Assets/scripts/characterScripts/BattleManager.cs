using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BattleManager : MonoBehaviour
{



    public GameObject characterUi;
    public GameObject enemyUi;
    public GameObject playerSprite;
    public GameObject enemySprite;

    public GameObject playerHpGauge;
    public GameObject enemyHpGauge;

    public GameObject playerHpNumbers;
    public GameObject enemyHpNumbers;

    public GameObject ResaultsPanel;
    public GameObject ResaultsText;

    public GameObject SwitchMenu;
    public GameObject SwitchMenuBackButton;

    public bool BackToMenuSelectionPanel;
    public bool PlayerSwitched;
    public bool EnemySwitched;
    public bool PlayerUsedAction;
    public bool EnemyUsedAction;
    //private bool SelectedPlayerAttack;
    //private bool SelectedEnemyAttack;

    private int PlayerToSwitch;
    private int EnemyToSwitch;

    private bool PlayerStatusEffected;
    private bool EnemyStatusEffected;
    private int PlayerStatusTurnCount;
    private int EnemyStatusTurnCount;

    //0=switch 1=standerdAttack 2-5=selected attack
    public int SelectedEnemyAction;
    public int PlayerSelectedAction;

    public bool PlayerStatusEffectDisplayed;
    public bool EnemyStatusEffectDisplayed;








    void Start()
    {
        Data.partyData.ActiveChar = Data.partyData.partyMember01;

        Data.partyData.ActiveEnemy = Data.partyData.EnemyParty01;

        characterUi.SetActive(true);

        enemyUi.SetActive(true);

        playerSprite.SetActive(true);

        enemySprite.SetActive(true);

    }

    void Update()
    {
        playerHpGauge.GetComponent<Image>().fillAmount = Mathf.Floor(Data.partyData.ActiveChar.currentHealth) / Mathf.Floor(Data.partyData.ActiveChar.maxHealth);
        playerHpNumbers.GetComponent<Text>().text = Mathf.Floor(Data.partyData.ActiveChar.currentHealth).ToString() + "/" + Mathf.Floor(Data.partyData.ActiveChar.maxHealth).ToString();

        enemyHpGauge.GetComponent<Image>().fillAmount = Mathf.Floor(Data.partyData.ActiveEnemy.currentHealth) / Mathf.Floor(Data.partyData.ActiveEnemy.maxHealth);
        enemyHpNumbers.GetComponent<Text>().text = Mathf.Floor(Data.partyData.ActiveEnemy.currentHealth).ToString() + "/" + Mathf.Floor(Data.partyData.ActiveEnemy.maxHealth).ToString();

    }

    //calling the turn manager from these UI actions SwitchedCharacters SelectedAttack ResaultsPanel

    public void SwitchCharacters(int SelectedCharacter)
    {

        Debug.Log("characterSlected");

        
        switch (SelectedCharacter)
        {
            case 1:
                if (Data.partyData.ActiveChar.dead == true && Data.partyData.ActiveChar != Data.partyData.partyMember01)
                {
                    var oldCharacterName = Data.partyData.ActiveChar.Name;
                    characterUi.SetActive(false);
                    playerSprite.SetActive(false);

                    Data.partyData.ActiveChar = Data.partyData.partyMember01;
                    characterUi.SetActive(true);
                    playerSprite.SetActive(true);

                    ResaultsPanel.SetActive(true);
                    ResaultsText.GetComponent<Text>().text = oldCharacterName + " has been defeated! " + Data.partyData.ActiveChar.Name + " has joined the battle!";



                }
                else if (Data.partyData.ActiveChar == Data.partyData.partyMember01)
                {
                    BackToMenuSelectionPanel = true;
                    ResaultsPanel.SetActive(true);
                    ResaultsText.GetComponent<Text>().text = Data.partyData.ActiveChar.Name + " is already active!";
                }
                else if (Data.partyData.ActiveChar != Data.partyData.partyMember01)
                {
                    if (Data.partyData.partyMember01.dead == true)
                    {
                        BackToMenuSelectionPanel = true;
                        ResaultsPanel.SetActive(true);
                        ResaultsText.GetComponent<Text>().text = Data.partyData.partyMember01.Name + " is passed out and cannot rejoin the battle!";

                    }
                    else
                    {
                        PlayerSelectedAction = 0;
                        PlayerSwitched = true;
                        PlayerToSwitch = 1;
                        TurnManager();


                    }

                    
                }
                break;
            case 2:
                if (Data.partyData.ActiveChar.dead == true && Data.partyData.ActiveChar != Data.partyData.partyMember02)
                {
                    var oldCharacterName = Data.partyData.ActiveChar.Name;
                    characterUi.SetActive(false);
                    playerSprite.SetActive(false);

                    Data.partyData.ActiveChar = Data.partyData.partyMember02;
                    characterUi.SetActive(true);
                    playerSprite.SetActive(true);

                    ResaultsPanel.SetActive(true);
                    ResaultsText.GetComponent<Text>().text = oldCharacterName + " has been defeated! " + Data.partyData.ActiveChar.Name + " has joined the battle!";



                }
                else if (Data.partyData.ActiveChar == Data.partyData.partyMember02)
                {
                    BackToMenuSelectionPanel = true;
                    ResaultsPanel.SetActive(true);
                    ResaultsText.GetComponent<Text>().text = Data.partyData.ActiveChar.Name + " is already active!";
                }
                else if (Data.partyData.ActiveChar != Data.partyData.partyMember02)
                {

                    if (Data.partyData.partyMember02.dead == true)
                    {
                        BackToMenuSelectionPanel = true;
                        ResaultsPanel.SetActive(true);
                        ResaultsText.GetComponent<Text>().text = Data.partyData.partyMember02.Name + " is passed out and cannot rejoin the battle!";

                    }
                    else
                    {
                        PlayerSelectedAction = 0;
                        PlayerSwitched = true;
                        PlayerToSwitch = 2;
                        TurnManager();


                    }

                }
                break;
            case 3:
                if (Data.partyData.ActiveChar.dead == true && Data.partyData.ActiveChar != Data.partyData.partyMember03)
                {
                    var oldCharacterName = Data.partyData.ActiveChar.Name;
                    characterUi.SetActive(false);
                    playerSprite.SetActive(false);

                    Data.partyData.ActiveChar = Data.partyData.partyMember03;
                    characterUi.SetActive(true);
                    playerSprite.SetActive(true);

                    ResaultsPanel.SetActive(true);
                    ResaultsText.GetComponent<Text>().text = oldCharacterName + " has been defeated! " + Data.partyData.ActiveChar.Name + " has joined the battle!";



                }
                else if (Data.partyData.ActiveChar == Data.partyData.partyMember03)
                {
                    BackToMenuSelectionPanel = true;
                    ResaultsPanel.SetActive(true);
                    ResaultsText.GetComponent<Text>().text = Data.partyData.ActiveChar.Name + " is already active!";
                }
                else if (Data.partyData.ActiveChar != Data.partyData.partyMember03)
                {

                    if (Data.partyData.partyMember03.dead == true)
                    {
                        BackToMenuSelectionPanel = true;
                        ResaultsPanel.SetActive(true);
                        ResaultsText.GetComponent<Text>().text = Data.partyData.partyMember03.Name + " is passed out and cannot rejoin the battle!";

                    }
                    else
                    {
                        PlayerSelectedAction = 0;
                        PlayerSwitched = true;
                        PlayerToSwitch = 3;
                        TurnManager();
                    }

                }
                break;
            case 4:
                if (Data.partyData.ActiveChar.dead == true && Data.partyData.ActiveChar != Data.partyData.partyMember04)
                {
                    var oldCharacterName = Data.partyData.ActiveChar.Name;
                    characterUi.SetActive(false);
                    playerSprite.SetActive(false);

                    Data.partyData.ActiveChar = Data.partyData.partyMember04;
                    characterUi.SetActive(true);
                    playerSprite.SetActive(true);

                    ResaultsPanel.SetActive(true);
                    ResaultsText.GetComponent<Text>().text = oldCharacterName + " has been defeated! " + Data.partyData.ActiveChar.Name + " has joined the battle!";



                }
                else if (Data.partyData.ActiveChar == Data.partyData.partyMember04)
                {
                    BackToMenuSelectionPanel = true;
                    ResaultsPanel.SetActive(true);
                    ResaultsText.GetComponent<Text>().text = Data.partyData.ActiveChar.Name + " is already active!";
                }
                else if (Data.partyData.ActiveChar != Data.partyData.partyMember04)
                {

                    if (Data.partyData.partyMember04.dead == true)
                    {
                        BackToMenuSelectionPanel = true;
                        ResaultsPanel.SetActive(true);
                        ResaultsText.GetComponent<Text>().text = Data.partyData.partyMember04.Name + " is passed out and cannot rejoin the battle!";

                    }
                    else
                    {
                        PlayerSelectedAction = 0;
                        PlayerSwitched = true;
                        PlayerToSwitch = 4;
                        TurnManager();
                    }

                }
                break;
        }

    }

    public void SelectedWeaponAttack()
    {
        Debug.Log("weaponAttackSelected");
        PlayerSelectedAction = 1;
        TurnManager();
    }

    public void SelectAttack(int attackSelected)
    {
        Debug.Log("skillSelected");
        if (Data.partyData.ActiveChar.attackUses[attackSelected - 2] > 0)
        {
            PlayerSelectedAction = attackSelected;
            Data.partyData.ActiveChar.attackUses[attackSelected - 2] = Data.partyData.ActiveChar.attackUses[attackSelected - 2] - 1;
            TurnManager();
        }
        else if (Data.partyData.ActiveChar.attackUses[attackSelected - 2]<= 0)
        {
            BackToMenuSelectionPanel = true;
            ResaultsPanel.SetActive(true);
            ResaultsText.GetComponent<Text>().text = "this ability is out of power to use!";
        }
    }

    //RESAULTS BUTTON FUNCTION

    public void ResaultsButton()
    {
        Debug.Log("PRESS THE FUCKING BUTTON");
        if(Data.partyData.ActiveChar.currentHealth <= 0)
        {
            //call playerDeath and call a player to switch to
            Data.partyData.ActiveChar.dead = true;
            PlayerDied();
    

        }
        else if (Data.partyData.ActiveEnemy.currentHealth <= 0)
        {
            //call enemy death and call enemy to switch to
            Data.partyData.ActiveEnemy.dead = true;
            EnemyDied();

        }
        else if (BackToMenuSelectionPanel == true)
        {
            ResaultsPanel.SetActive(false);
            BackToMenuSelectionPanel = false;


        }
        else if (PlayerStatusEffectDisplayed == true)
        {
            PlayerStatusEffectDisplayed = false;
            CallEnemyStatusEffect();
 
        }
        else if (EnemyStatusEffectDisplayed == true)
        {
            EnemyStatusEffectDisplayed = false;
            CallFinalEndTurn();

        }
        else if (BackToMenuSelectionPanel == false)
        {
            TurnManager();
            Debug.Log("callingallturnmanagers");

        }


    }


    //TurnManager

    public void TurnManager()

    {
        //ENEMY AI ACTIONS

        if (EnemyUsedAction == false && Data.partyData.ActiveEnemy.charging == false)
        {
            //SelectedEnemyAction = Random.Range(0, 5);
            SelectedEnemyAction = 1;

            if (SelectedEnemyAction == 0)
            {
                EnemySwitched = true;
            }
        }
        //STATUS EFFECT CHECKS
        if (Data.partyData.ActiveChar.StatusEffect ==3 || Data.partyData.ActiveChar.StatusEffect ==4 && PlayerSwitched != true && PlayerUsedAction == false)
        {
            switch (Data.partyData.ActiveChar.StatusEffect)
            {
                case 3:
                    ResaultsPanel.SetActive(true);

                    if (PlayerStatusTurnCount >= 3)
                    {
                        if(Random.Range (1,2) == 2)
                        {

                            ResaultsText.GetComponent<Text>().text = Data.partyData.ActiveChar.Name + " is asleep, and has yet to awaken!";
                            PlayerStatusTurnCount = PlayerStatusTurnCount + 1;
                            PlayerUsedAction = true;

                        }
                        else
                        {
                            Data.partyData.ActiveChar.StatusEffect = 0;
                            PlayerStatusTurnCount = 0;
                            ResaultsText.GetComponent<Text>().text = Data.partyData.ActiveChar.Name + " has woken up from a slumber!";

                        }
                    }
                    else if (PlayerStatusTurnCount < 3)
                    {
                        ResaultsText.GetComponent<Text>().text = Data.partyData.ActiveChar.Name + " is asleep, and has yet to awaken!";
                        PlayerStatusTurnCount = PlayerStatusTurnCount + 1;
                        PlayerUsedAction = true;
                    }
                    break;
                case 4:
                    ResaultsPanel.SetActive(true);

                    if (PlayerStatusTurnCount >= 3)
                    {
                        if (Random.Range(1, 2) == 2)
                        {

                            ResaultsText.GetComponent<Text>().text = Data.partyData.ActiveChar.Name + " is Frozen and cannot move!";
                            PlayerStatusTurnCount = PlayerStatusTurnCount + 1;
                            PlayerUsedAction = true;

                        }
                        else
                        {
                            Data.partyData.ActiveChar.StatusEffect = 0;
                            PlayerStatusTurnCount = 0;
                            ResaultsText.GetComponent<Text>().text = Data.partyData.ActiveChar.Name + " has broken from the icey prison!";

                        }
                    }
                    else if (PlayerStatusTurnCount < 3)
                    {
                        ResaultsText.GetComponent<Text>().text = Data.partyData.ActiveChar.Name + " is frozen and cannot move!";
                        PlayerStatusTurnCount = PlayerStatusTurnCount + 1;
                        PlayerUsedAction = true;
                    }
                    break;
            }
        }      
        else if (Data.partyData.ActiveEnemy.StatusEffect == 3 || Data.partyData.ActiveEnemy.StatusEffect == 4 && EnemySwitched != true && EnemyUsedAction == false)
        {
            //CHECK ENEMY STATUS EFFECTS
            switch (Data.partyData.ActiveEnemy.StatusEffect)
            {
                case 3:
                    ResaultsPanel.SetActive(true);

                    if (EnemyStatusTurnCount >= 3)
                    {
                        if (Random.Range(1, 2) == 2)
                        {

                            ResaultsText.GetComponent<Text>().text = Data.partyData.ActiveEnemy.Name + " is asleep, and has yet to awaken!";
                            EnemyStatusTurnCount = EnemyStatusTurnCount + 1;
                            EnemyUsedAction = true;

                        }
                        else
                        {
                            Data.partyData.ActiveEnemy.StatusEffect = 0;
                            EnemyStatusTurnCount = 0;
                            ResaultsText.GetComponent<Text>().text = Data.partyData.ActiveEnemy.Name + " has woken up from a slumber!";

                        }
                    }
                    else if (EnemyStatusTurnCount < 3)
                    {
                        ResaultsText.GetComponent<Text>().text = Data.partyData.ActiveEnemy.Name + " is asleep, and has yet to awaken!";
                        EnemyStatusTurnCount = EnemyStatusTurnCount + 1;
                        EnemyUsedAction = true;
                    }
                    break;
                case 4:
                    ResaultsPanel.SetActive(true);

                    if (EnemyStatusTurnCount >= 3)
                    {
                        if (Random.Range(1, 2) == 2)
                        {

                            ResaultsText.GetComponent<Text>().text = Data.partyData.ActiveEnemy.Name + " is Frozen and cannot move!";
                            EnemyStatusTurnCount = EnemyStatusTurnCount + 1;
                            EnemyUsedAction = true;

                        }
                        else
                        {
                            Data.partyData.ActiveEnemy.StatusEffect = 0;
                            EnemyStatusTurnCount = 0;
                            ResaultsText.GetComponent<Text>().text = Data.partyData.ActiveEnemy.Name + " has broken from the icey prison!";

                        }
                    }
                    else if (EnemyStatusTurnCount < 3)
                    {
                        ResaultsText.GetComponent<Text>().text = Data.partyData.ActiveEnemy.Name + " is frozen and cannot move!";
                        EnemyStatusTurnCount = EnemyStatusTurnCount + 1;
                        EnemyUsedAction = true;
                    }
                    break;
            }
        }
        else if (PlayerUsedAction && EnemyUsedAction == true)
        {
            Debug.Log("bothActionsUsed");
            CallEndTurn();

        }
       else if (PlayerUsedAction == true)
        {
            if(EnemySwitched == true)
            {
                EnemyUsedAction = true;
                CallEnemySwitch();
            }
            else if (SelectedEnemyAction == 1)
            {
                EnemyUsedAction = true;
                CallEnemyWeaponAttack();
            }
            else if (SelectedEnemyAction !=0 && SelectedEnemyAction != 1)
            {
                EnemyUsedAction = true;
                CallEnemySkillAttack();
            }
        }
       else if (EnemyUsedAction == true)
        {
            if (PlayerSwitched == true)
            {
                PlayerUsedAction = true;
                CallPlayerSwitch();
            }
            else if (PlayerSelectedAction == 1)
            {
                PlayerUsedAction = true;
                CallPlayerWeaponAttack();
            }
            else if (PlayerSelectedAction != 1 && PlayerSelectedAction != 0)
            {
                PlayerUsedAction = true;
                CallPlayerSkillAttack();
            }

        }
       else if (PlayerUsedAction == false && EnemyUsedAction == false)
        {
            //BEGIN TURN SEQUENCE
            Debug.Log("startTurn");
            //RUN SPEED CHECK
            if (Data.partyData.ActiveChar.SPD >= Data.partyData.ActiveEnemy.SPD)
            {
                Debug.Log("playerSPeedCheck");
                //IF PLAYER CALLED A SWITCH
                if (PlayerSwitched == true)
                {

                    //IF ENEMY CALLED A SWITCH PLAYER TAKES TURN FIRST
                    if (SelectedEnemyAction == 0)
                    {
                        PlayerUsedAction = true;
                        CallPlayerSwitch();
                    }
                    else if (SelectedEnemyAction == 1)
                    {
                        //CHECK WEAPON HAS PRIORITY OVER SWITCH
                        if (WeaponDataBase.weapons.weaponSuperPriority[Data.partyData.ActiveEnemy.Weapon] == true)
                        {
                            EnemyUsedAction = true;
                            CallEnemyWeaponAttack();
                        }
                        else if (WeaponDataBase.weapons.weaponSuperPriority[Data.partyData.ActiveEnemy.Weapon] == false)
                        {
                            PlayerUsedAction = true;
                            CallPlayerSwitch();
                        }
                    }
                    else if (SelectedEnemyAction != 0 || SelectedEnemyAction != 1)
                    {
                        //CHECK IF ATTACKS HAVE PRIORITY OVER SWITCH
                        if (AttackDatabase.attacks.AttackSuperPriority[Data.partyData.ActiveEnemy.EquipedAttacks[(SelectedEnemyAction - 2)]] == true)
                        {
                            EnemyUsedAction = true;
                            CallEnemySkillAttack();
                        }
                        else if (AttackDatabase.attacks.AttackSuperPriority[Data.partyData.ActiveEnemy.EquipedAttacks[(SelectedEnemyAction - 2)]] == false)
                        {
                            PlayerUsedAction = true;
                            CallPlayerSwitch();
                        }
                    }
                }
                else if(PlayerSwitched == false)
                {
                    //check if enemySwitched
                    if(EnemySwitched == true)
                    {
                        if (PlayerSelectedAction == 1)
                        {
                            //CHECK IF PLAYER WEAPON HAS PRIORITY OVER ENEMYSWITCH
                            if(WeaponDataBase.weapons.weaponSuperPriority[Data.partyData.ActiveChar.Weapon] == true)
                            {
                                PlayerUsedAction = true;
                                CallPlayerWeaponAttack();
                            }
                            else if(WeaponDataBase.weapons.weaponSuperPriority[Data.partyData.ActiveChar.Weapon] == false)
                            {
                                EnemyUsedAction = true;
                                CallEnemySwitch();
                            }
                        }
                        else if (PlayerSelectedAction != 1 && PlayerSelectedAction != 0)
                        {
                            //CHECK IF PLAYER SKILL HAS PRIORITY OVER ENEMYSWITCH
                            if(AttackDatabase.attacks.AttackSuperPriority[Data.partyData.ActiveChar.EquipedAttacks[PlayerSelectedAction - 2]] == true)
                            {
                                PlayerUsedAction = true;
                                CallPlayerSkillAttack();
                            }
                            else if (AttackDatabase.attacks.AttackSuperPriority[Data.partyData.ActiveChar.EquipedAttacks[PlayerSelectedAction - 2]] == false)
                            {
                                EnemyUsedAction = true;
                                CallEnemySwitch();
                            }
                        }
                    }
                    //IF ENEMY DIDNT SWITCH THEN--
                    else if (EnemySwitched == false)
                    {
                        //CHECK IF ENEMY HAS WEAPON PRIORITY
                        if (SelectedEnemyAction == 1 && WeaponDataBase.weapons.weaponPriority[Data.partyData.ActiveEnemy.Weapon] == true)
                        {
                            EnemyUsedAction = true;
                            CallEnemyWeaponAttack();
                        }
                        else if (SelectedEnemyAction ==1 && WeaponDataBase.weapons.weaponPriority[Data.partyData.ActiveEnemy.Weapon] == false)
                        {
                            PlayerUsedAction = true;
                            if (PlayerSelectedAction == 1)
                            {
                                CallPlayerWeaponAttack();
                            }
                            else if (PlayerSelectedAction != 1)
                            {
                                CallPlayerSkillAttack();
                            }
                        }
                        //CHECK IF ENEMY SKILL HAS PRIORITY
                        if (SelectedEnemyAction != 1 && SelectedEnemyAction != 0 && AttackDatabase.attacks.AttackPriority[Data.partyData.ActiveEnemy.EquipedAttacks[SelectedEnemyAction - 2]] ==true)
                        {
                            EnemyUsedAction = true;
                            CallEnemySkillAttack();
                        }
                        else if (SelectedEnemyAction != 1 && SelectedEnemyAction != 0 && AttackDatabase.attacks.AttackPriority[Data.partyData.ActiveEnemy.EquipedAttacks[SelectedEnemyAction - 2]] == false)
                        {
                            PlayerUsedAction = true;
                            if (PlayerSelectedAction == 1)
                            {
                                CallPlayerWeaponAttack();
                            }
                            else if (PlayerSelectedAction != 1)
                            {
                                CallPlayerSkillAttack();
                            }

                        }
                     
                    }

                }

            }
            //CHECK IF ENMEY IS FASTER
            else if (Data.partyData.ActiveChar.SPD < Data.partyData.ActiveEnemy.SPD)
            {
                //IF ENEMY CALLED A SWITCH
                if (EnemySwitched == true)
                {
                    //IF PLAYER CALLED SWITCH THEN FASTER ENEMY GOES FIRST
                    if (PlayerSelectedAction == 0)
                    {
                        EnemyUsedAction = true;
                        CallEnemySwitch();
                    }
                    else if (PlayerSelectedAction == 1)
                    {
                        //CHECK WEAPON HAS PRIORITY OVER SWITCH
                        if (WeaponDataBase.weapons.weaponSuperPriority[Data.partyData.ActiveChar.Weapon] == true)
                        {
                            PlayerUsedAction = true;
                            CallPlayerWeaponAttack();
                        }
                        else if (WeaponDataBase.weapons.weaponSuperPriority[Data.partyData.ActiveChar.Weapon] == false)
                        {
                            //call player switch
                            EnemyUsedAction = true;
                            CallEnemySwitch();
                        }
                    }
                    else if (PlayerSelectedAction != 0 || PlayerSelectedAction != 1)
                    {
                        //CHECK IF SKILLS HAVE PRIORITY OVER SWITCH
                        if (AttackDatabase.attacks.AttackSuperPriority[Data.partyData.ActiveChar.EquipedAttacks[(PlayerSelectedAction - 2)]] == true)
                        {
                            PlayerUsedAction = true;
                            CallPlayerSkillAttack();
                        }
                        else if (AttackDatabase.attacks.AttackSuperPriority[Data.partyData.ActiveChar.EquipedAttacks[(PlayerSelectedAction - 2)]] == false)
                        {
                            EnemyUsedAction = true;
                            CallEnemySwitch();
                        }
                    }
                }
                else if (EnemySwitched == false)
                {
                    //CHECK IF PLAYER SWITCHED//
                    if (PlayerSwitched == true)
                    {
                        if (SelectedEnemyAction == 1)
                        {
                            //CHECK IF ENEMY HAS WEAPON PRIORITY OVER PLAYER SWICTH
                            if (WeaponDataBase.weapons.weaponSuperPriority[Data.partyData.ActiveEnemy.Weapon] == true)
                            {
                                EnemyUsedAction = true;
                                CallEnemyWeaponAttack();
                            }
                            else if (WeaponDataBase.weapons.weaponSuperPriority[Data.partyData.ActiveEnemy.Weapon] == false)
                            {
                                PlayerUsedAction = true;
                                CallPlayerSwitch();
                            }
                        }
                        else if (SelectedEnemyAction != 1 && SelectedEnemyAction != 0)
                        {
                            //CHECK IF ENEMY SKILL HAS PRIORITY OVER PLAYER SWITCH
                            if (AttackDatabase.attacks.AttackSuperPriority[Data.partyData.ActiveChar.EquipedAttacks[SelectedEnemyAction - 2]] == true)
                            {
                                EnemyUsedAction = true;
                                CallEnemySkillAttack();
                            }
                            else if (AttackDatabase.attacks.AttackSuperPriority[Data.partyData.ActiveChar.EquipedAttacks[SelectedEnemyAction - 2]] == false)
                            {
                                PlayerUsedAction = true;
                                CallPlayerSwitch();
                            }
                        }
                    }
                    //IF PLAYER DIDNT SWITCH--
                    else if (PlayerSwitched == false)
                    {
                        //CHECK IF PLAYER HAS WEAPON PRIORITY
                        if (PlayerSelectedAction == 1 && WeaponDataBase.weapons.weaponPriority[Data.partyData.ActiveChar.Weapon] == true)
                        {
                            PlayerUsedAction = true;
                            CallPlayerWeaponAttack();
                        }
                        else if (PlayerSelectedAction == 1 && WeaponDataBase.weapons.weaponPriority[Data.partyData.ActiveChar.Weapon] == false)
                        {
                            EnemyUsedAction = true;
                            if (SelectedEnemyAction == 1)
                            {
                                CallEnemyWeaponAttack();
                            }
                            else if (SelectedEnemyAction != 1)
                            {
                                CallEnemySkillAttack();
                            }
                        }
                        //CHECK IF PLAYER SKILL HAS PRIORITY
                        if (PlayerSelectedAction != 1 && PlayerSelectedAction != 0 && AttackDatabase.attacks.AttackPriority[Data.partyData.ActiveChar.EquipedAttacks[PlayerSelectedAction - 2]] == true)
                        {
                            PlayerUsedAction = true;
                            CallPlayerSkillAttack();
                        }
                        else if (PlayerSelectedAction != 1 && PlayerSelectedAction != 0 && AttackDatabase.attacks.AttackPriority[Data.partyData.ActiveChar.EquipedAttacks[PlayerSelectedAction - 2]] == false)
                        {
                            PlayerUsedAction = true;
                            if (SelectedEnemyAction == 1)
                            {
                                CallEnemyWeaponAttack();
                            }
                            else if (SelectedEnemyAction != 1)
                            {
                                CallEnemySkillAttack();
                            }
                        }

                    }

                }

            }

        }

    }

    //THESE FUNCTIONS GET CALLED BY THE TURN MANAGER



    //CALL THE PLAYER SWITCH
    public void CallPlayerSwitch()
    {

        var oldCharacterName = Data.partyData.ActiveChar.Name;
        characterUi.SetActive(false);
        playerSprite.SetActive(false);
        switch (PlayerToSwitch)
        {
            case 1:
                Data.partyData.ActiveChar = Data.partyData.partyMember01;
                break;
            case 2:
                Data.partyData.ActiveChar = Data.partyData.partyMember02;
                break;
            case 3:
                Data.partyData.ActiveChar = Data.partyData.partyMember03;
                break;
            case 4:
                Data.partyData.ActiveChar = Data.partyData.partyMember04;
                break;
        }

        BackToMenuSelectionPanel = false;
        ResaultsPanel.SetActive(true);
        ResaultsText.GetComponent<Text>().text = oldCharacterName + " has tired out! " + Data.partyData.ActiveChar.Name + " has tagged in!";
        characterUi.SetActive(true);
        playerSprite.SetActive(true);
        

    }
    //CALLS THE ENEMY SWITCH
    public void CallEnemySwitch()
    {
        var oldCharacterName = Data.partyData.ActiveEnemy.Name;
        enemyUi.SetActive(false);
        enemySprite.SetActive(false);
        switch (Random.Range(1,4))
        {
            case 1:
                Data.partyData.ActiveEnemy = Data.partyData.EnemyParty01;
                break;
            case 2:
                Data.partyData.ActiveEnemy = Data.partyData.EnemyParty02;
                break;
            case 3:
                Data.partyData.ActiveEnemy = Data.partyData.EnemyParty03;
                break;
            case 4:
                Data.partyData.ActiveEnemy = Data.partyData.EnemyParty04;
                break;
        }
        ResaultsPanel.SetActive(true);
        ResaultsText.GetComponent<Text>().text = oldCharacterName + " has tired out! " + Data.partyData.ActiveEnemy.Name + " has tagged in!";
        enemyUi.SetActive(true);
        enemySprite.SetActive(true);
    }
    //CALLS THE PLAYERS WEAPON ATTACK
    public void CallPlayerWeaponAttack()
    {
        Debug.Log("callPlayerAttack");
        WeaponDataBase.weapons.AttackFunction(AttackingPlayer: Data.partyData.ActiveChar, DefendingPlayer: Data.partyData.ActiveEnemy, SelectedAttack: Data.partyData.ActiveChar.Weapon, resaultstext: ResaultsText);
        ResaultsPanel.SetActive(true);
    }
    //CALLS THE ENEMIES WEAPON ATTACK
    public void CallEnemyWeaponAttack()
    {
        Debug.Log("callEnemyAttack");
        WeaponDataBase.weapons.AttackFunction(AttackingPlayer: Data.partyData.ActiveEnemy, DefendingPlayer: Data.partyData.ActiveChar, SelectedAttack: Data.partyData.ActiveEnemy.Weapon, resaultstext: ResaultsText);
        ResaultsPanel.SetActive(true);
    }
    //CALLS THE PLAYERS SKILL ATTACKS
    public void CallPlayerSkillAttack()
    {
        AttackDatabase.attacks.Attack(AttackingPlayer: Data.partyData.ActiveChar, DefendingPlayer: Data.partyData.ActiveEnemy, SelectedAttack: Data.partyData.ActiveChar.EquipedAttacks[PlayerSelectedAction - 2], resaultstext: ResaultsText, Manager: this);
        ResaultsPanel.SetActive(true);

    }
    //CALLS THE ENEMYS SKILL ATTACKS
    public void CallEnemySkillAttack()
    {
        AttackDatabase.attacks.Attack(AttackingPlayer: Data.partyData.ActiveEnemy, DefendingPlayer: Data.partyData.ActiveChar, SelectedAttack: Data.partyData.ActiveEnemy.EquipedAttacks[PlayerSelectedAction - 2], resaultstext: ResaultsText, Manager: this);
        ResaultsPanel.SetActive(true);
    }
    //CALL PLAYERSTATUSEFFECTS
    public void CallPlayerStatusEffect()
    {
       if (Data.partyData.ActiveChar.StatusEffect == 0)
        {

            CallEnemyStatusEffect();

        }
       else if (Data.partyData.ActiveChar.StatusEffect == 1 || Data.partyData.ActiveChar.StatusEffect == 2)
        {
            switch (Data.partyData.ActiveChar.StatusEffect)
            {
                //BURN
                case 1:
                    Data.partyData.ActiveChar.currentHealth = (Data.partyData.ActiveChar.currentHealth - (Data.partyData.ActiveChar.maxHealth / 10));
                    ResaultsText.GetComponent<Text>().text = Data.partyData.ActiveChar.Name + " has been afflicted by burn!";
                    PlayerStatusEffectDisplayed = true;
                    break;
                case 2:
                    Data.partyData.ActiveChar.currentHealth = (Data.partyData.ActiveChar.currentHealth - (Data.partyData.ActiveChar.maxHealth / 10));
                    ResaultsText.GetComponent<Text>().text = Data.partyData.ActiveChar.Name + " has been afflicted by poinson!";
                    PlayerStatusEffectDisplayed = true;
                    break;
            }
        }
        else
        {
            CallEnemyStatusEffect();
        }
    }
    //CALL ENEMYsTATUSEFFECTS
    public void CallEnemyStatusEffect()
    {
        if (Data.partyData.ActiveEnemy.StatusEffect == 0)
        {

            CallFinalEndTurn();

        }
        else if (Data.partyData.ActiveEnemy.StatusEffect == 1 || Data.partyData.ActiveEnemy.StatusEffect == 2)
        {
            switch (Data.partyData.ActiveEnemy.StatusEffect)
            {
                //BURN
                case 1:
                    Data.partyData.ActiveEnemy.currentHealth = (Data.partyData.ActiveEnemy.currentHealth - (Data.partyData.ActiveEnemy.maxHealth / 10));
                    ResaultsText.GetComponent<Text>().text = Data.partyData.ActiveEnemy.Name + " has been afflicted by burn!";
                    EnemyStatusEffectDisplayed = true;
                    break;
                case 2:
                    Data.partyData.ActiveEnemy.currentHealth = (Data.partyData.ActiveEnemy.currentHealth - (Data.partyData.ActiveEnemy.maxHealth / 10));
                    ResaultsText.GetComponent<Text>().text = Data.partyData.ActiveEnemy.Name + " has been afflicted by poinson!";
                    EnemyStatusEffectDisplayed = true;
                    break;
            }
        }
        else
        {
            CallFinalEndTurn();
        }
    }
    //CALLS END OF TURN CHECKS FOR STATUS EFFECTS
    public void CallEndTurn()
    {

        CallPlayerStatusEffect();
        
    }
    public void CallFinalEndTurn()
    {
        if (Data.partyData.ActiveChar.charging == true)
        {
            EnemySwitched = false;
            PlayerSwitched = false;
            PlayerUsedAction = false;
            EnemyUsedAction = false;
            PlayerStatusEffectDisplayed = false;
            EnemyStatusEffectDisplayed = false;

            TurnManager();

        }
        else if (Data.partyData.ActiveChar.charging == false)
        {
            Debug.Log("finalEndTurn");
            PlayerUsedAction = false;
            EnemyUsedAction = false;
            PlayerStatusEffectDisplayed = false;
            EnemyStatusEffectDisplayed = false;
            PlayerSwitched = false;
            EnemySwitched = false;
            BackToMenuSelectionPanel = true;
            Data.partyData.ActiveChar.blocked = false;
            ResaultsPanel.SetActive(false);
            BackToMenuSelectionPanel = false;

        }

    }
    //PLAYER DEATH
    public void PlayerDied()
    {
        if (Data.partyData.partyMember01.dead == true && Data.partyData.partyMember02.dead == true && Data.partyData.partyMember03.dead == true && Data.partyData.partyMember04.dead == true)
        {
            //call loose condition
            Debug.Log("Defeat");
        }
        else
        {
            SwitchMenu.SetActive(true);
            SwitchMenuBackButton.SetActive(false);
        }
    }
    //CALL DIFFERENT DEAD ENEMIES WITHOUT STACK OVERFLOW
    public void CallEnemy01()
    {
        if (Data.partyData.ActiveEnemy == Data.partyData.EnemyParty01) //IF THE SELECTED SWITCH IS THE DEAD CHARACTER THEN ROLL AGAIN
        {
            CallEnemy02();
        }
        else if (Data.partyData.EnemyParty01.dead == true) //IF THE SELECTED SWITCH IS A DEAD CHARACTER ROLL AGAIN
        {
            CallEnemy02();
        }
        else
        {
            var oldCharacterName = Data.partyData.ActiveEnemy.Name;
            enemyUi.SetActive(false);
            enemySprite.SetActive(false);

            Data.partyData.ActiveEnemy = Data.partyData.EnemyParty01;

            ResaultsPanel.SetActive(true);
            ResaultsText.GetComponent<Text>().text = oldCharacterName + " has passed out! " + Data.partyData.ActiveEnemy.Name + " has tagged in!";
            enemyUi.SetActive(true);
            enemySprite.SetActive(true);

        }
    }
    public void CallEnemy02()
    {
        if (Data.partyData.ActiveEnemy == Data.partyData.EnemyParty02) //IF THE SELECTED SWITCH IS THE DEAD CHARACTER THEN ROLL AGAIN
        {
            CallEnemy03();
        }
        else if (Data.partyData.EnemyParty02.dead == true) //IF THE SELECTED SWITCH IS A DEAD CHARACTER ROLL AGAIN
        {
            CallEnemy03();
        }
        else
        {
            var oldCharacterName = Data.partyData.ActiveEnemy.Name;
            enemyUi.SetActive(false);
            enemySprite.SetActive(false);

            Data.partyData.ActiveEnemy = Data.partyData.EnemyParty02;

            ResaultsPanel.SetActive(true);
            ResaultsText.GetComponent<Text>().text = oldCharacterName + " has passed out! " + Data.partyData.ActiveEnemy.Name + " has tagged in!";
            enemyUi.SetActive(true);
            enemySprite.SetActive(true);

        }
    }
    public void CallEnemy03()
    {
        if (Data.partyData.ActiveEnemy == Data.partyData.EnemyParty03) //IF THE SELECTED SWITCH IS THE DEAD CHARACTER THEN ROLL AGAIN
        {
            CallEnemy04();
        }
        else if (Data.partyData.EnemyParty03.dead == true) //IF THE SELECTED SWITCH IS A DEAD CHARACTER ROLL AGAIN
        {
            CallEnemy04();
        }
        else
        {
            var oldCharacterName = Data.partyData.ActiveEnemy.Name;
            enemyUi.SetActive(false);
            enemySprite.SetActive(false);

            Data.partyData.ActiveEnemy = Data.partyData.EnemyParty03;

            ResaultsPanel.SetActive(true);
            ResaultsText.GetComponent<Text>().text = oldCharacterName + " has passed out! " + Data.partyData.ActiveEnemy.Name + " has tagged in!";
            enemyUi.SetActive(true);
            enemySprite.SetActive(true);

        }
    }
    public void CallEnemy04()
    {
        if (Data.partyData.ActiveEnemy == Data.partyData.EnemyParty04) //IF THE SELECTED SWITCH IS THE DEAD CHARACTER THEN ROLL AGAIN
        {
            CallEnemy01();
        }
        else if (Data.partyData.EnemyParty04.dead == true) //IF THE SELECTED SWITCH IS A DEAD CHARACTER ROLL AGAIN
        {
            CallEnemy01();
        }
        else
        {
            var oldCharacterName = Data.partyData.ActiveEnemy.Name;
            enemyUi.SetActive(false);
            enemySprite.SetActive(false);

            Data.partyData.ActiveEnemy = Data.partyData.EnemyParty04;

            ResaultsPanel.SetActive(true);
            ResaultsText.GetComponent<Text>().text = oldCharacterName + " has passed out! " + Data.partyData.ActiveEnemy.Name + " has tagged in!";
            enemyUi.SetActive(true);
            enemySprite.SetActive(true);

        }
    }

    //ENEMY DEATH
    public void EnemyDied()
    {
        if (Data.partyData.EnemyParty01.dead == true && Data.partyData.EnemyParty02.dead == true && Data.partyData.EnemyParty03.dead == true && Data.partyData.EnemyParty04.dead == true)
        {
            //call win condition
            Debug.Log("victory");
        }
        else
        {
            var switchEnemy = Random.Range(1, 4);

            switch (switchEnemy)
            {
                case 1:
                    if (Data.partyData.ActiveEnemy == Data.partyData.EnemyParty01) //IF THE SELECTED SWITCH IS THE DEAD CHARACTER THEN ROLL AGAIN
                    {
                        CallEnemy02();
                    }
                    else if (Data.partyData.EnemyParty01.dead == true) //IF THE SELECTED SWITCH IS A DEAD CHARACTER ROLL AGAIN
                    {
                        CallEnemy02();
                    }
                    else
                    {
                        var oldCharacterName = Data.partyData.ActiveEnemy.Name;
                        enemyUi.SetActive(false);
                        enemySprite.SetActive(false);

                        Data.partyData.ActiveEnemy = Data.partyData.EnemyParty01;

                        ResaultsPanel.SetActive(true);
                        ResaultsText.GetComponent<Text>().text = oldCharacterName + " has passed out! " + Data.partyData.ActiveEnemy.Name + " has tagged in!";
                        enemyUi.SetActive(true);
                        enemySprite.SetActive(true);

                    }

                    break;
                case 2:
                    if (Data.partyData.ActiveEnemy == Data.partyData.EnemyParty02) //IF THE SELECTED SWITCH IS THE DEAD CHARACTER THEN ROLL AGAIN
                    {
                        CallEnemy03();
                    }
                    else if (Data.partyData.EnemyParty02.dead == true) //IF THE SELECTED SWITCH IS A DEAD CHARACTER ROLL AGAIN
                    {
                        CallEnemy03();
                    }
                    else
                    {
                        var oldCharacterName = Data.partyData.ActiveEnemy.Name;
                        enemyUi.SetActive(false);
                        enemySprite.SetActive(false);

                        Data.partyData.ActiveEnemy = Data.partyData.EnemyParty02;

                        ResaultsPanel.SetActive(true);
                        ResaultsText.GetComponent<Text>().text = oldCharacterName + " has passed out! " + Data.partyData.ActiveEnemy.Name + " has tagged in!";
                        enemyUi.SetActive(true);
                        enemySprite.SetActive(true);

                    }

                    break;
                case 3:
                    if (Data.partyData.ActiveEnemy == Data.partyData.EnemyParty03) //IF THE SELECTED SWITCH IS THE DEAD CHARACTER THEN ROLL AGAIN
                    {
                        CallEnemy04();
                    }
                    else if (Data.partyData.EnemyParty03.dead == true) //IF THE SELECTED SWITCH IS A DEAD CHARACTER ROLL AGAIN
                    {
                        CallEnemy04();
                    }
                    else
                    {
                        var oldCharacterName = Data.partyData.ActiveEnemy.Name;
                        enemyUi.SetActive(false);
                        enemySprite.SetActive(false);

                        Data.partyData.ActiveEnemy = Data.partyData.EnemyParty03;

                        ResaultsPanel.SetActive(true);
                        ResaultsText.GetComponent<Text>().text = oldCharacterName + " has passed out! " + Data.partyData.ActiveEnemy.Name + " has tagged in!";
                        enemyUi.SetActive(true);
                        enemySprite.SetActive(true);

                    }

                    break;
                case 4:
                    if (Data.partyData.ActiveEnemy == Data.partyData.EnemyParty04) //IF THE SELECTED SWITCH IS THE DEAD CHARACTER THEN ROLL AGAIN
                    {
                        CallEnemy01();
                    }
                    else if (Data.partyData.EnemyParty04.dead == true) //IF THE SELECTED SWITCH IS A DEAD CHARACTER ROLL AGAIN
                    {
                        CallEnemy01();
                    }
                    else
                    {
                        var oldCharacterName = Data.partyData.ActiveEnemy.Name;
                        enemyUi.SetActive(false);
                        enemySprite.SetActive(false);

                        Data.partyData.ActiveEnemy = Data.partyData.EnemyParty04;

                        ResaultsPanel.SetActive(true);
                        ResaultsText.GetComponent<Text>().text = oldCharacterName + " has passed out! " + Data.partyData.ActiveEnemy.Name + " has tagged in!";
                        enemyUi.SetActive(true);
                        enemySprite.SetActive(true);

                    }

                    break;

            }

        }
    }

}
