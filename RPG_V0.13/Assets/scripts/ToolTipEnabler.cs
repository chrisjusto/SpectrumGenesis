using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ToolTipEnabler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

    public GameObject toolTip;
    public int attack;
    public bool equiped;

    //show tooltip

    public void OnPointerEnter(PointerEventData eventData)
    {
        ShowToolTip();
    }

    //hide tooltip

    public void OnPointerExit(PointerEventData eventData)
    {
        HideToolTip();
    }


    public void ShowToolTip()
    {
        toolTip.SetActive(true);
        ChangeText();       
    }
    public void HideToolTip()
    {
        toolTip.SetActive(false);
    }
    public void ChangeText()
    {
        toolTip.GetComponent<ToolTipText>().Enable(Equiped: equiped, HoveredAttack: attack);
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
