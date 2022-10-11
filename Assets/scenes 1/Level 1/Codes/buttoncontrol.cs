 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class buttoncontrol : MonoBehaviour
{
    public TextMeshProUGUI user_name;
    public TMP_InputField user_inputField;



    public void setName()
    {
        user_name.text = user_inputField.text;
	  SceneManager.LoadScene(2);
    }
    public void resetName()
    {
        user_name.text = "";
    }
}
