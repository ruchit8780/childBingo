using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openpanel : MonoBehaviour
{
    public GameObject panel;

    public void panelopen()
    {
        if (panel != null)
        {
            panel.SetActive(true);
        }
    }
}