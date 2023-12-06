using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class OpenPanel15: MonoBehaviour {
    public GameObject Panel15;
    public void PanelOpener15() {
        if (Panel15 != null) {
            bool isActive = Panel15.activeSelf;
            Panel15.SetActive(!isActive);
        }
    }
}