using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelscript : MonoBehaviour
{
    public void easy(int num)
    {
        SceneManager.LoadScene(num);
        GMScript.level_parameter = 1;
    }
    public void hard(int num1)
    {
        SceneManager.LoadScene(num1);
        GMScript.level_parameter = 3;
    }
    public void medium(int num2)
    {
        SceneManager.LoadScene(num2);
        GMScript.level_parameter = 2;
    }
}
