using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter3 : MonoBehaviour {

    public AudioClip[] narraticas;
    public AudioSource mySource;
    public GameObject chapterTitle;
    public GameObject myMaster;
    public GameObject primeraParte;
    public GameObject segundaParte;
    public GameObject dupixentLogo;
    public GameObject terceraParte;
    public GameObject cuartaParte;

    private IEnumerator primeraSeccion;
    private IEnumerator segundaSeccion;
    private IEnumerator terceraSeccion;
    private IEnumerator cuartaSeccion;

    public void Start () {
        chapterTitle.gameObject.SetActive(true);
        primeraParte.gameObject.SetActive(false);
        segundaParte.gameObject.SetActive(false);
        terceraParte.gameObject.SetActive(false);
        cuartaParte.gameObject.SetActive(false);
        dupixentLogo.gameObject.SetActive(false);
        StartCoroutine(Title());
	}

    IEnumerator Title() {
        yield return new WaitForSeconds(5);
        chapterTitle.gameObject.SetActive(false);
        primeraParte.gameObject.SetActive(true);
        primeraSeccion = PrimeraParte();
        StartCoroutine(primeraSeccion);
    }
    
    IEnumerator PrimeraParte() {
        primeraParte.gameObject.SetActive(true);
        mySource.GetComponent<AudioSource>().clip = narraticas[0];
        mySource.Play();
        yield return new WaitForSeconds(5f);
        mySource.Stop();
        mySource.GetComponent<AudioSource>().clip = narraticas[1];
        mySource.Play();
        yield return new WaitForSeconds(6);
        mySource.Stop();
        segundaSeccion = SegundaParte();
        StartCoroutine(segundaSeccion);
    }
    IEnumerator SegundaParte() {
        primeraParte.gameObject.SetActive(false);
        segundaParte.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);
        mySource.Stop();
        mySource.GetComponent<AudioSource>().clip = narraticas[2];
        mySource.Play();
        yield return new WaitForSeconds(8f);
       // yield return new WaitForSeconds(1f);
        mySource.Stop();
        mySource.GetComponent<AudioSource>().clip = narraticas[3];
        mySource.Play();
        yield return new WaitForSeconds(6f);
        mySource.Stop();
        mySource.GetComponent<AudioSource>().clip = narraticas[4];
        mySource.Play();
        yield return new WaitForSeconds(10f);
        mySource.Stop();
        mySource.GetComponent<AudioSource>().clip = narraticas[5];
        mySource.Play();
        yield return new WaitForSeconds(14f);
        terceraSeccion = TerceraParte();
        StartCoroutine(terceraSeccion);
    }
    IEnumerator TerceraParte() {
        segundaParte.gameObject.SetActive(false);
        terceraParte.gameObject.SetActive(true);
        mySource.Stop();
        mySource.GetComponent<AudioSource>().clip = narraticas[6];
        mySource.Play();
        yield return new WaitForSeconds(24f);
        terceraParte.gameObject.SetActive(false);
        cuartaParte.gameObject.SetActive(true);
        mySource.Stop();
        mySource.GetComponent<AudioSource>().clip = narraticas[7];
        mySource.Play();
        yield return new WaitForSeconds(7f);
        cuartaParte.gameObject.SetActive(false);
        dupixentLogo.gameObject.SetActive(true);
    }
    private void AuxCuartaParte() {
        cuartaSeccion = CuartaParte();
        StartCoroutine(cuartaSeccion);
    }
    IEnumerator CuartaParte() {
        terceraParte.gameObject.SetActive(false);
        cuartaParte.gameObject.SetActive(true);
        mySource.Stop();
        mySource.GetComponent<AudioSource>().clip = narraticas[7];
        mySource.Play();
        yield return new WaitForSeconds(7f);
        cuartaParte.gameObject.SetActive(false);
        dupixentLogo.gameObject.SetActive(true);
    }
}
