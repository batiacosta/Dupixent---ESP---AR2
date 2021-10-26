using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMenu : MonoBehaviour {

    // Use this for initialization
    public GameObject master;
	public void Cha1 () {
        master.GetComponent<MyMaster>().Ch1();
	}
    public void Cha2()
    {
        master.GetComponent<MyMaster>().Ch2();
    }
    public void Cha3()
    {
        master.GetComponent<MyMaster>().Ch3();
    }
    public void Cha4()
    {
        master.GetComponent<MyMaster>().Ch4();
    }
    public void Start() { }

}
