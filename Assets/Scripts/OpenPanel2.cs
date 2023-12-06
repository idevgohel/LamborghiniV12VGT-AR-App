using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class OpenPanel2: MonoBehaviour {
    public GameObject Panel2;
    public void PanelOpener2() {
        if (Panel2 != null) {
            bool isActive = Panel2.activeSelf;
            Panel2.SetActive(!isActive);
        }
    }
}