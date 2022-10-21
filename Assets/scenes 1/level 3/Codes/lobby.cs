using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lobby : MonoBehaviour
{
    public void lobbybutton()
    {
    Debug. Log("Function called!");
    SceneManager.LoadScene(6);
    }
}
