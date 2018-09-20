using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CharacterSelectController : MonoBehaviour {
    
    private int Char;
    private int selectionNumber;

    public GameObject Name;
    public GameObject Sprite;
    public GameObject Type01;
    public GameObject Type02;
    public GameObject Level;
    public GameObject WeaponName;
    public GameObject EquipName;
    public GameObject AbilityName;
    public GameObject WeaponDesc;
    public GameObject EquipDesc;
    public GameObject AbilityDesc;
    public GameObject SpellName01;
    public GameObject SpellType01;
    public GameObject SpellName02;
    public GameObject SpellType02;
    public GameObject SpellName03;
    public GameObject SpellType03;
    public GameObject SpellName04;
    public GameObject SpellType04;
    public GameObject hpStat;
    public GameObject atkStat;
    public GameObject defStat;
    public GameObject satkStat;
    public GameObject sdefStat;
    public GameObject spdStat;
    public GameObject partyMember01;
    public GameObject partyMember02;
    public GameObject partyMember03;
    public GameObject partyMember04;
    public GameObject abel;
    public GameObject diana;
    public GameObject lia;
    public GameObject juruh;
    public GameObject kirah;
    public GameObject grimace;
    public GameObject evenese;
    public GameObject rieker;
    public GameObject goToNewScene;
    public int[] characters = new int[4];


    public void SeeInfo()
    {
        
       
        Name.GetComponent<Text>().text = Data.partyData.ActiveChar.Name;

        Type01.GetComponent<Image>().sprite = Data.partyData.ActiveChar.typeSprite01;

        Type02.GetComponent<Image>().sprite = Data.partyData.ActiveChar.typeSprite02;

        Level.GetComponent<Text>().text = ("LV" + Data.partyData.ActiveChar.LVL.ToString());

        hpStat.GetComponent<Text>().text = (Data.partyData.ActiveChar.HP * 2).ToString();

        atkStat.GetComponent<Text>().text = Data.partyData.ActiveChar.ATK.ToString();

        defStat.GetComponent<Text>().text = Data.partyData.ActiveChar.DEF.ToString();

        satkStat.GetComponent<Text>().text = Data.partyData.ActiveChar.sATK.ToString();

        sdefStat.GetComponent<Text>().text = Data.partyData.ActiveChar.sDEF.ToString();

        spdStat.GetComponent<Text>().text = Data.partyData.ActiveChar.SPD.ToString();

        Sprite.GetComponent<Image>().sprite = Resources.Load<Sprite>(Data.partyData.ActiveChar.frontSprite);

        WeaponName.GetComponent<Text>().text = WeaponDataBase.weapons.WeaponName[Data.partyData.ActiveChar.Weapon];

        WeaponDesc.GetComponent<Text>().text = WeaponDataBase.weapons.WeaponDesc[Data.partyData.ActiveChar.Weapon];

        EquipName.GetComponent<Text>().text = ArmorDataBase.Equip.EquipName[Data.partyData.ActiveChar.Equipment];

        EquipDesc.GetComponent<Text>().text = ArmorDataBase.Equip.EquipDesc[Data.partyData.ActiveChar.Equipment];

        AbilityName.GetComponent<Text>().text = AbilityDataBase.Ability.AbilityName[Data.partyData.ActiveChar.ability];

        AbilityDesc.GetComponent<Text>().text = AbilityDataBase.Ability.AbilityDesc[Data.partyData.ActiveChar.ability];

        SpellName01.GetComponent<Text>().text = AttackDatabase.attacks.AttackName[Data.partyData.ActiveChar.Attack01];

        SpellName02.GetComponent<Text>().text = AttackDatabase.attacks.AttackName[Data.partyData.ActiveChar.Attack02];

        SpellName03.GetComponent<Text>().text = AttackDatabase.attacks.AttackName[Data.partyData.ActiveChar.Attack03];

        SpellName04.GetComponent<Text>().text = AttackDatabase.attacks.AttackName[Data.partyData.ActiveChar.Attack04];

        SpellType01.GetComponent<Text>().text = AttackDatabase.attacks.AttackType[Data.partyData.ActiveChar.Attack01];

        SpellType02.GetComponent<Text>().text = AttackDatabase.attacks.AttackType[Data.partyData.ActiveChar.Attack02];

        SpellType03.GetComponent<Text>().text = AttackDatabase.attacks.AttackType[Data.partyData.ActiveChar.Attack03];

        SpellType04.GetComponent<Text>().text = AttackDatabase.attacks.AttackType[Data.partyData.ActiveChar.Attack04];






    }

    //selected Char Logic
    public void SelectCharacter(int SelectedChar)
    {
        Char = SelectedChar;
        selectionNumber = selectionNumber + 1;

        switch (Char)
        {
            case 0:
                Data.partyData.ActiveChar = Data.partyData.gameObject.AddComponent<charAbel>();
                abel.SetActive(false);
                break;
            case 1:
                Data.partyData.ActiveChar = Data.partyData.gameObject.AddComponent<charDiana>();
                diana.SetActive(false);
                
                break;
            case 2:
                Data.partyData.ActiveChar = Data.partyData.gameObject.AddComponent<charLia>();
                lia.SetActive(false);
                break;
            case 3:
                Data.partyData.ActiveChar = Data.partyData.gameObject.AddComponent<charJuruh>();
                juruh.SetActive(false);
                break;
            case 4:
                Data.partyData.ActiveChar = Data.partyData.gameObject.AddComponent<charKirah>();
                kirah.SetActive(false);
                break;
            case 5:
                Data.partyData.ActiveChar = Data.partyData.gameObject.AddComponent<charGrimace>();
                grimace.SetActive(false);
                break;
            case 6:
                Data.partyData.ActiveChar = Data.partyData.gameObject.AddComponent<charEvenese>();
                evenese.SetActive(false);
                break;
            case 7:
                Data.partyData.ActiveChar = Data.partyData.gameObject.AddComponent<charRieker>();
                rieker.SetActive(false);
                break;
        }
        SeeInfo();


    }



    //set info on screen

    public void AddParty()
    {
        switch (selectionNumber)
        {
            case 1:
                Data.partyData.partyMember01 = Data.partyData.ActiveChar;
                partyMember01.GetComponent<Image>().sprite = Data.partyData.ActiveChar.portrait;                
                Data.partyData.ActiveChar = null;

                break;
            case 2:
                Data.partyData.partyMember02 = Data.partyData.ActiveChar;
                partyMember02.GetComponent<Image>().sprite = Data.partyData.ActiveChar.portrait;                
                Data.partyData.ActiveChar = null;

                break;
            case 3:
                Data.partyData.partyMember03 = Data.partyData.ActiveChar;
                partyMember03.GetComponent<Image>().sprite = Data.partyData.ActiveChar.portrait;                
                Data.partyData.ActiveChar = null;

                break;
            case 4:
                Data.partyData.partyMember04 = Data.partyData.ActiveChar;
                partyMember04.GetComponent<Image>().sprite = Data.partyData.ActiveChar.portrait;
                Data.partyData.ActiveChar = null;
                NewUI();
                break;
        }
        

    }

    public void NewUI()
    {

        goToNewScene.SetActive(true);

    }

    public void CallNewScene()
    {

        Data.partyData.EnemyParty01 = Data.partyData.gameObject.AddComponent<charGrimace>();
        Data.partyData.EnemyParty02 = Data.partyData.gameObject.AddComponent<charEvenese>();
        Data.partyData.EnemyParty03 = Data.partyData.gameObject.AddComponent<charRieker>();
        Data.partyData.EnemyParty04 = Data.partyData.gameObject.AddComponent<charKirah>();

        SceneManager.LoadScene(1);



    }


    public void ReSelect()
    {
        selectionNumber = selectionNumber - 1;
        Destroy(Data.partyData.ActiveChar);
        switch (Char)
        {
            case 0:
                abel.SetActive(true);
                break;
            case 1:                
                diana.SetActive(true);
                break;
            case 2:                
                lia.SetActive(true);
                break;
            case 3:               
                juruh.SetActive(true);
                break;
            case 4:                
                kirah.SetActive(true);
                break;
            case 5:               
                grimace.SetActive(true);
                break;
            case 6:               
                evenese.SetActive(true);
                break;
            case 7:               
                rieker.SetActive(true);
                break;
        }
       
    }


    

}

