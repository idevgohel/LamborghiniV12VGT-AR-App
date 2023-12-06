using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class OpenPanel11: MonoBehaviour {
    public GameObject Panel11;
    public void PanelOpener11() {
        if (Panel11 != null) {
            bool isActive = Panel11.activeSelf;
            Panel11.SetActive(!isActive);
        }
    }
}