using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMaster : MonoBehaviour {

    public GameObject ch1;
    public GameObject ch2;
    public GameObject ch3;
    public GameObject ch4;
    public GameObject menu;
    //public GameObject alergenos;
    public int countAlle=0;
    public void Start() {
        if (countAlle == 0)
        {
            menu.gameObject.SetActive(true);
            menu.GetComponent<MyMenu>().Start();
            ch1.gameObject.SetActive(false);
            ch2.gameObject.SetActive(false);
            ch3.gameObject.SetActive(false);
            ch4.gameObject.SetActive(false);
        }
        else {
            //alergenos.transform.Translate(new Vector3(0, 0, -1000));
            menu.gameObject.SetActive(true);
            menu.GetComponent<MyMenu>().Start();
            ch1.gameObject.SetActive(false);
            ch2.gameObject.SetActive(false);
            ch3.gameObject.SetActive(false);
            ch4.gameObject.SetActive(false);
            countAlle = 0;
        }
        
    }

    public void Ch1()
    {
        countAlle++;
        if (countAlle == 1)
        {
           // alergenos.transform.Translate(new Vector3(0, 0, 1000));
        }
        else { }
        menu.gameObject.SetActive(false);
        ch1.gameObject.SetActive(true);
        ch1.GetComponent<Chapter1>().Start();
        ch2.gameObject.SetActive(false);
        ch3.gameObject.SetActive(false);
        ch4.gameObject.SetActive(false);
    }
    public void Ch2()
    {
        countAlle++;
        if (countAlle == 1)
        {
           // alergenos.transform.Translate(new Vector3(0, 0, 1000));
        }
        else { }
        menu.gameObject.SetActive(false);
        ch1.gameObject.SetActive(false);
        ch2.gameObject.SetActive(true);
        ch4.gameObject.SetActive(false);
        ch2.GetComponent<Chapter2>().Start();
        ch3.gameObject.SetActive(false);
    }
    public void Ch3()
    {
        countAlle++;
        if (countAlle == 1)
        {
            //alergenos.transform.Translate(new Vector3(0, 0, 1000));
        }
        else { }
        menu.gameObject.SetActive(false);
        ch1.gameObject.SetActive(false);
        ch2.gameObject.SetActive(false);
        ch3.gameObject.SetActive(true);
        ch4.gameObject.SetActive(false);
        ch3.GetComponent<Chapter3>().Start();
    }

    public void Ch4()
    {
        countAlle++;
        if (countAlle == 1)
        {
            //alergenos.transform.Translate(new Vector3(0, 0, 1000));
        }
        else { }
        menu.gameObject.SetActive(false);
        ch1.gameObject.SetActive(false);
        ch2.gameObject.SetActive(false);
        ch3.gameObject.SetActive(false);
        ch4.gameObject.SetActive(true);
        ch4.GetComponent<Chapter4>().Start();
    }
}
