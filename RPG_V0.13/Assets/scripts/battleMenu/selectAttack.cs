using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectAttack : MonoBehaviour {

    public int AttackNumber;

    private partyManager Party;

	// Use this for initialization
	void Start () {

        var findparty = GameObject.Find("Player_01");
        Party = findparty.GetComponent<partyManager>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChosenAttack()
    {

        switch (AttackNumber)
        {
            case 5:
                Party.AttackSelected( AtkSelected: 5);
                break;
            case 4:
                Party.AttackSelected(AtkSelected: 4);
                break;
            case 3:
                Party.AttackSelected(AtkSelected: 3);
                break;
            case 2:
                Party.AttackSelected(AtkSelected: 2);
                break;
            case 1:
                Party.AttackSelected(AtkSelected: 1);
                break;

        }


        
        
    }

}
