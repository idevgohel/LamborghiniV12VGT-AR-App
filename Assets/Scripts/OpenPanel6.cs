using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class OpenPanel6: MonoBehaviour {
    public GameObject Panel6;
    public void PanelOpener6() {
        if (Panel6 != null) {
            bool isActive = Panel6.activeSelf;
            Panel6.SetActive(!isActive);
        }
    }
}