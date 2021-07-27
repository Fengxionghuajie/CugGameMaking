using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartPage : MonoBehaviour
{

    public void StartGame()//开始游戏
    {
        SceneManager.LoadScene("Level1");//要切换到的场景名
    }


    public void LoadGame()//继续游戏
    {
        /* 存档功能留空处*/
    }


    public void ExitGame()//退出游戏
    {
        Application.Quit();
    }
}
