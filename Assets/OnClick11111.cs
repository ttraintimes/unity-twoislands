﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick11111: MonoBehaviour {
  public GameObject Onjs;
  public GameObject gameobject;
  void Start() {
  }
  void Update() {
    if (Input.GetMouseButton(0)) {
      Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
      RaycastHit hit;
      if (Physics.Raycast(ray, out hit)) {
        if (hit.collider.tag == "npc4") {
          Onjs.gameObject.SetActive(true);
        }
      }
    }
  }
}