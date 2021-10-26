using UnityEngine;

public class CosWave : MonoBehaviour {

	private float amplitude = 2.0f;
 	private float factor = 0.5f;
	
	void Update () {
		int pCount = 0;
		foreach (Transform child in transform){
			print("Foreach loop: " + child);
			Vector3 cosPos = child.position;
			cosPos.z = Mathf.Cos(Time.time + pCount *factor) * amplitude ;
			//cosPos.x = Mathf.Cos(Time.time + pCount *factor*10.0f) * amplitude ;
			Debug.Log(pCount);
			child.transform.position = cosPos;
			pCount++;
		}
	}
}
