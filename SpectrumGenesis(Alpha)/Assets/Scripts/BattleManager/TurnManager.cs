using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour {

    public GameObject PlayerUi;
    public GameObject EnemyUi;

    public GameObject SwitchPlayerCharacters;
    public GameObject SwitchEnemyCharacters;

    public Types.SelectedAction PlayerAction;
    public Types.SelectedAction EnemyAction;
    public Types.Char SelectedPlayer;
    public Types.Char SelectedEnemy;
    public Types.Spells PlayerSpell;
    public Types.Spells EnemySpells;


    public void StartTurnSequence() {

    }
    
    public void PlayerSelectedAttack( )
    {

        PlayerAction = Types.SelectedAction.Attack;

    }

    //set selectedspell
    public void PlayerSelectedSpell(int WhatsSelected)
    {
        switch (WhatsSelected)
        {
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            
        }
    }

    //set selectedSwitch
    public void PlayerSelectedSwitch(int WhatsSelected)
    {
        switch (WhatsSelected)
        {
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
        }
    }

    public void PlayerSelectedItem(Types.Items SelectedItem)
    {

    }

    public void PlayerSelectedFlee()
    {

    }
    




}
