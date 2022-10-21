using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayUI : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "Level1";

    public void NewGameButton()
    {
        SceneManager.LoadScene(newGameLevel);
    }
}
