using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class OpenPanel9: MonoBehaviour {
    public GameObject Panel9;
    public void PanelOpener9() {
        if (Panel9 != null) {
            bool isActive = Panel9.activeSelf;
            Panel9.SetActive(!isActive);
        }
    }
}