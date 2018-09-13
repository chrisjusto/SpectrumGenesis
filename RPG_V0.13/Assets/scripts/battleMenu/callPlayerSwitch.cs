using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class callPlayerSwitch : MonoBehaviour {

   // public delegate void ClickAction();
   // public static event ClickAction OnClicked;

    public bool switchPressed;
    public bool hasSwitched;

    public partyManager callParty;
    public setAttack01Text attackSwitch01;
    public resaultsButton resaults;
    public GameObject resultsPanel;

	// Use this for initialization
	void Start () {

        var findParty = GameObject.Find("Player_01");

        callParty = (partyManager)findParty.GetComponent("partyManager");




	}
	
	// Update is called once per frame
	void Update () {

    

	}

    public void SwitchPressed()
    {
        if (callParty.partyMemberOne.dead == true || callParty.partyMemberTwo.dead == true)
        {

        }
        else
        {
            if (hasSwitched == true)
            {
                callParty.ActivateSwitch(Switch: true);

                hasSwitched = false;

                callParty.hasAttacked = true;

                //resultsPanel = GameObject.Find("resaultsPanel");

                resultsPanel.SetActive(true);

                // var findResaults = GameObject.Find("resultsButton");

                // resaults = findResaults.GetComponent<resaultsButton>();

                resaults.nextEvent();

                resaults.playerSwitched(switchTarget: false);



            }
            else
            {
                callParty.ActivateSwitch(Switch: false);

                hasSwitched = true;

                callParty.hasAttacked = true;

                //resultsPanel = GameObject.Find("resaultsPanel");

                resultsPanel.SetActive(true);

               // var findResaults = GameObject.Find("resultsButton");

                //resaults = findResaults.GetComponent<resaultsButton>();

                

                resaults.playerSwitched(switchTarget: true);

                
            }
        }
        

        

    }


}
