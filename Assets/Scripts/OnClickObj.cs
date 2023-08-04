using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickObj : MonoBehaviour
{
void OnMouseDown()
    {
                    FindObjectOfType<GameManamge>().DF();
                    gameObject.SetActive(false);

    }
}
