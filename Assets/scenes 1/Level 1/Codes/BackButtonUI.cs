using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonUI : MonoBehaviour
{
    [SerializeField] private string newGameLevel1 = "SampleScene";

    public void NewGameButton()
    {
         Debug. Log("Function called!");
        SceneManager.LoadScene(newGameLevel1);
    }


}