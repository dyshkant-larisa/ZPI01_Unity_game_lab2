using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   
    public void LoadTo(int level)//загр.нужного уровня
    {
        SceneManager.LoadScene(level);
    }

    public void Reset()//сброс очков
    {
        PlayerPrefs.DeleteAll();
    }

    public void Exit()//выход
    {
        Application.Quit();
    }

}
