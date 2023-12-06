using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class OpenPanel10: MonoBehaviour {
    public GameObject Panel10;
    public void PanelOpener10() {
        if (Panel10 != null) {
            bool isActive = Panel10.activeSelf;
            Panel10.SetActive(!isActive);
        }
    }
}