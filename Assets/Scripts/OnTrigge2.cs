using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigge2 : MonoBehaviour
{
    public GameObject[] pANELD;
    private void OnTriggerEnter(Collider other)
    {
        if (FindObjectOfType<GameManamge>().a2 == 1) 
        {
            pANELD[0].SetActive(true); // fail
        }
        if (FindObjectOfType<GameManamge>().a2 == 2)
        {
                if(FindObjectOfType<GameManamge>().a >2)
                {
                   pANELD[1].SetActive(true); // success
                }
            
        }
    }
}
