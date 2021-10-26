using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter2 : MonoBehaviour
{

    public GameObject chapterTitle;
    public GameObject myMaster;
    public AudioClip[] narraticas;
    public AudioSource mySource;
    public GameObject primeraParte;
    public GameObject primeraPuntoCincoParte;
    public GameObject segundaParte;
    public GameObject dupixentLogo;
    public GameObject terceraParte;
    public GameObject cuartaParte;

    private IEnumerator titulo;
    private IEnumerator primeraSeccion;
    private IEnumerator primeraPuntoCinco;
    private IEnumerator segundaSeccion;
    private IEnumerator terceraSeccion;
    private IEnumerator cuartaSeccion;

    public void Start()
    {
        chapterTitle.gameObject.SetActive(true);
        dupixentLogo.gameObject.SetActive(false);
        primeraParte.gameObject.SetActive(false);
        segundaParte.gameObject.SetActive(false);
        terceraParte.gameObject.SetActive(false);
        cuartaParte.gameObject.SetActive(false);
        primeraPuntoCincoParte.gameObject.SetActive(false);
        titulo = TitleSection();


        StartCoroutine(titulo);
    }
    IEnumerator TitleSection()
    {
        yield return new WaitForSeconds(5);
        mySource.Stop();
        chapterTitle.gameObject.SetActive(false);
        primeraParte.gameObject.SetActive(true);
        Primero();
    }
    void Primero()
    {
        primeraSeccion = PartOne();
        StartCoroutine(primeraSeccion);
    }
    IEnumerator PartOne()
    {
        mySource.GetComponent<AudioSource>().clip = narraticas[0];
        mySource.Play();
        Debug.Log("Arranca");
        yield return new WaitForSeconds(7);
        mySource.Stop();
        mySource.GetComponent<AudioSource>().clip = narraticas[1];
        mySource.Play();
        yield return new WaitForSeconds(2f);
        mySource.Stop();
        mySource.GetComponent<AudioSource>().clip = narraticas[2];
        mySource.Play();
        yield return new WaitForSeconds(8f);
        primeraPuntoCinco = PrimeraPuntoCinco();
        StartCoroutine(primeraPuntoCinco);
    }
    IEnumerator PrimeraPuntoCinco()
    {
        primeraParte.gameObject.SetActive(false);
        primeraPuntoCincoParte.gameObject.SetActive(true);
        mySource.Stop();
        mySource.GetComponent<AudioSource>().clip = narraticas[3];
        mySource.Play();
        yield return new WaitForSeconds(13);
        segundaSeccion = SegundaParte();
        StartCoroutine(segundaSeccion);
    }
    IEnumerator SegundaParte()
    {
        mySource.Stop();
        primeraPuntoCincoParte.gameObject.SetActive(false);
        segundaParte.gameObject.SetActive(true);
        mySource.GetComponent<AudioSource>().clip = narraticas[4];
        mySource.Play();
        yield return new WaitForSeconds(9f);
        mySource.Stop();
        mySource.GetComponent<AudioSource>().clip = narraticas[5];
        mySource.Play();
        yield return new WaitForSeconds(6f);
        mySource.Stop();
        mySource.GetComponent<AudioSource>().clip = narraticas[6];
        mySource.Play();
        yield return new WaitForSeconds(8f);
        terceraSeccion = TerceraParte();
        StartCoroutine(terceraSeccion);
    }

    IEnumerator TerceraParte()
    {
        mySource.Stop();
        mySource.GetComponent<AudioSource>().clip = narraticas[7];
        mySource.Play();
        segundaParte.gameObject.SetActive(false);
        terceraParte.gameObject.SetActive(true);
        yield return new WaitForSeconds(6);
        mySource.Stop();
        mySource.GetComponent<AudioSource>().clip = narraticas[8];
        mySource.Play();
        yield return new WaitForSeconds(15);
        cuartaSeccion = CuartaParte();
        StartCoroutine(cuartaSeccion);
    }

    IEnumerator CuartaParte()
    {
        terceraParte.gameObject.SetActive(false);
        cuartaParte.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        mySource.Stop();
        mySource.GetComponent<AudioSource>().clip = narraticas[9];
        mySource.Play();
        yield return new WaitForSeconds(8f);// 4f
        mySource.Stop();
        mySource.GetComponent<AudioSource>().clip = narraticas[10];
        mySource.Play();
        yield return new WaitForSeconds(4.5f);
        mySource.Stop();
        mySource.GetComponent<AudioSource>().clip = narraticas[11];
        mySource.Play();
        yield return new WaitForSeconds(4f);
        cuartaParte.gameObject.SetActive(false);
        dupixentLogo.gameObject.SetActive(true);
    }
    public void VolverHome()
    {
        StopEverything();
        myMaster.GetComponent<MyMaster>().Start();
    }
    void StopEverything()
    {
        mySource.Stop();
        StopAllCoroutines();
    }
}
