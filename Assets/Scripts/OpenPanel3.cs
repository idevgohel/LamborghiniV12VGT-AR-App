using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class OpenPanel3: MonoBehaviour {
    public GameObject Panel3;
    public void PanelOpener3() {
        if (Panel3 != null) {
            bool isActive = Panel3.activeSelf;
            Panel3.SetActive(!isActive);
        }
    }
}