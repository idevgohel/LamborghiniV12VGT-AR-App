using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class OpenPanel1: MonoBehaviour {
    public GameObject Panel1;
    public void PanelOpener1() {
        if (Panel1 != null) {
            bool isActive = Panel1.activeSelf;
            Panel1.SetActive(!isActive);
        }
    }
}