using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigge1 : MonoBehaviour
{
// success
    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<GameManamge>().a2 = 2;
        gameObject.SetActive(false);
    }
}
