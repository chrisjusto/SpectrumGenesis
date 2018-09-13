using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class partyManager : MonoBehaviour {

    public bool SwitchInt;
    public charClass partyMemberOne;
    public charClass partyMemberTwo;
    public charClass activeChar;
    public partyManager enemyRef;
    public resaultsButton resaults;
    public GameObject findAnim;
    public GameObject enemyMagic;
    public GameObject playerMagic;
    public GameObject playerSlash;

    public bool partyMemberDead01;
    public bool partyMemberDead02;

    public bool attachedtoEnemy;

    public GameObject Player;

    public Image hpGauge;

    public Text hpNumbers;

    public Text characterName;

    public float Stab;

    public bool hasAttacked;
    public int attackSelected;
    public float crit;
    public float damage;

    public setAttack01Text attackSwitch01;


    void Awake()
    {

        //find UI

        if (attachedtoEnemy == true)
        {
            var healthUI = GameObject.Find("enemyHealth");

            hpGauge = healthUI.GetComponent<Image>();

            var hpUI = GameObject.Find("enemy_hpNumbers");

            hpNumbers = hpUI.GetComponent<Text>();

            var charUI = GameObject.Find("enemyName");

            characterName = charUI.GetComponent<Text>();

            var findEnemy = GameObject.Find("Player_01");
            enemyRef = findEnemy.GetComponent<partyManager>();

            partyMemberOne = gameObject.AddComponent<CharHooded>();

            partyMemberTwo = gameObject.AddComponent<CharMysterio>();

            partyMemberOne.ActivatePlayer(Active: false);

            partyMemberTwo.ActivatePlayer(Active: true);

            activeChar = partyMemberOne;

        }
        else
        {
            var healthUI = GameObject.Find("health");

            hpGauge = healthUI.GetComponent<Image>();

            var hpUI = GameObject.Find("hpNumbers");

            hpNumbers = hpUI.GetComponent<Text>();

            var charUI = GameObject.Find("playerName");

            characterName = charUI.GetComponent<Text>();

            partyMemberOne = gameObject.AddComponent<CharRuby>();


            partyMemberTwo = gameObject.AddComponent<CharFlow>();

            

            var findEnemy = GameObject.Find("enemy_01");
            enemyRef = findEnemy.GetComponent<partyManager>();

            partyMemberOne.GetComponent<CharRuby>().ActivatePlayer(Active: false);

            partyMemberTwo.GetComponent<CharFlow>().ActivatePlayer(Active: true);

            activeChar = partyMemberOne;
        }


        //findPlayers

       








       

    }

    // Use this for initialization
    void Start () {

    


	}
	
	// Update is called once per frame
	void Update () {

        if (partyMemberOne.isActive == true)
        {
            hpGauge.fillAmount = ((partyMemberOne.currentHealth)/(partyMemberOne.maxHealth));
            hpNumbers.text = ((partyMemberOne.currentHealth.ToString()) + "/" + (partyMemberOne.maxHealth.ToString()));
            characterName.text = partyMemberOne.Name;

        }
        else
        {

            hpGauge.fillAmount = ((partyMemberTwo.currentHealth) / (partyMemberTwo.maxHealth));
            hpNumbers.text = ((partyMemberTwo.currentHealth.ToString()) + "/" + (partyMemberTwo.maxHealth.ToString()));
            characterName.text = partyMemberTwo.Name;

        }


        if (activeChar.currentHealth <= 0)
        {
            activeChar.currentHealth = 0;
        }
        if (attachedtoEnemy == true)   
        {
            if (partyMemberOne.dead == true & partyMemberTwo.dead == true)
            {
                SceneManager.LoadScene(2);
            }
        }
        else
        {
            if (partyMemberOne.dead == true & partyMemberTwo.dead == true)
            {
                SceneManager.LoadScene(3);
            }
        }

        if (attachedtoEnemy == true)
        {

        }
        else
        {
            
            var attack01 = GameObject.Find("attackText01");
            var attack02 = GameObject.Find("attackText02");
            var attack03 = GameObject.Find("attackText03");
            var attack04 = GameObject.Find("attackText04");
            var attack05 = GameObject.Find("attackText05");

            attackSwitch01 = (setAttack01Text)attack01.GetComponent("setAttack01Text");

            attackSwitch01.GetComponent<setAttack01Text>().SwitchUI();

            attackSwitch01 = (setAttack01Text)attack02.GetComponent("setAttack01Text");

            attackSwitch01.GetComponent<setAttack01Text>().SwitchUI();

            attackSwitch01 = (setAttack01Text)attack03.GetComponent("setAttack01Text");

            attackSwitch01.GetComponent<setAttack01Text>().SwitchUI();

            attackSwitch01 = (setAttack01Text)attack04.GetComponent("setAttack01Text");

            attackSwitch01.GetComponent<setAttack01Text>().SwitchUI();

            attackSwitch01 = (setAttack01Text)attack05.GetComponent("setAttack01Text");

            attackSwitch01.GetComponent<setAttack01Text>().SwitchUI();
        }

    }


    public void EndTurn()
    {
        if (activeChar.currentHealth <= 0)
        {
            activeChar.dead = true;

            if (activeChar == partyMemberOne)
            {
                partyMemberOne.ActivatePlayer(Active: true);

                partyMemberTwo.ActivatePlayer(Active: false);

                activeChar = partyMemberTwo;
            }
            else
            {
                partyMemberTwo.ActivatePlayer(Active: true);

                partyMemberOne.ActivatePlayer(Active: false);

                activeChar = partyMemberOne;
            }

        }




    }


  public void ActivateSwitch(bool Switch)
    {

        if (Switch == false)
        {
            if (partyMemberTwo.dead == true)
            {

            }
            else
            {


                partyMemberOne.ActivatePlayer(Active: true);

                partyMemberTwo.ActivatePlayer(Active: false);

                activeChar = partyMemberTwo;
            }
           

        }
        else
        {
            if (partyMemberOne.dead == true)
            {

            }
            else
            {
                partyMemberTwo.ActivatePlayer(Active: true);

                partyMemberOne.ActivatePlayer(Active: false);

                activeChar = partyMemberOne;
            }
        }
    }

    public void AttackSelected(int AtkSelected)
    {

        attackSelected = AtkSelected;

        if (activeChar.SPD > enemyRef.activeChar.SPD)
        {
            PlayerAttack();
            
        }
        else
        {
            enemyRef.PlayerAttack();
        }
    }

    public void PlayerAttack()
    {

        hasAttacked = true;

        if (attachedtoEnemy == true)
        {
            attackSelected = Random.Range(1, 6);
        }

        switch (attackSelected)
        {
            case 1:
                if (activeChar.target01 == true)
                {
                    

                    if ((Random.Range(1, 101)) < (activeChar.acc01)) 
                    {
                        if (activeChar.atkType01 == 0)
                        {
                            if (activeChar.atkType01 == activeChar.myType)
                            {
                                Stab = (1.50f);
                            }
                            else
                            {
                                Stab = (1);
                            }
                            if (Random.Range(1, 101) > 90)
                            {
                                crit = 2;
                            }
                            else
                            {
                                crit = 1;
                            }
                            if (activeChar.dmgType01 == 0)
                            {
                                damage = (((activeChar.LVL + activeChar.dmg01) * 2) * (activeChar.ATK / enemyRef.activeChar.DEF)) / 3;
                            }
                            else
                            {
                                damage = (((activeChar.LVL + activeChar.dmg01) * 2) * (activeChar.sATK / enemyRef.activeChar.sDEF)) / 3;
                            }
                            var finalDamage = damage * Stab * crit;
                            finalDamage = Mathf.Round(finalDamage);
                            enemyRef.activeChar.currentHealth = enemyRef.activeChar.currentHealth - finalDamage;                     
                            var findResults = GameObject.Find("resultsButton");
                            resaults = findResults.GetComponent<resaultsButton>();
                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackOneName, damage: finalDamage, sucssess: true, atkType:
                                activeChar.atkType01, buff: activeChar.buff01, dmgType: activeChar.dmgType01);

                            var Animation = findAnim.GetComponent<Animator>();                        
                            Animation.SetTrigger("123");
                        }
                        else
                        {
                            if (activeChar.atkType01 == 1)
                            {
                                switch (activeChar.dmgType01)
                                {
                                    case 0:
                                        if (activeChar.buff01 == true)
                                        {
                                            activeChar.ATK = activeChar.ATK + activeChar.dmg01;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackOneName, damage: activeChar.dmg01, sucssess: true, atkType:
                                activeChar.atkType01, buff: activeChar.buff01, dmgType: activeChar.dmgType01);
                                        }
                                        else
                                        {
                                            enemyRef.activeChar.ATK = enemyRef.activeChar.ATK - activeChar.dmg01;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackOneName, damage: activeChar.dmg01, sucssess: true, atkType:
                                activeChar.atkType01, buff: activeChar.buff01, dmgType: activeChar.dmgType01);
                                        }
                                        break;
                                    case 1:
                                        if (activeChar.buff01 == true)
                                        {
                                            activeChar.DEF = activeChar.DEF + activeChar.dmg01;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackOneName, damage: activeChar.dmg01, sucssess: true, atkType:
                                activeChar.atkType01, buff: activeChar.buff01, dmgType: activeChar.dmgType01);
                                        }
                                        else
                                        {
                                            enemyRef.activeChar.DEF = enemyRef.activeChar.DEF - activeChar.dmg01;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackOneName, damage: activeChar.dmg01, sucssess: true, atkType:
                                activeChar.atkType01, buff: activeChar.buff01, dmgType: activeChar.dmgType01);
                                        }
                                            break;
                                    case 2:
                                        if (activeChar.buff01 == true)
                                        {
                                            activeChar.sATK = activeChar.sATK + activeChar.dmg01;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackOneName, damage: activeChar.dmg01, sucssess: true, atkType:
                                activeChar.atkType01, buff: activeChar.buff01, dmgType: activeChar.dmgType01);
                                        }
                                        else
                                        {
                                            enemyRef.activeChar.sATK = enemyRef.activeChar.sATK - activeChar.dmg01;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackOneName, damage: activeChar.dmg01, sucssess: true, atkType:
                                activeChar.atkType01, buff: activeChar.buff01, dmgType: activeChar.dmgType01);
                                        }
                                        break;
                                    case 3:
                                        if (activeChar.buff01 == true)
                                        {
                                            activeChar.sDEF = activeChar.sDEF + activeChar.dmg01;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackOneName, damage: activeChar.dmg01, sucssess: true, atkType:
                                activeChar.atkType01, buff: activeChar.buff01, dmgType: activeChar.dmgType01);
                                        }
                                        else
                                        {
                                            enemyRef.activeChar.sDEF = enemyRef.activeChar.sDEF - activeChar.dmg01;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackOneName, damage: activeChar.dmg01, sucssess: true, atkType:
                                activeChar.atkType01, buff: activeChar.buff01, dmgType: activeChar.dmgType01);
                                        }
                                        break;
                                    case 4:
                                        if (activeChar.buff01 == true)
                                        {
                                            activeChar.SPD = activeChar.SPD + activeChar.dmg01;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackOneName, damage: activeChar.dmg01, sucssess: true, atkType:
                                activeChar.atkType01, buff: activeChar.buff01, dmgType: activeChar.dmgType01);
                                        }
                                        else
                                        {
                                            enemyRef.activeChar.SPD = enemyRef.activeChar.SPD - activeChar.dmg01;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackOneName, damage: activeChar.dmg01, sucssess: true, atkType:
                                activeChar.atkType01, buff: activeChar.buff01, dmgType: activeChar.dmgType01);
                                        }
                                        break;

                                }
                                
                            }
                            else
                            {
                                activeChar.currentHealth = activeChar.currentHealth + activeChar.dmg01;
                                if (activeChar.currentHealth > activeChar.maxHealth)
                                {
                                    activeChar.currentHealth = activeChar.maxHealth;
                                }
                                var findResults = GameObject.Find("resultsButton");
                                resaults = findResults.GetComponent<resaultsButton>();
                                resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackOneName, damage: activeChar.dmg01, sucssess: true, atkType:
                    activeChar.atkType01, buff: activeChar.buff01, dmgType: activeChar.dmgType01);
                            }

                            if (activeChar.buff01 == true)
                            {
                                var Animation = playerMagic.GetComponent<Animator>();
                                Animation.SetTrigger("magicTrigger");
                            }
                            else
                            {
                                var Animation = enemyMagic.GetComponent<Animator>();
                                Animation.SetTrigger("magicTrigger");
                            }

                        }                       
                    }
                    else
                    {
                        var findResults = GameObject.Find("resultsButton");
                        resaults = findResults.GetComponent<resaultsButton>();

                        resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackOneName, damage: 0, sucssess: false, atkType:
                                activeChar.atkType01, buff: activeChar.buff01, dmgType: activeChar.dmgType01);
                    }
                }
                break;
            case 2:
                if (activeChar.target02 == true)
                {


                    if ((Random.Range(1, 100)) < (activeChar.acc02))
                    {
                        if (activeChar.atkType02 == 0)
                        {
                            if (activeChar.atkType02 == activeChar.myType)
                            {
                                Stab = (1.50f);
                            }
                            else
                            {
                                Stab = (1);
                            }
                            if (Random.Range(1, 101) > 90)
                            {
                                crit = 2;
                            }
                            else
                            {
                                crit = 1;
                            }
                            if (activeChar.dmgType02 == 0)
                            {
                                damage = (((activeChar.LVL + activeChar.dmg02) * 2) * (activeChar.ATK / enemyRef.activeChar.DEF)) / 3;
                            }
                            else
                            {
                                damage = (((activeChar.LVL + activeChar.dmg02) * 2) * (activeChar.sATK / enemyRef.activeChar.sDEF)) / 3;
                            }
                            var finalDamage = damage * Stab * crit;
                            finalDamage = Mathf.Round(finalDamage);
                            enemyRef.activeChar.currentHealth = enemyRef.activeChar.currentHealth - finalDamage;
                            var findResults = GameObject.Find("resultsButton");
                            resaults = findResults.GetComponent<resaultsButton>();
                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackTwoName, damage: finalDamage, sucssess: true, atkType:
                                activeChar.atkType02, buff: activeChar.buff02, dmgType: activeChar.dmgType02);
                            var Animation = findAnim.GetComponent<Animator>();
                            Animation.SetTrigger("123");
                        }
                        else
                        {
                            if (activeChar.atkType02 == 1)
                            {
                                switch (activeChar.dmgType02)
                                {
                                    case 0:
                                        if (activeChar.buff02 == true)
                                        {
                                            activeChar.ATK = activeChar.ATK + activeChar.dmg02;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackTwoName, damage: activeChar.dmg02, sucssess: true, atkType:
                                activeChar.atkType02, buff: activeChar.buff02, dmgType: activeChar.dmgType02);
                                        }
                                        else
                                        {
                                            enemyRef.activeChar.ATK = enemyRef.activeChar.ATK - activeChar.dmg02;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackTwoName, damage: activeChar.dmg02, sucssess: true, atkType:
                                activeChar.atkType02, buff: activeChar.buff02, dmgType: activeChar.dmgType02);
                                        }
                                        break;
                                    case 1:
                                        if (activeChar.buff02 == true)
                                        {
                                            activeChar.DEF = activeChar.DEF + activeChar.dmg02;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackTwoName, damage: activeChar.dmg02, sucssess: true, atkType:
                                 activeChar.atkType02, buff: activeChar.buff02, dmgType: activeChar.dmgType02);
                                        }
                                        else
                                        {
                                            enemyRef.activeChar.DEF = enemyRef.activeChar.DEF - activeChar.dmg02;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackTwoName, damage: activeChar.dmg02, sucssess: true, atkType:
                                 activeChar.atkType02, buff: activeChar.buff02, dmgType: activeChar.dmgType02);
                                        }
                                        break;
                                    case 2:
                                        if (activeChar.buff02 == true)
                                        {
                                            activeChar.sATK = activeChar.sATK + activeChar.dmg02;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackTwoName, damage: activeChar.dmg02, sucssess: true, atkType:
                                activeChar.atkType02, buff: activeChar.buff02, dmgType: activeChar.dmgType02);
                                        }
                                        else
                                        {
                                            enemyRef.activeChar.sATK = enemyRef.activeChar.sATK - activeChar.dmg02;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackTwoName, damage: activeChar.dmg02, sucssess: true, atkType:
                                activeChar.atkType02, buff: activeChar.buff02, dmgType: activeChar.dmgType02);
                                        }
                                        break;
                                    case 3:
                                        if (activeChar.buff02 == true)
                                        {
                                            activeChar.sDEF = activeChar.sDEF + activeChar.dmg02;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackTwoName, damage: activeChar.dmg02, sucssess: true, atkType:
                                activeChar.atkType02, buff: activeChar.buff02, dmgType: activeChar.dmgType02);
                                        }
                                        else
                                        {
                                            enemyRef.activeChar.sDEF = enemyRef.activeChar.sDEF - activeChar.dmg02;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackTwoName, damage: activeChar.dmg02, sucssess: true, atkType:
                                activeChar.atkType02, buff: activeChar.buff02, dmgType: activeChar.dmgType02);
                                        }
                                        break;
                                    case 4:
                                        if (activeChar.buff02 == true)
                                        {
                                            activeChar.SPD = activeChar.SPD + activeChar.dmg02;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackTwoName, damage: activeChar.dmg02, sucssess: true, atkType:
                                activeChar.atkType02, buff: activeChar.buff02, dmgType: activeChar.dmgType02);
                                        }
                                        else
                                        {
                                            enemyRef.activeChar.SPD = enemyRef.activeChar.SPD - activeChar.dmg02;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackTwoName, damage: activeChar.dmg02, sucssess: true, atkType:
                                activeChar.atkType02, buff: activeChar.buff02, dmgType: activeChar.dmgType02);
                                        }
                                        break;

                                }
                            }
                            else
                            {
                                activeChar.currentHealth = activeChar.currentHealth + activeChar.dmg02;
                                if (activeChar.currentHealth > activeChar.maxHealth)
                                {
                                    activeChar.currentHealth = activeChar.maxHealth;
                                }
                                var findResults = GameObject.Find("resultsButton");
                                resaults = findResults.GetComponent<resaultsButton>();
                                resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackTwoName, damage: activeChar.dmg02, sucssess: true, atkType:
                            activeChar.atkType02, buff: activeChar.buff02, dmgType: activeChar.dmgType02);
                            }

                            if (activeChar.buff02 == true)
                            {
                                var Animation = playerMagic.GetComponent<Animator>();
                                Animation.SetTrigger("magicTrigger");
                            }
                            else
                            {
                                var Animation = enemyMagic.GetComponent<Animator>();
                                Animation.SetTrigger("magicTrigger");
                            }

                        }
                    }
                    else
                    {
                        var findResults = GameObject.Find("resultsButton");
                        resaults = findResults.GetComponent<resaultsButton>();

                        resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackTwoName, damage: 0, sucssess: false, atkType:
                                activeChar.atkType02, buff: activeChar.buff02, dmgType: activeChar.dmgType02);
                    }
                }
                break;
            case 3:
                if (activeChar.target03 == true)
                {


                    if ((Random.Range(1, 100)) < (activeChar.acc03))
                    {
                        if (activeChar.atkType03 == 0)
                        {
                            if (activeChar.atkType03 == activeChar.myType)
                            {
                                Stab = (1.50f);
                            }
                            else
                            {
                                Stab = (1);
                            }
                            if (Random.Range(1, 101) > 90)
                            {
                                crit = 2;
                            }
                            else
                            {
                                crit = 1;
                            }
                            if (activeChar.dmgType03 == 0)
                            {
                                damage = (((activeChar.LVL + activeChar.dmg03) * 2) * (activeChar.ATK / enemyRef.activeChar.DEF)) / 3;
                            }
                            else
                            {
                                damage = (((activeChar.LVL + activeChar.dmg03) * 2) * (activeChar.sATK / enemyRef.activeChar.sDEF)) / 3;
                            }
                            var finalDamage = damage * Stab * crit;
                            finalDamage = Mathf.Round(finalDamage);
                            enemyRef.activeChar.currentHealth = enemyRef.activeChar.currentHealth - finalDamage;
                            var findResults = GameObject.Find("resultsButton");
                            resaults = findResults.GetComponent<resaultsButton>();
                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackThreeName, damage: finalDamage, sucssess: true, atkType:
                                activeChar.atkType03, buff: activeChar.buff03, dmgType: activeChar.dmgType03);
                            var Animation = findAnim.GetComponent<Animator>();
                            Animation.SetTrigger("123");
                        }
                        else
                        {
                            Debug.Log("else");

                            if (activeChar.atkType03 == 1)
                            {
                                Debug.Log("status");
                                switch (activeChar.dmgType03)
                                {
                                    case 0:
                                        if (activeChar.buff03 == true)
                                        {
                                            activeChar.ATK = activeChar.ATK + activeChar.dmg03;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackThreeName, damage: activeChar.dmg03, sucssess: true, atkType:
                                activeChar.atkType03, buff: activeChar.buff03, dmgType: activeChar.dmgType03);
                                        }
                                        else
                                        {
                                            enemyRef.activeChar.ATK = enemyRef.activeChar.ATK - activeChar.dmg03;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackThreeName, damage: activeChar.dmg03, sucssess: true, atkType:
                                activeChar.atkType03, buff: activeChar.buff03, dmgType: activeChar.dmgType03);
                                        }
                                        break;
                                    case 1:
                                        if (activeChar.buff03 == true)
                                        {
                                            activeChar.DEF = activeChar.DEF + activeChar.dmg03;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackThreeName, damage: activeChar.dmg03, sucssess: true, atkType:
                                 activeChar.atkType03, buff: activeChar.buff03, dmgType: activeChar.dmgType03);
                                        }
                                        else
                                        {
                                            enemyRef.activeChar.DEF = enemyRef.activeChar.DEF - activeChar.dmg03;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackThreeName, damage: activeChar.dmg03, sucssess: true, atkType:
                                activeChar.atkType03, buff: activeChar.buff03, dmgType: activeChar.dmgType03);
                                        }
                                        break;
                                    case 2:
                                        if (activeChar.buff03 == true)
                                        {
                                            Debug.Log("meditrate");
                                            activeChar.sATK = activeChar.sATK + activeChar.dmg03;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackThreeName, damage: activeChar.dmg03, sucssess: true, atkType:
                                activeChar.atkType03, buff: activeChar.buff03, dmgType: activeChar.dmgType03);
                                        }
                                        else
                                        {
                                            enemyRef.activeChar.sATK = enemyRef.activeChar.sATK - activeChar.dmg03;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackThreeName, damage: activeChar.dmg03, sucssess: true, atkType:
                                activeChar.atkType03, buff: activeChar.buff03, dmgType: activeChar.dmgType03);
                                        }
                                        break;
                                    case 3:
                                        if (activeChar.buff03 == true)
                                        {
                                            activeChar.sDEF = activeChar.sDEF + activeChar.dmg03;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackThreeName, damage: activeChar.dmg03, sucssess: true, atkType:
                                activeChar.atkType03, buff: activeChar.buff03, dmgType: activeChar.dmgType03);
                                        }
                                        else
                                        {
                                            enemyRef.activeChar.sDEF = enemyRef.activeChar.sDEF - activeChar.dmg03;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackThreeName, damage: activeChar.dmg03, sucssess: true, atkType:
                                activeChar.atkType03, buff: activeChar.buff03, dmgType: activeChar.dmgType03);
                                        }
                                        break;
                                    case 4:
                                        if (activeChar.buff03 == true)
                                        {
                                            activeChar.SPD = activeChar.SPD + activeChar.dmg03;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackThreeName, damage: activeChar.dmg03, sucssess: true, atkType:
                                activeChar.atkType03, buff: activeChar.buff03, dmgType: activeChar.dmgType03);
                                        }
                                        else
                                        {
                                            enemyRef.activeChar.SPD = enemyRef.activeChar.SPD - activeChar.dmg03;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackThreeName, damage: activeChar.dmg03, sucssess: true, atkType:
                                activeChar.atkType03, buff: activeChar.buff03, dmgType: activeChar.dmgType03);
                                        }
                                        break;

                                }
                            }
                            else
                            {
                                activeChar.currentHealth = activeChar.currentHealth + activeChar.dmg03;
                                if (activeChar.currentHealth > activeChar.maxHealth)
                                {
                                    activeChar.currentHealth = activeChar.maxHealth;
                                }
                                var findResults = GameObject.Find("resultsButton");
                                resaults = findResults.GetComponent<resaultsButton>();
                                resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackThreeName, damage: activeChar.dmg03, sucssess: true, atkType:
                                activeChar.atkType03, buff: activeChar.buff03, dmgType: activeChar.dmgType03);
                            }

                            if (activeChar.buff03 == true)
                            {
                                var Animation = playerMagic.GetComponent<Animator>();
                                Animation.SetTrigger("magicTrigger");
                            }
                            else
                            {
                                var Animation = enemyMagic.GetComponent<Animator>();
                                Animation.SetTrigger("magicTrigger");
                            }

                        }
                    }
                    else
                    {
                        var findResults = GameObject.Find("resultsButton");
                        resaults = findResults.GetComponent<resaultsButton>();

                        resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackThreeName, damage: 0, sucssess: false, atkType:
                                activeChar.atkType03, buff: activeChar.buff03, dmgType: activeChar.dmgType03);
                    }
                }
                break;
            case 4:
                if (activeChar.target04 == true)
                {


                    if ((Random.Range(1, 100)) < (activeChar.acc04))
                    {
                        if (activeChar.atkType04 == 0)
                        {
                            if (activeChar.atkType04 == activeChar.myType)
                            {
                                Stab = (1.50f);
                            }
                            else
                            {
                                Stab = (1);
                            }
                            if (Random.Range(1, 101) > 90)
                            {
                                crit = 2;
                            }
                            else
                            {
                                crit = 1;
                            }
                            if (activeChar.dmgType04 == 0)
                            {
                                damage = (((activeChar.LVL + activeChar.dmg04) * 2) * (activeChar.ATK / enemyRef.activeChar.DEF)) / 3;
                            }
                            else
                            {
                                damage = (((activeChar.LVL + activeChar.dmg04) * 2) * (activeChar.sATK / enemyRef.activeChar.sDEF)) / 3;
                            }
                            var finalDamage = damage * Stab * crit;
                            finalDamage = Mathf.Round(finalDamage);
                            enemyRef.activeChar.currentHealth = enemyRef.activeChar.currentHealth - finalDamage;
                            var findResults = GameObject.Find("resultsButton");
                            resaults = findResults.GetComponent<resaultsButton>();
                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackFourName, damage: finalDamage, sucssess: true, atkType:
                                activeChar.atkType04, buff: activeChar.buff04, dmgType: activeChar.dmgType04);
                            var Animation = findAnim.GetComponent<Animator>();
                            Animation.SetTrigger("123");
                        }
                        else
                        {
                            if (activeChar.atkType04 == 1)
                            {
                                switch (activeChar.dmgType04)
                                {
                                    case 0:
                                        if (activeChar.buff04 == true)
                                        {
                                            activeChar.ATK = activeChar.ATK + activeChar.dmg04;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackFourName, damage: activeChar.dmg04, sucssess: true, atkType:
                                activeChar.atkType04, buff: activeChar.buff04, dmgType: activeChar.dmgType04);
                                        }
                                        else
                                        {
                                            enemyRef.activeChar.ATK = enemyRef.activeChar.ATK - activeChar.dmg04;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackFourName, damage: activeChar.dmg04, sucssess: true, atkType:
                                activeChar.atkType04, buff: activeChar.buff04, dmgType: activeChar.dmgType04);
                                        }
                                        break;
                                    case 1:
                                        if (activeChar.buff04 == true)
                                        {
                                            activeChar.DEF = activeChar.DEF + activeChar.dmg04;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackFourName, damage: activeChar.dmg04, sucssess: true, atkType:
                                activeChar.atkType04, buff: activeChar.buff04, dmgType: activeChar.dmgType04);
                                        }
                                        else
                                        {
                                            enemyRef.activeChar.DEF = enemyRef.activeChar.DEF - activeChar.dmg04;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackFourName, damage: activeChar.dmg04, sucssess: true, atkType:
                                activeChar.atkType04, buff: activeChar.buff04, dmgType: activeChar.dmgType04);
                                        }
                                        break;
                                    case 2:
                                        if (activeChar.buff04 == true)
                                        {
                                            activeChar.sATK = activeChar.sATK + activeChar.dmg04;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackFourName, damage: activeChar.dmg04, sucssess: true, atkType:
                                activeChar.atkType04, buff: activeChar.buff04, dmgType: activeChar.dmgType04);
                                        }
                                        else
                                        {
                                            enemyRef.activeChar.sATK = enemyRef.activeChar.sATK - activeChar.dmg04;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackFourName, damage: activeChar.dmg04, sucssess: true, atkType:
                                activeChar.atkType04, buff: activeChar.buff04, dmgType: activeChar.dmgType04);
                                        }
                                        break;
                                    case 3:
                                        if (activeChar.buff04 == true)
                                        {
                                            activeChar.sDEF = activeChar.sDEF + activeChar.dmg04;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackFourName, damage: activeChar.dmg04, sucssess: true, atkType:
                                activeChar.atkType04, buff: activeChar.buff04, dmgType: activeChar.dmgType04);
                                        }
                                        else
                                        {
                                            enemyRef.activeChar.sDEF = enemyRef.activeChar.sDEF - activeChar.dmg04;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackFourName, damage: activeChar.dmg04, sucssess: true, atkType:
                                activeChar.atkType04, buff: activeChar.buff04, dmgType: activeChar.dmgType04);
                                        }
                                        break;
                                    case 4:
                                        if (activeChar.buff04 == true)
                                        {
                                            activeChar.SPD = activeChar.SPD + activeChar.dmg04;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackFourName, damage: activeChar.dmg04, sucssess: true, atkType:
                                activeChar.atkType04, buff: activeChar.buff04, dmgType: activeChar.dmgType04);
                                        }
                                        else
                                        {
                                            enemyRef.activeChar.SPD = enemyRef.activeChar.SPD - activeChar.dmg04;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackFourName, damage: activeChar.dmg04, sucssess: true, atkType:
                                activeChar.atkType04, buff: activeChar.buff04, dmgType: activeChar.dmgType04);
                                        }
                                        break;

                                }
                            }
                            else
                            {
                                activeChar.currentHealth = activeChar.currentHealth + activeChar.dmg04;
                                if (activeChar.currentHealth > activeChar.maxHealth)
                                {
                                    activeChar.currentHealth = activeChar.maxHealth;
                                }
                                var findResults = GameObject.Find("resultsButton");
                                resaults = findResults.GetComponent<resaultsButton>();
                                resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackFourName, damage: activeChar.dmg04, sucssess: true, atkType:
                                activeChar.atkType04, buff: activeChar.buff04, dmgType: activeChar.dmgType04);
                            }

                            if (activeChar.buff04 == true)
                            {
                                var Animation = playerMagic.GetComponent<Animator>();
                                Animation.SetTrigger("magicTrigger");
                            }
                            else
                            {
                                var Animation = enemyMagic.GetComponent<Animator>();
                                Animation.SetTrigger("magicTrigger");
                            }

                        }
                    }
                    else
                    {
                        var findResults = GameObject.Find("resultsButton");
                        resaults = findResults.GetComponent<resaultsButton>();

                        resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackFourName, damage: 0, sucssess: false, atkType:
                                activeChar.atkType03, buff: activeChar.buff03, dmgType: activeChar.dmgType03);
                    }
                }
                break;
            case 5:
                if (activeChar.target05 == true)
                {


                    if ((Random.Range(1, 100)) < (activeChar.acc05))
                    {
                        if (activeChar.atkType05 == 0)
                        {
                            if (activeChar.atkType05 == activeChar.myType)
                            {
                                Stab = (1.50f);
                            }
                            else
                            {
                                Stab = (1);
                            }
                            if (Random.Range(1, 101) > 90)
                            {
                                crit = 2;
                            }
                            else
                            {
                                crit = 1;
                            }
                            if (activeChar.dmgType05 == 0)
                            {
                                damage = (((activeChar.LVL + activeChar.dmg05) * 2) * (activeChar.ATK / enemyRef.activeChar.DEF)) / 3;
                            }
                            else
                            {
                                damage = (((activeChar.LVL + activeChar.dmg05) * 2) * (activeChar.sATK / enemyRef.activeChar.sDEF)) / 3;
                            }
                            var finalDamage = damage * Stab * crit;
                            finalDamage = Mathf.Round(finalDamage);
                            enemyRef.activeChar.currentHealth = enemyRef.activeChar.currentHealth - finalDamage;
                            var findResults = GameObject.Find("resultsButton");
                            resaults = findResults.GetComponent<resaultsButton>();
                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackFiveName, damage: finalDamage, sucssess: true, atkType:
                                activeChar.atkType05, buff: activeChar.buff05, dmgType: activeChar.dmgType05);
                            var Animation = findAnim.GetComponent<Animator>();
                            Animation.SetTrigger("123");
                        }
                        else
                        {
                            if (activeChar.atkType05 == 1)
                            {
                                switch (activeChar.dmgType05)
                                {
                                    case 0:
                                        if (activeChar.buff05 == true)
                                        {
                                            activeChar.ATK = activeChar.ATK + activeChar.dmg05;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackFiveName, damage: activeChar.dmg05, sucssess: true, atkType:
                                activeChar.atkType05, buff: activeChar.buff05, dmgType: activeChar.dmgType05);
                                        }
                                        else
                                        {
                                            enemyRef.activeChar.ATK = enemyRef.activeChar.ATK - activeChar.dmg05;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackFiveName, damage: activeChar.dmg05, sucssess: true, atkType:
                                activeChar.atkType05, buff: activeChar.buff05, dmgType: activeChar.dmgType05);
                                        }
                                        break;
                                    case 1:
                                        if (activeChar.buff05 == true)
                                        {
                                            activeChar.DEF = activeChar.DEF + activeChar.dmg05;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackFiveName, damage: activeChar.dmg05, sucssess: true, atkType:
                                activeChar.atkType05, buff: activeChar.buff05, dmgType: activeChar.dmgType05);
                                        }
                                        else
                                        {
                                            enemyRef.activeChar.DEF = enemyRef.activeChar.DEF - activeChar.dmg05;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackFiveName, damage: activeChar.dmg05, sucssess: true, atkType:
                                activeChar.atkType05, buff: activeChar.buff05, dmgType: activeChar.dmgType05);
                                        }
                                        break;
                                    case 2:
                                        if (activeChar.buff05 == true)
                                        {
                                            activeChar.sATK = activeChar.sATK + activeChar.dmg05;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackFiveName, damage: activeChar.dmg05, sucssess: true, atkType:
                                activeChar.atkType05, buff: activeChar.buff05, dmgType: activeChar.dmgType05);
                                        }
                                        else
                                        {
                                            enemyRef.activeChar.sATK = enemyRef.activeChar.sATK - activeChar.dmg05;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackFiveName, damage: activeChar.dmg05, sucssess: true, atkType:
                                activeChar.atkType05, buff: activeChar.buff05, dmgType: activeChar.dmgType05);
                                        }
                                        break;
                                    case 3:
                                        if (activeChar.buff05 == true)
                                        {
                                            activeChar.sDEF = activeChar.sDEF + activeChar.dmg05;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackFiveName, damage: activeChar.dmg05, sucssess: true, atkType:
                                activeChar.atkType05, buff: activeChar.buff05, dmgType: activeChar.dmgType05);
                                        }
                                        else
                                        {
                                            enemyRef.activeChar.sDEF = enemyRef.activeChar.sDEF - activeChar.dmg05;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackFiveName, damage: activeChar.dmg05, sucssess: true, atkType:
                                activeChar.atkType05, buff: activeChar.buff05, dmgType: activeChar.dmgType05);
                                        }
                                        break;
                                    case 4:
                                        if (activeChar.buff05 == true)
                                        {
                                            activeChar.SPD = activeChar.SPD + activeChar.dmg05;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackFiveName, damage: activeChar.dmg05, sucssess: true, atkType:
                                activeChar.atkType05, buff: activeChar.buff05, dmgType: activeChar.dmgType05);
                                        }
                                        else
                                        {
                                            enemyRef.activeChar.SPD = enemyRef.activeChar.SPD - activeChar.dmg05;
                                            var findResults = GameObject.Find("resultsButton");
                                            resaults = findResults.GetComponent<resaultsButton>();
                                            resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackFiveName, damage: activeChar.dmg05, sucssess: true, atkType:
                                activeChar.atkType05, buff: activeChar.buff05, dmgType: activeChar.dmgType05);
                                        }
                                        break;

                                }
                            }
                            else
                            {
                                activeChar.currentHealth = activeChar.currentHealth + activeChar.dmg05;
                                if (activeChar.currentHealth > activeChar.maxHealth)
                                {
                                    activeChar.currentHealth = activeChar.maxHealth;
                                }
                                var findResults = GameObject.Find("resultsButton");
                                resaults = findResults.GetComponent<resaultsButton>();
                                resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackFiveName, damage: activeChar.dmg05, sucssess: true, atkType:
                                activeChar.atkType05, buff: activeChar.buff05, dmgType: activeChar.dmgType05);
                            }

                            if (activeChar.buff05 == true)
                            {
                                var Animation = playerMagic.GetComponent<Animator>();
                                Animation.SetTrigger("magicTrigger");
                            }
                            else
                            {
                                var Animation = enemyMagic.GetComponent<Animator>();
                                Animation.SetTrigger("magicTrigger");
                            }

                        }
                    }
                    else
                    {
                        var findResults = GameObject.Find("resultsButton");
                        resaults = findResults.GetComponent<resaultsButton>();

                        resaults.PlayerResaultsTXT(User: activeChar.Name, attackName: activeChar.attackFiveName, damage: 0, sucssess: false, atkType:
                                activeChar.atkType05, buff: activeChar.buff05, dmgType: activeChar.dmgType05);
                    }
                }
                break;
        
        }
        
    }




}
