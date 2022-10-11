using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cancelopenpanel : MonoBehaviour
{
    public GameObject gameObject;
    bool active;
    public void Close()
    {
        if (active == false) 
        {
            gameObject.transform.gameObject.SetActive(false);
        
        }
    }
}