using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class resaultsButton : MonoBehaviour {

    public string usingPlayer;
    public string moveName;
    public string Effective;

    public partyManager playerParty;
    public partyManager enemyParty;

    public Text TXT;



    private void Awake()
    {
        var findParty = GameObject.Find("Player_01");
        var findEnemy = GameObject.Find("enemy_01");

        playerParty = findParty.GetComponent<partyManager>();
        enemyParty = findEnemy.GetComponent<partyManager>();

        
    }



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


    }

    public void nextEvent()
    {
        if(playerParty.hasAttacked ==true & enemyParty.hasAttacked == true)
        {
            //end attack cycle
            playerParty.hasAttacked = false;
            enemyParty.hasAttacked = false;
            GameObject.Find("resaultsPanel").SetActive(false);
            playerParty.EndTurn();
            enemyParty.EndTurn();

        }
        else
        {
            if (playerParty.hasAttacked == true)
            {
                enemyParty.PlayerAttack();
            }
            else
            {
                playerParty.PlayerAttack();
            }
        }
       
    }

    public void PlayerResaultsTXT(string User, string attackName, float damage, bool sucssess, int atkType, bool buff, int dmgType)
    {

        

        var findText = GameObject.Find("resultsText");

       TXT = findText.GetComponent<Text>();


        if (sucssess == true)
        {
            switch (atkType)
            {
                case 0:
                    TXT.text = User + " used " + attackName + "!" + " you delt " + damage + " damage";
                    break;
                case 1:
                    if (buff == true)
                    {
                        TXT.text = User + " used " + attackName + "! and raised your " + dmgType + "!"; 
                    }
                    else
                    {
                        TXT.text = User + " used " + attackName + "! and lowered the enemies " + dmgType + "!";
                    }
                        
                    break;
                case 2:
                    TXT.text = User + " used " + attackName + "! and healed for " + damage + "!";
                    break;
            }
            
        }
        else
        {
            TXT.text = User + " used " + attackName + "!" + " oh no! your attack missed";
        }
        

        

    }

    public void playerSwitched(bool switchTarget)
    {
        if (switchTarget == true)
        {
            TXT.text = playerParty.partyMemberOne.Name + " is taging out! " + playerParty.partyMemberTwo.Name + " has joined the battle!";
        }
        else
        {
            TXT.text = playerParty.partyMemberTwo.Name + " is taging out! " + playerParty.partyMemberOne.Name + " has joined the battle!";
        }
        
    }

}


