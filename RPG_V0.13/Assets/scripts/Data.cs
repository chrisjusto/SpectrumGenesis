using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour {

    public static Data partyData;

    public Data Party;

    public charClass ActiveChar;
    public charClass partyMember01;
    public charClass partyMember02;
    public charClass partyMember03;
    public charClass partyMember04;

    public charClass ActiveInUi;


    public charClass ActiveEnemy;
    public charClass EnemyParty01;
    public charClass EnemyParty02;
    public charClass EnemyParty03;
    public charClass EnemyParty04;


    public int part01;


    void Awake()
    {
        if (partyData == null)
        {
            DontDestroyOnLoad(transform.gameObject);
            partyData = this;

            Party = partyData;

        }
        else if (partyData != this)
        {
            Destroy(gameObject);
        }

    }



}


