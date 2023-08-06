using RootMotion;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManamge : MonoBehaviour
{
    public AudioSource TipAudio;
    public Text text;
    private void Awake()
    {
        Time.timeScale = 1;
    }
    public GameObject[] ddf;
    void Start()
    {
    }

    public Text ttd;
    [HideInInspector]
    public  int a=0;
    [HideInInspector]
    public int a2 = 0;
    public void DF()
    {
        a++;
        ttd.text = a+"/3";
        TipAudio.Play();
        anis.Play("1");
    }
    public Animator anis;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            ViewFunction();
        }
    }
    private bool _view = true;
    public CameraController cc;
    public void ViewFunction()
    {
        if (_view)
        {
            cc.offset.x = 0.04f;
            cc.offset.y = 2.15f;
            cc.offset.z = 10.5f;
        }
        else
        {
            cc.offset.x = 0f;
            cc.offset.z = 2.15f;
            cc.offset.z = 8f;
        }
        _view = !_view;
    }
}