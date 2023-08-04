using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigge : MonoBehaviour
{
 
// drop fail 
    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<GameManamge>().a2 = 1;
        gameObject.SetActive(false);

    }
}
