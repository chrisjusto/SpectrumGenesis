using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setAttack01Text : MonoBehaviour {

    public charClass partyMemberOne;
    public charClass partyMemberTwo;

    public int attackNumber;

    public Text attackName;
    


	// Use this for initialization
	void Start () {


        var findParty = GameObject.Find("Player_01");

        partyMemberOne = (CharRuby)findParty.GetComponent("CharRuby");

        partyMemberTwo = (CharFlow)findParty.GetComponent("CharFlow");



        attackName = GetComponent<Text>();


        switch (attackNumber)
        {
            case 5:
                attackName.text = (partyMemberOne.attackFiveName);
                break;
            case 4:
                attackName.text = (partyMemberOne.attackFourName);
                break;
            case 3:
                attackName.text = (partyMemberOne.attackThreeName);
                break;
            case 2:
                attackName.text = (partyMemberOne.attackTwoName);
                break;
            case 1:
                attackName.text = (partyMemberOne.attackOneName);
                break;
        }

       
    

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SwitchUI()
    {
        if (partyMemberOne.isActive == true)
        {
            switch (attackNumber)
            {
                case 5:
                    attackName.text = (partyMemberOne.attackFiveName);
                    break;
                case 4:
                    attackName.text = (partyMemberOne.attackFourName);
                    break;
                case 3:
                    attackName.text = (partyMemberOne.attackThreeName);
                    break;
                case 2:
                    attackName.text = (partyMemberOne.attackTwoName);
                    break;
                case 1:
                    attackName.text = (partyMemberOne.attackOneName);
                    break;
            }
        }
        else
            switch (attackNumber)
            {
                case 5:
                    attackName.text = (partyMemberTwo.attackFiveName);
                    break;
                case 4:
                    attackName.text = (partyMemberTwo.attackFourName);
                    break;
                case 3:
                    attackName.text = (partyMemberTwo.attackThreeName);
                    break;
                case 2:
                    attackName.text = (partyMemberTwo.attackTwoName);
                    break;
                case 1:
                    attackName.text = (partyMemberTwo.attackOneName);
                    break;
            }
    }

}
