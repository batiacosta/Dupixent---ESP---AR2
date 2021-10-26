using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTriggerEvents : MonoBehaviour {
    public GameObject marco;
    public void OverMyButton() {
        GetComponent<Animator>().SetBool("isOverButton", true);
        marco.gameObject.SetActive(true);
    }

    public void LeaveMyButton() {
        GetComponent<Animator>().SetBool("isOverButton", false);
        marco.gameObject.SetActive(false);
    }
}
