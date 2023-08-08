using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReturnBtn : MonoBehaviour
{

    public void ExitBtn()
    {
        int y = SceneManager.GetActiveScene().buildIndex;
        SceneManager.UnloadSceneAsync(y);
        foreach (GameObject g in SceneManager.GetSceneByName("main").GetRootGameObjects())
        {
            g.SetActive(true);
        }
        
        GameObject.Find("Canvas").SetActive(false);
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("main"));
    }

}
