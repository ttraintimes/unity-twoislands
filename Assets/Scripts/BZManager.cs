using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BZManager : MonoBehaviour
{
    public Slider slider;
    public Text text;
    private AudioSource ads;
    
    void Start()
    {
        ads = GameObject.Find("Audio Source").GetComponent<AudioSource>();

        slider = transform.Find("Settings/SceneBGSlider").GetComponent<Slider>();
    }


    void Update()
    {
        text.text = (slider.value * 100).ToString("f0") + "%";
        ads.volume = slider.value;


    }

    public void Quita()
    {
        Application.Quit();
    }

}
