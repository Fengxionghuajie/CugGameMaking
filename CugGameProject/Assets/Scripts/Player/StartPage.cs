using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartPage : MonoBehaviour
{

    public void StartGame()//��ʼ��Ϸ
    {
        SceneManager.LoadScene("Level1");//Ҫ�л����ĳ�����
    }


    public void LoadGame()//������Ϸ
    {
        /* �浵�������մ�*/
    }


    public void ExitGame()//�˳���Ϸ
    {
        Application.Quit();
    }
}
