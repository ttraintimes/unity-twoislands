using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick: MonoBehaviour {

    /* private void OnMouseDown()
    {
    if (FindObjectOfType<GameManamge>().a >2)
        {
        GetComponent<Animator>().enabled = true; // stonegate open
            transform.GetChild(1).gameObject.SetActive(true);
            }
            }
            */
    void Update() {
        if (Input.GetMouseButton(0)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) {
                if (hit.collider.tag == "gate") {
                    if (FindObjectOfType < GameManamge > ().a > 2) {
                        GetComponent < Animator > ().enabled = true; // stonegate open
                        transform.GetChild(1).gameObject.SetActive(true);
                    }
                }

            }
        }

    }

}