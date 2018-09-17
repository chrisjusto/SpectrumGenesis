using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetBattleToolTip : MonoBehaviour {



    public GameObject powerAcc;
    public GameObject uses;
    public GameObject Description;
    public GameObject Name;
    public GameObject Type;
    public GameObject uses02;




	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Enabled(bool isWeapon, int HoveredAttack)
    {

        powerAcc.SetActive(true);
        uses.SetActive(true);
        Description.SetActive(true);
        Name.SetActive(true);
        Type.SetActive(true);
        uses02.SetActive(true);

        var character = Data.partyData.ActiveChar;

        if (isWeapon == true)
        {
            powerAcc.SetActive(false);
            uses.SetActive(false);
            uses02.SetActive(false);
            Type.SetActive(false);

            Name.GetComponent<Text>().text = WeaponDataBase.weapons.WeaponName[character.Weapon];
            Description.GetComponent<Text>().text = WeaponDataBase.weapons.WeaponDesc[character.Weapon];


        }
        else if (isWeapon == false)
        {
            switch (HoveredAttack)
            {
                case 1:
                    Name.GetComponent<Text>().text = AttackDatabase.attacks.AttackName[character.Attack01];
                    powerAcc.GetComponent<Text>().text = AttackDatabase.attacks.AttackPowerAcc[character.Attack01];
                    uses.GetComponent<Text>().text = character.attackUses[0].ToString();
                    Description.GetComponent<Text>().text = AttackDatabase.attacks.AttackDesc[character.Attack01];
                    Type.GetComponent<Text>().text = AttackDatabase.attacks.AttackType[character.Attack01];

                    break;
                case 2:
                    Name.GetComponent<Text>().text = AttackDatabase.attacks.AttackName[character.Attack02];
                    powerAcc.GetComponent<Text>().text = AttackDatabase.attacks.AttackPowerAcc[character.Attack02];
                    uses.GetComponent<Text>().text = character.attackUses[1].ToString();
                    Description.GetComponent<Text>().text = AttackDatabase.attacks.AttackDesc[character.Attack02];
                    Type.GetComponent<Text>().text = AttackDatabase.attacks.AttackType[character.Attack02];
                    break;
                case 3:
                    Name.GetComponent<Text>().text = AttackDatabase.attacks.AttackName[character.Attack03];
                    powerAcc.GetComponent<Text>().text = AttackDatabase.attacks.AttackPowerAcc[character.Attack03];
                    uses.GetComponent<Text>().text = character.attackUses[2].ToString();
                    Description.GetComponent<Text>().text = AttackDatabase.attacks.AttackDesc[character.Attack03];
                    Type.GetComponent<Text>().text = AttackDatabase.attacks.AttackType[character.Attack03];
                    break;
                case 4:
                    Name.GetComponent<Text>().text = AttackDatabase.attacks.AttackName[character.Attack04];
                    powerAcc.GetComponent<Text>().text = AttackDatabase.attacks.AttackPowerAcc[character.Attack04];
                    uses.GetComponent<Text>().text = character.attackUses[3].ToString();
                    Description.GetComponent<Text>().text = AttackDatabase.attacks.AttackDesc[character.Attack04];
                    Type.GetComponent<Text>().text = AttackDatabase.attacks.AttackType[character.Attack04];
                    break;
            }
        }

         





    }
}
