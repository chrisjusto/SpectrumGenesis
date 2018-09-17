using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetUI : MonoBehaviour {

    public bool Player;
    public int Character;
    public enum UiType {name, lvl, type01, type02, portrait, xp, hp, attack01, attack02, attack03, attack04, weaponName, weaponDesc, frontSprite, backSprite}
    public UiType UI;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnEnable()
    {




        if (Player == true)
        {

            switch (Character)
            {
                case 1:
                    var character = Data.partyData.partyMember01;
                    switch (UI)
                    {
                        case UiType.name:
                            gameObject.GetComponent<Text>().text = character.Name;

                            break;
                        case UiType.lvl:
                            gameObject.GetComponent<Text>().text = "lvl " + character.LVL.ToString();
                            break;
                        case UiType.type01:
                            gameObject.GetComponent<Image>().sprite = character.typeSprite01;
                            break;
                        case UiType.type02:
                            gameObject.GetComponent<Image>().sprite = character.typeSprite02;
                            break;
                        case UiType.portrait:
                            gameObject.GetComponent<Image>().sprite = character.portrait;
                            break;
                        case UiType.xp:
                            gameObject.GetComponent<Text>().text = "lvl " + character.xp.ToString() + "/" + character.xpToNextLvl.ToString();
                            break;
                        case UiType.hp:
                            gameObject.GetComponent<Text>().text = "hp " + character.currentHealth.ToString() + "/" + character.maxHealth.ToString();
                            break;
                        case UiType.attack01:
                            gameObject.GetComponent<Text>().text = AttackDatabase.attacks.AttackName[character.Attack01];
                            break;
                        case UiType.attack02:
                            gameObject.GetComponent<Text>().text = AttackDatabase.attacks.AttackName[character.Attack02];
                            break;
                        case UiType.attack03:
                            gameObject.GetComponent<Text>().text = AttackDatabase.attacks.AttackName[character.Attack03];
                            break;
                        case UiType.attack04:
                            gameObject.GetComponent<Text>().text = AttackDatabase.attacks.AttackName[character.Attack04];
                            break;
                        case UiType.frontSprite:
                            gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>(character.frontSprite);
                            break;
                        case UiType.backSprite:
                            gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>(character.backSprite);
                            break;


                    }
                    break;
                case 2:
                    character = Data.partyData.partyMember02;
                    switch (UI)
                    {
                        case UiType.name:
                            gameObject.GetComponent<Text>().text = character.Name;
                            break;
                        case UiType.lvl:
                            gameObject.GetComponent<Text>().text = "lvl " + character.LVL.ToString();
                            break;
                        case UiType.type01:
                            gameObject.GetComponent<Image>().sprite = character.typeSprite01;
                            break;
                        case UiType.type02:
                            gameObject.GetComponent<Image>().sprite = character.typeSprite02;
                            break;
                        case UiType.portrait:
                            gameObject.GetComponent<Image>().sprite = character.portrait;
                            break;
                        case UiType.xp:
                            gameObject.GetComponent<Text>().text = "lvl " + character.xp.ToString() + "/" + character.xpToNextLvl.ToString();
                            break;
                        case UiType.hp:
                            gameObject.GetComponent<Text>().text = "hp " + character.currentHealth.ToString() + "/" + character.maxHealth.ToString();
                            break;
                        case UiType.attack01:
                            gameObject.GetComponent<Text>().text = AttackDatabase.attacks.AttackName[character.Attack01];
                            break;
                        case UiType.attack02:
                            gameObject.GetComponent<Text>().text = AttackDatabase.attacks.AttackName[character.Attack02];
                            break;
                        case UiType.attack03:
                            gameObject.GetComponent<Text>().text = AttackDatabase.attacks.AttackName[character.Attack03];
                            break;
                        case UiType.attack04:
                            gameObject.GetComponent<Text>().text = AttackDatabase.attacks.AttackName[character.Attack04];
                            break;
                        case UiType.frontSprite:
                            gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>(character.frontSprite);
                            break;
                        case UiType.backSprite:
                            gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>(character.backSprite);
                            break;
                    }
                    break;
                case 3:
                    character = Data.partyData.partyMember03;
                    switch (UI)
                    {
                        case UiType.name:
                            gameObject.GetComponent<Text>().text = character.Name;
                            break;
                        case UiType.lvl:
                            gameObject.GetComponent<Text>().text = "lvl " + character.LVL.ToString();
                            break;
                        case UiType.type01:
                            gameObject.GetComponent<Image>().sprite = character.typeSprite01;
                            break;
                        case UiType.type02:
                            gameObject.GetComponent<Image>().sprite = character.typeSprite02;
                            break;
                        case UiType.portrait:
                            gameObject.GetComponent<Image>().sprite = character.portrait;
                            break;
                        case UiType.xp:
                            gameObject.GetComponent<Text>().text = "lvl " + character.xp.ToString() + "/" + character.xpToNextLvl.ToString();
                            break;
                        case UiType.hp:
                            gameObject.GetComponent<Text>().text = "hp " + character.currentHealth.ToString() + "/" + character.maxHealth.ToString();
                            break;
                        case UiType.attack01:
                            gameObject.GetComponent<Text>().text = AttackDatabase.attacks.AttackName[character.Attack01];
                            break;
                        case UiType.attack02:
                            gameObject.GetComponent<Text>().text = AttackDatabase.attacks.AttackName[character.Attack02];
                            break;
                        case UiType.attack03:
                            gameObject.GetComponent<Text>().text = AttackDatabase.attacks.AttackName[character.Attack03];
                            break;
                        case UiType.attack04:
                            gameObject.GetComponent<Text>().text = AttackDatabase.attacks.AttackName[character.Attack04];
                            break;
                        case UiType.frontSprite:
                            gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>(character.frontSprite);
                            break;
                        case UiType.backSprite:
                            gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>(character.backSprite);
                            break;
                    }
                    break;
                case 4:
                    character = Data.partyData.partyMember04;
                    switch (UI)
                    {
                        case UiType.name:
                            gameObject.GetComponent<Text>().text = character.Name;
                            break;
                        case UiType.lvl:
                            gameObject.GetComponent<Text>().text = "lvl " + character.LVL.ToString();
                            break;
                        case UiType.type01:
                            gameObject.GetComponent<Image>().sprite = character.typeSprite01;
                            break;
                        case UiType.type02:
                            gameObject.GetComponent<Image>().sprite = character.typeSprite02;
                            break;
                        case UiType.portrait:
                            gameObject.GetComponent<Image>().sprite = character.portrait;
                            break;
                        case UiType.xp:
                            gameObject.GetComponent<Text>().text = "lvl " + character.xp.ToString() + "/" + character.xpToNextLvl.ToString();
                            break;
                        case UiType.hp:
                            gameObject.GetComponent<Text>().text = "hp " + character.currentHealth.ToString() + "/" + character.maxHealth.ToString();
                            break;
                        case UiType.attack01:
                            gameObject.GetComponent<Text>().text = AttackDatabase.attacks.AttackName[character.Attack01];
                            break;
                        case UiType.attack02:
                            gameObject.GetComponent<Text>().text = AttackDatabase.attacks.AttackName[character.Attack02];
                            break;
                        case UiType.attack03:
                            gameObject.GetComponent<Text>().text = AttackDatabase.attacks.AttackName[character.Attack03];
                            break;
                        case UiType.attack04:
                            gameObject.GetComponent<Text>().text = AttackDatabase.attacks.AttackName[character.Attack04];
                            break;
                        case UiType.frontSprite:
                            gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>(character.frontSprite);
                            break;
                        case UiType.backSprite:
                            gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>(character.backSprite);
                            break;
                    }
                    break;
                case 0:
                    character = Data.partyData.ActiveChar;
                    switch (UI)
                    {
                        case UiType.name:
                            gameObject.GetComponent<Text>().text = character.Name;
                            break;
                        case UiType.lvl:
                            gameObject.GetComponent<Text>().text = "lvl " + character.LVL.ToString();
                            break;
                        case UiType.type01:
                            gameObject.GetComponent<Image>().sprite = character.typeSprite01;
                            break;
                        case UiType.type02:
                            gameObject.GetComponent<Image>().sprite = character.typeSprite02;
                            break;
                        case UiType.portrait:
                            gameObject.GetComponent<Image>().sprite = character.portrait;
                            break;
                        case UiType.xp:
                            gameObject.GetComponent<Text>().text = "lvl " + character.xp.ToString() + "/" + character.xpToNextLvl.ToString();
                            break;
                        case UiType.hp:
                            gameObject.GetComponent<Text>().text = "hp " + character.currentHealth.ToString() + "/" + character.maxHealth.ToString();
                            break;
                        case UiType.attack01:
                            gameObject.GetComponent<Text>().text = AttackDatabase.attacks.AttackName[character.Attack01];
                            break;
                        case UiType.attack02:
                            gameObject.GetComponent<Text>().text = AttackDatabase.attacks.AttackName[character.Attack02];
                            break;
                        case UiType.attack03:
                            gameObject.GetComponent<Text>().text = AttackDatabase.attacks.AttackName[character.Attack03];
                            break;
                        case UiType.attack04:
                            gameObject.GetComponent<Text>().text = AttackDatabase.attacks.AttackName[character.Attack04];
                            break;
                        case UiType.frontSprite:
                            gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>(character.frontSprite);
                            break;
                        case UiType.backSprite:
                            gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>(character.backSprite);
                            break;

                    }
                    break;


            }



        }
        else if (Player == false)
        {
            var character = Data.partyData.ActiveEnemy;
            switch (UI)
            {

                case UiType.name:
                    gameObject.GetComponent<Text>().text = character.Name;
                    break;
                case UiType.lvl:
                    gameObject.GetComponent<Text>().text = "lvl " + character.LVL.ToString();
                    break;
                case UiType.type01:
                    gameObject.GetComponent<Image>().sprite = character.typeSprite01;
                    break;
                case UiType.type02:
                    gameObject.GetComponent<Image>().sprite = character.typeSprite02;
                    break;
                case UiType.portrait:
                    gameObject.GetComponent<Image>().sprite = character.portrait;
                    break;
                case UiType.xp:
                    gameObject.GetComponent<Text>().text = "lvl " + character.xp.ToString() + "/" + character.xpToNextLvl.ToString();
                    break;
                case UiType.hp:
                    gameObject.GetComponent<Text>().text = "hp " + character.currentHealth.ToString() + "/" + character.maxHealth.ToString();
                    break;
                case UiType.attack01:
                    gameObject.GetComponent<Text>().text = AttackDatabase.attacks.AttackName[character.Attack01];
                    Debug.Log(AttackDatabase.attacks.AttackName[character.Attack01]);
                    break;
                case UiType.attack02:
                    gameObject.GetComponent<Text>().text = AttackDatabase.attacks.AttackName[character.Attack02];
                    break;
                case UiType.attack03:
                    gameObject.GetComponent<Text>().text = AttackDatabase.attacks.AttackName[character.Attack03];
                    break;
                case UiType.attack04:
                    gameObject.GetComponent<Text>().text = AttackDatabase.attacks.AttackName[character.Attack04];
                    break;
                case UiType.frontSprite:
                    gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>(character.frontSprite);
                    break;
                case UiType.backSprite:
                    gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>(character.backSprite);
                    break;
            }

        }

    }

}
