using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class GMscripts : MonoBehaviour
{
    int E_Min = 0;
    int E_Max = 30;
    int Mid_Min = 31;
    int Mid_Max = 99;
    int Hard_Min = 100;
    int Hard_Max = 999;
    public static int level_parameter;
    public static int index = 0;
    public static int[] test = new int[25];
    public static int[] operator1 = new int[25];
    public static int[] operator2 = new int[25];
    public static bool[] result = new bool[25];
    public TMP_Text operator1_handler;
    public TMP_Text operand1_handler;
    public TMP_Text operand2_handler;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("gm");
        Debug.Log("level_parameter:" + level_parameter);
        for (int i = 0; i < 25; i++)
        {
            if (level_parameter == 1)
            {
                operator1[i] = UnityEngine.Random.Range(E_Min, E_Max);
                operator2[i] = UnityEngine.Random.Range(E_Min, operator1[i]);
            }
            else if (level_parameter == 2)
            {
                operator1[i] = UnityEngine.Random.Range(Mid_Min, Mid_Max);
                operator2[i] = UnityEngine.Random.Range(Mid_Min, operator1[i]);
            }
            else if (level_parameter == 3)
            {
                operator1[i] = UnityEngine.Random.Range(Hard_Min, Hard_Max);
                operator2[i] = UnityEngine.Random.Range(Hard_Min, operator1[i]);


            }
            test[i] = operator1[i] / operator2[i];


        }
        String[] o1 = Array.ConvertAll(operator1, x => x.ToString());
        String[] o2 = Array.ConvertAll(operator2, x => x.ToString());
        String[] t = Array.ConvertAll(test, x => x.ToString());
        Debug.Log(String.Join(",", o1));
        Debug.Log(String.Join(",", o2));
        Debug.Log(String.Join(",", t));


    }

    // Update is called once per frame
    void Update()
    {

    }
}
