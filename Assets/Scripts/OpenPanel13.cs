using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class OpenPanel13: MonoBehaviour {
    public GameObject Panel13;
    public void PanelOpener13() {
        if (Panel13 != null) {
            bool isActive = Panel13.activeSelf;
            Panel13.SetActive(!isActive);
        }
    }
}