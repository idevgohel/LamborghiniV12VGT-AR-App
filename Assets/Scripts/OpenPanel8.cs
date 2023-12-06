using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class OpenPanel8: MonoBehaviour {
    public GameObject Panel8;
    public void PanelOpener8() {
        if (Panel8 != null) {
            bool isActive = Panel8.activeSelf;
            Panel8.SetActive(!isActive);
        }
    }
}