using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class OpenPanel7: MonoBehaviour {
    public GameObject Panel7;
    public void PanelOpener7() {
        if (Panel7 != null) {
            bool isActive = Panel7.activeSelf;
            Panel7.SetActive(!isActive);
        }
    }
}