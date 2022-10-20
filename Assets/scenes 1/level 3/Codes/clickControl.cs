using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class clickControl : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame update

    public TMP_Text num1text;
    public int index;
    public TMP_Text operand1text;
    public TMP_Text operand2text;
    public Button button;
    public Sprite image;
    public

    void Start()
    {
        //Debug.Log("cc"+index);
        num1text.text = GMScript.test[index].ToString();
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        int currquesint = GMScript.index;
        if (GMScript.test[index] == GMScript.operator1[currquesint] - GMScript.operator2[currquesint])
        {
            Debug.Log("correct ans");
            button.GetComponent<Image>().sprite = image;
            //num1text.text = "";
            GMScript.result[index] = true;
            //button.GetComponent<Button>().interactable = false;
        }
        else
        {
            button.GetComponent<Button>().interactable = false;
            Debug.Log("incorrect ans");
        }

        GMScript.index = currquesint + 1;
        if (currquesint < 24)
        {
            operand1text.text = GMScript.operator1[currquesint + 1].ToString();
            operand2text.text = GMScript.operator2[currquesint + 1].ToString();
        }
        Debug.Log("button number" + index + " clicked");
    }
    //public void buttontesting()
    //{
    //    Debug.Log("button"+index+"clicked!");
    //}
}