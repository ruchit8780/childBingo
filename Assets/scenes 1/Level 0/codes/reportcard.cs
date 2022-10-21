using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reportcard : MonoBehaviour
{
    public void report()
    {
        Debug.Log("Function called!");
        SceneManager.LoadScene(5);
    }
 
}
