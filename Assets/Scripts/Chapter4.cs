using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter4 : MonoBehaviour {

	public GameObject[] imagenes;
	public GameObject siguienteBoton;
	public GameObject myMaster;
	int counter = 0;
	public void Start()
	{
		siguienteBoton.gameObject.SetActive(true);
		ResetImages();
		imagenes[0].gameObject.SetActive(true);
	}

	private void ResetImages()
	{
		for (int i = 0; i < imagenes.Length; i++)
		{
			imagenes[i].gameObject.SetActive(false);
		}
	}

	public void Siguiente()
	{
		counter++;
		ResetImages();
		imagenes[counter].gameObject.SetActive(true);
		if (counter == 9)
		{
			counter = 0;
			siguienteBoton.gameObject.SetActive(false);
		}
		
	}
	public void GoHome()
	{
		ResetImages();
		counter = 0;
		myMaster.GetComponent<MyMaster>().Start();
	}
}
