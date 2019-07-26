using System.Collections;
using UnityEngine;

public class rotationScript : MonoBehaviour
{
    public Vector3 chromosomeStartPosition;
    public Vector3 adenineStartPosition;
    public Vector3 guanineStartPosition;
    public Vector3 cytosineStartPosition;
    public Vector3 thymineStartPosition;
    public Vector3 dnaStartPosition;

    void Start()
    {
        chromosomeStartPosition = GameObject.Find("Chromosome").transform.position;         //get object position, save into chromosomeStartPosition
        adenineStartPosition = GameObject.Find("Adenine").transform.position;               //get object position, save into adenineStartPosition
        guanineStartPosition = GameObject.Find("Guanine").transform.position;               //get object position, save into guanineStartPosition
        cytosineStartPosition = GameObject.Find("Cytosine").transform.position;               //get object position, save into cytosineStartPosition
        thymineStartPosition = GameObject.Find("Thymine").transform.position;               //get object position, save into thymineStartPosition
        dnaStartPosition = GameObject.Find("DNA").transform.position;               //get object position, save into dnaStartPosition
        GameObject.Find("User").transform.Translate(new Vector3(0f, 0f, 0f));
    }

    void Update()
    {
        GameObject.Find("Chromosome").transform.Rotate(Vector3.down * 4 * Time.deltaTime);
        GameObject.Find("Chromosome").transform.position = new Vector3(chromosomeStartPosition.x, chromosomeStartPosition.y - 0.6f + Mathf.Sin(Time.time * 1.2f), 10);
        GameObject.Find("DNA").transform.Rotate(Vector3.up * 4 * Time.deltaTime);
        GameObject.Find("IEDNA").transform.Rotate(Vector3.forward * 10 * Time.deltaTime);
        if (GameObject.Find("Adenine").transform.localScale == new Vector3(0, 0, 0))
        {
            return;
        }
        else
        {
            StartCoroutine(StartAdenineRotation());
        }
        if (GameObject.Find("Guanine").transform.localScale == new Vector3(0, 0, 0))
        {
            return;
        }
        else
        {
            StartCoroutine(StartGuanineRotation());
        }
        if (GameObject.Find("Cytosine").transform.localScale == new Vector3(0, 0, 0))
        {
            return;
        }
        else
        {
            StartCoroutine(StartCytosineRotation());
        }
        if (GameObject.Find("Thymine").transform.localScale == new Vector3(0, 0, 0))
        {
            return;
        }
        else
        {
            StartCoroutine(StartThymineRotation());
        }
    }

    public IEnumerator StartAdenineRotation()
    {
        yield return new WaitForSeconds(1);
        GameObject.Find("Adenine").transform.position = new Vector3(adenineStartPosition.x, adenineStartPosition.y - 0.6f + Mathf.Sin(Time.time * 1.2f), adenineStartPosition.z);
        GameObject.Find("Adenine").transform.Rotate(Vector3.up * Time.deltaTime * 2f);
    }

    public IEnumerator StartGuanineRotation()
    {
        yield return new WaitForSeconds(1);
        GameObject.Find("Guanine").transform.position = new Vector3(guanineStartPosition.x, guanineStartPosition.y - 0.6f + Mathf.Sin(Time.time * 1.2f), guanineStartPosition.z);
        GameObject.Find("Guanine").transform.Rotate(Vector3.up * Time.deltaTime * 2f);
    }

    public IEnumerator StartCytosineRotation()
    {
        yield return new WaitForSeconds(1);
        GameObject.Find("Cytosine").transform.position = new Vector3(cytosineStartPosition.x, cytosineStartPosition.y - 0.6f + Mathf.Sin(Time.time * 1.2f), cytosineStartPosition.z);
        GameObject.Find("Cytosine").transform.Rotate(Vector3.forward * Time.deltaTime * 2f);
    }

    public IEnumerator StartThymineRotation()
    {
        yield return new WaitForSeconds(1);
        GameObject.Find("Thymine").transform.position = new Vector3(thymineStartPosition.x, thymineStartPosition.y - 0.6f + Mathf.Sin(Time.time * 1.2f), thymineStartPosition.z);
        GameObject.Find("Thymine").transform.Rotate(Vector3.down * Time.deltaTime * 2f);
    }
}
