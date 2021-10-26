using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter1 : MonoBehaviour {

    public GameObject chapterTitle;
    public GameObject myMaster;
    public AudioClip[] narraticas;
    public AudioSource mySource;
    public GameObject textos1;
    public GameObject worldWide;
    public GameObject hombreCh1;
    public GameObject my300;
    public GameObject percentages;
    
    public GameObject dupiLogo;

    private IEnumerator titulo;
    private IEnumerator primeraSeccion;
    private IEnumerator segundaSeccion;
    private IEnumerator terceraSeccion;

    int counterEventos = 0;
    int counter = 0;
	public void Start () {
        mySource.Stop();
        mySource.GetComponent<AudioSource>().clip = narraticas[0];
        
        counter = 0;
        chapterTitle.gameObject.SetActive(true);
        //
        textos1.gameObject.SetActive(false);
        worldWide.gameObject.SetActive(false);
        dupiLogo.gameObject.SetActive(false);
        
        titulo = TitleSection();
        hombreCh1.gameObject.SetActive(true);
        StartCoroutine(titulo);
        
	}

    IEnumerator TitleSection() {
        yield return new WaitForSeconds(5);
        mySource.GetComponent<AudioSource>().clip = narraticas[0];
        chapterTitle.gameObject.SetActive(false);
        primeraSeccion = PrimeraSeccion();
        StartCoroutine(primeraSeccion);
    }
    IEnumerator PrimeraSeccion() {
        mySource.Play();
        textos1.gameObject.SetActive(true);
        yield return new WaitForSeconds(8);
        mySource.Stop();
        mySource.GetComponent<AudioSource>().clip = narraticas[1];
        mySource.Play();
        yield return new WaitForSeconds(9f);
        Suplemento();
        /*hombreCh1.gameObject.SetActive(false);
        textos1.gameObject.SetActive(false);
        siguiente.gameObject.SetActive(false);
        StartCoroutine(segundaSeccion);*/

    }
    public void Suplemento() {
        StartCoroutine(Complementico());
    }
    IEnumerator Complementico() {
        mySource.Stop();
        yield return new WaitForSeconds(3);
        hombreCh1.gameObject.SetActive(false);
        textos1.gameObject.SetActive(false);
        segundaSeccion = SegundaSeccion();
        StartCoroutine(segundaSeccion);
    }
    public void VolverHome() {
        StopEverything();
        myMaster.GetComponent<MyMaster>().Start();
    }
    public void Siguiente() {
        //counter++;
        //if (counter == 1) {
            //Worldwide 
            StopEverything();
            hombreCh1.gameObject.SetActive(false);
            textos1.gameObject.SetActive(false);
            StartCoroutine(segundaSeccion);
            
       // }
    }
    IEnumerator SegundaSeccion() {
        worldWide.gameObject.SetActive(true);
        percentages.gameObject.SetActive(false);
        mySource.GetComponent<AudioSource>().clip = narraticas[2];
        mySource.Play();
        
        yield return new WaitForSeconds(11);
        my300.gameObject.SetActive(true);
        my300.GetComponent<Animator>().SetBool("is300", true);
        mySource.Stop();
        mySource.GetComponent<AudioSource>().clip = narraticas[3];
        mySource.Play();
        yield return new WaitForSeconds(6);//4
        my300.GetComponent<Animator>().SetBool("is300", false);
        yield return new WaitForSeconds(2f);
        my300.gameObject.SetActive(false);
        percentages.gameObject.SetActive(true);
        //yield return new WaitForSeconds(5);
        mySource.Stop();
        mySource.GetComponent<AudioSource>().clip = narraticas[4];
        mySource.Play();
        yield return new WaitForSeconds(3);
        mySource.GetComponent<AudioSource>().clip = narraticas[5];
        mySource.Play();
        yield return new WaitForSeconds(6);
        percentages.gameObject.SetActive(false);
        worldWide.gameObject.SetActive(false);
        dupiLogo.gameObject.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        
    }
    void StopEverything() {
        mySource.GetComponent<AudioSource>().clip = narraticas[0];
        mySource.Stop();
        mySource.GetComponent<AudioSource>().clip = narraticas[0];
        StopAllCoroutines();
    }


}
