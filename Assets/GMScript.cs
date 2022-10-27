using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GMScript : MonoBehaviour
{
    int Min = 0;
    int Max = 99;
    public static int index = 0;
    public static int[] test = new int[25];
    public static int[] operator1 = new int[25];
    public static int[] operator2 = new int[25];
    public static bool[] result = new bool[25];

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("gm");
        for (int i = 0; i < 25; i++)
        {
            operator1[i] = UnityEngine.Random.Range(Min, Max);
            operator2[i] = UnityEngine.Random.Range(Min, operator1[i]);
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
