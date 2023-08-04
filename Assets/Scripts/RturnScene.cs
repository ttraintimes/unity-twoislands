using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RturnScene : MonoBehaviour
{

    private void OnEnable()
    {
        Time.timeScale = 0;
        GameObject.Find("Audio Source").SetActive(false);
    }
    public void OncLSD()
    {
        SceneManager.LoadScene("main");
    }
    public void Quita()
    {
        Application.Quit();
    }
}
