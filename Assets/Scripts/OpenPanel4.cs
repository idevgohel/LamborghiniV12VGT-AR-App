using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class OpenPanel4: MonoBehaviour {
    public GameObject Panel4;
    public void PanelOpener4() {
        if (Panel4 != null) {
            bool isActive = Panel4.activeSelf;
            Panel4.SetActive(!isActive);
        }
    }
}