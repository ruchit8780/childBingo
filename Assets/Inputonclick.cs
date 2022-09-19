using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inputonclick : MonoBehaviour
{
    public Button btnClick;

    //get input filed
    public InputField inputUser;

    private void Start()
    {
        //attach button event
        btnClick.onClick.AddListener(InputonclickHandler);
    }
    /// <summary>
    /// Method that will run on click
    /// </summary>
    public void InputonclickHandler()
    {
        //show input text when user click the button
        Debug.Log("Log input: " + inputUser.text);
    }
}