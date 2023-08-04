﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{

    Button button;
    private void Start()
    {

        button = GetComponent<Button>();
        button.onClick.AddListener(OnQuit);
    }

    void OnQuit()
    {
        Application.Quit();
    }
}
