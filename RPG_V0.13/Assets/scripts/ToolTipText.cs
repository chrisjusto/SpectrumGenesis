using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolTipText : MonoBehaviour {

    public GameObject powerAcc;
    public GameObject uses;
    public GameObject description;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnEnable()
    {

    }
    public void Enable(bool Equiped, int HoveredAttack)
    {
        if (Equiped == true)
        {
            switch (HoveredAttack)
            {
                case 1:

                    powerAcc.GetComponent<Text>().text = AttackDatabase.attacks.AttackPowerAcc[Data.partyData.ActiveChar.Attack01];
                    uses.GetComponent<Text>().text = AttackDatabase.attacks.AttackUses[Data.partyData.ActiveChar.Attack01].ToString();
                    description.GetComponent<Text>().text = AttackDatabase.attacks.AttackDesc[Data.partyData.ActiveChar.Attack01];
           
                    break;
                case 2:
                    powerAcc.GetComponent<Text>().text = AttackDatabase.attacks.AttackPowerAcc[Data.partyData.ActiveChar.Attack02];
                    uses.GetComponent<Text>().text = AttackDatabase.attacks.AttackUses[Data.partyData.ActiveChar.Attack02].ToString();
                    description.GetComponent<Text>().text = AttackDatabase.attacks.AttackDesc[Data.partyData.ActiveChar.Attack02];
                    break;
                case 3:
                    powerAcc.GetComponent<Text>().text = AttackDatabase.attacks.AttackPowerAcc[Data.partyData.ActiveChar.Attack03];
                    uses.GetComponent<Text>().text = AttackDatabase.attacks.AttackUses[Data.partyData.ActiveChar.Attack03].ToString();
                    description.GetComponent<Text>().text = AttackDatabase.attacks.AttackDesc[Data.partyData.ActiveChar.Attack03];
                    break;
                case 4:
                    powerAcc.GetComponent<Text>().text = AttackDatabase.attacks.AttackPowerAcc[Data.partyData.ActiveChar.Attack04];
                    uses.GetComponent<Text>().text = AttackDatabase.attacks.AttackUses[Data.partyData.ActiveChar.Attack04].ToString();
                    description.GetComponent<Text>().text = AttackDatabase.attacks.AttackDesc[Data.partyData.ActiveChar.Attack04];
                    break;


            }
        }

        //learnedAbilities go here


    }

}
