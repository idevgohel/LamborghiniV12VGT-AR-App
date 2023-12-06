using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class OpenPanel14: MonoBehaviour {
    public GameObject Panel14;
    public void PanelOpener14() {
        if (Panel14 != null) {
            bool isActive = Panel14.activeSelf;
            Panel14.SetActive(!isActive);
        }
    }
}