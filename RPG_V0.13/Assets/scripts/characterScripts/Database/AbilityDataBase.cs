using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityDataBase : MonoBehaviour {

    public static AbilityDataBase Ability;

    public string[] AbilityName = new string[] { "", "Adaptability", "Unbending Will", "SteadyHand", "Lightning Rod", "Condesend", "Archane Barrier", "Cleanse", "Nimble Toes" };

    public string[] AbilityDesc = new string[] { "", "after using an atk raise atk and reduces satk", "survive a move would reduce hp to 0 from full hp", "if opponent has a status effect deal extra damage", "electric attacks reduced to 0 and raise speed greatly", "lowers attack of enemy", "fire water nature and air damage reduced", "switching out clears status effect", "lowers defense raises evasion" };

    private void Awake()
    {
        if (Ability == null)
        {

            Ability = this;

        }
        else if (Ability != this)
        {

        }
    }




}
