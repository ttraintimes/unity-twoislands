using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timd : MonoBehaviour
{
    public float CountDownTime;
    private float GameTime;
    private float timer = 0;
    public Text GameCountTimeText;

    void Start()
    {
        GameTime = CountDownTime;
    }

    public GameObject EndPanel;
    void Update()
    {
        int M = (int)(GameTime / 60);
        float S = GameTime % 60;
        timer += Time.deltaTime;
        if (timer >= 1f)
        {
            timer = 0;
            GameTime--;
            GameCountTimeText.text = M + ":" + string.Format("{0:00}", S);
        }
        if (GameTime <= 0)
        {
           // EndPanel.SetActive(true);
        }
    }
}