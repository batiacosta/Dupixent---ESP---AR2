using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour {

    // Update is called once per frame
    bool inCoroutine = false;
    void Update() {
        if (!inCoroutine)
        {
            StartCoroutine(RandomMyMovement());
        }
        
    }
    IEnumerator RandomMyMovement() { 
        inCoroutine = true;
        yield return new WaitForSeconds(1f);

        GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), Random.Range(-5, 5)) *0.05f);
        GetComponent<Rigidbody>().AddTorque(new Vector3(Random.Range(-5, 0), Random.Range(0, 5), Random.Range(-5, 5)) * 10f);
        inCoroutine = false;
    } 
}
