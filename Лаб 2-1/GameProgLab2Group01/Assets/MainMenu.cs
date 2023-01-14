using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   
    public void LoadTo(int level)//����.������� ������
    {
        SceneManager.LoadScene(level);
    }

    public void Reset()//����� �����
    {
        PlayerPrefs.DeleteAll();
    }

    public void Exit()//�����
    {
        Application.Quit();
    }

}
