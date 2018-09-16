﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetUI : MonoBehaviour {

    public int Character;
    public enum UiType {name, lvl, type01, type02, portrait, xp, hp, attack01, attack02, attack03, attack04, weaponName, weaponDesc,}
    public UiType UI;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnEnable()
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
                        gameObject.GetComponent<Text>().text ="lvl " + character.xp.ToString() + " / " + character.xpToNextLvl.ToString();
                        break;
                    case UiType.hp:
                        gameObject.GetComponent<Text>().text = "hp " + character.currentHealth.ToString() + " / " + character.maxHealth.ToString();
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
                        gameObject.GetComponent<Text>().text = "lvl " + character.xp.ToString() + " / " + character.xpToNextLvl.ToString();
                        break;
                    case UiType.hp:
                        gameObject.GetComponent<Text>().text = "hp " + character.currentHealth.ToString() + " / " + character.maxHealth.ToString();
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
                        gameObject.GetComponent<Text>().text = "lvl " + character.xp.ToString() + " / " + character.xpToNextLvl.ToString();
                        break;
                    case UiType.hp:
                        gameObject.GetComponent<Text>().text = "hp " + character.currentHealth.ToString() + " / " + character.maxHealth.ToString();
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
                        gameObject.GetComponent<Text>().text = "lvl " + character.xp.ToString() + " / " + character.xpToNextLvl.ToString();
                        break;
                    case UiType.hp:
                        gameObject.GetComponent<Text>().text = "hp " + character.currentHealth.ToString() + " / " + character.maxHealth.ToString();
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
                        gameObject.GetComponent<Text>().text = "lvl " + character.xp.ToString() + " / " + character.xpToNextLvl.ToString();
                        break;
                    case UiType.hp:
                        gameObject.GetComponent<Text>().text = "hp " + character.currentHealth.ToString() + " / " + character.maxHealth.ToString();
                        break;
                }
                break;





        } 
    }

}
