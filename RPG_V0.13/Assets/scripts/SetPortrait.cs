using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetPortrait : MonoBehaviour {

    private Sprite charSprite;
    private SpriteRenderer spriteR;
    public Button addButton;

	// Use this for initialization
	void Start () {
		



	}
	
	// Update is called once per frame
	void Update () {

 


    }

    public void SetCharacter (int Char) 
    {
        switch (Char)
        {
            case 0:

                GetComponent<Image>().sprite = Resources.Load<Sprite>("char/charFrame/01abelPortrait");



                break;
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
            case 7:
                break;

        }
    }
}
