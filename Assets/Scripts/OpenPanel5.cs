using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class OpenPanel5: MonoBehaviour {
    public GameObject Panel5;
    public void PanelOpener5() {
        if (Panel5 != null) {
            bool isActive = Panel5.activeSelf;
            Panel5.SetActive(!isActive);
        }
    }
}