using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour {



    public static Data Party;

    public CharClass ActiveChar;
    public CharClass ActiveInUi;

    public CharClass[] PlayerParty = new CharClass[4];

    public CharClass[] EnemyParty = new CharClass[4];



    void Awake()
    {
        if (Party == null)
        {
            DontDestroyOnLoad(transform.gameObject);
            Party = this;
        }
        else if (Party != this)
        {
            Destroy(gameObject);
        }
    }
}
