  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelopener : MonoBehaviour
{
    public GameObject panel;

    public void openpanel()
    {
        if (panel != null)
        {
            panel.SetActive(true);
        }
    }
}
