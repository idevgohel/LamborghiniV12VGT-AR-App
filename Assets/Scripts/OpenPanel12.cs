using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class OpenPanel12: MonoBehaviour {
    public GameObject Panel12;
    public void PanelOpener12() {
        if (Panel12 != null) {
            bool isActive = Panel12.activeSelf;
            Panel12.SetActive(!isActive);
        }
    }
}