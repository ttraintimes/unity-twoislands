using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    public void mainBtn()
    {
        SceneManager.LoadScene("main");
    }
    public void storyBtn2()
    {
        SceneManager.LoadScene("paintgame");
    }

    public void quitBtn()
    {
        Application.Quit();
    }

}
