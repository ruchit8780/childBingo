using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class cagebackbutton : MonoBehaviour
{
   public void cageback(){
        Debug. Log("Function called!");
        SceneManager.LoadScene(0);
   }
}
