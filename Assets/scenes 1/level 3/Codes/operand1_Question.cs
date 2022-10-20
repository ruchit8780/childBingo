using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class operand1_Question : MonoBehaviour
{
  public TMP_Text num1text;
// Start is called before the first frame update
void Start()
{
    Debug.Log("oa1");
    num1text.text = GMScript.operator1[0].ToString();
}

// Update is called once per frame
void Update()
        {

        }
}
