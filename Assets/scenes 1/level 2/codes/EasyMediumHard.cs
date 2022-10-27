using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EasyMediumHard : MonoBehaviour
{
    public void easy(int num)
    {
        SceneManager.LoadScene(num);
    }
    public void hard(int num1)
    {
        SceneManager.LoadScene(num1);
    }
    public void medium(int num2)
    {
        SceneManager.LoadScene(num2);
    }
}
