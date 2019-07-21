using System.Collections;
using UnityEngine;
public class MenuButtons : MonoBehaviour
{
    private bool dnaVisible = false;
    private bool chromosomeVisible = false;
    private bool guanineVisible = false;
    private Camera mainCamera;
    bool cameraMoved = false;
    void Start()
    {
        GameObject.Find("GuanineCanvas").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("ChromosomeCanvas").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("DNA").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Chromosome").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Guanine").transform.localScale = new Vector3(0, 0, 0);
        mainCamera = Camera.main;
    }

    public void dnaButton()
    {
        if (!dnaVisible)
        {
            GameObject.Find("DNA").transform.localScale = new Vector3(0.5f, 0.4f, 0.08f);
            dnaVisible = true;
        }
        else
        {
            GameObject.Find("DNA").transform.localScale = new Vector3(0, 0, 0);
            dnaVisible = false;
        }
    }

    public void chromosomeButton()
    {
        if (!chromosomeVisible)
        {
            GameObject.Find("ChromosomeCanvas").transform.localScale = new Vector3(1, 1, 1);
            GameObject.Find("Chromosome").transform.localScale = new Vector3(0.4273368f, 0.4273368f, 0.4273368f);
            chromosomeVisible = true;
        }
        else
        {
            GameObject.Find("Chromosome").transform.localScale = new Vector3(0, 0, 0);
            chromosomeVisible = false;
        }
    }
    IEnumerator CameraZoomIn()
    {
        float t = 0f;
        float duration = 1f;
        Vector3 startPosition = mainCamera.transform.localPosition;
        Vector3 endPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 16f, transform.localPosition.z - 10.5f);
        while (t < duration)
        {
            t += Time.deltaTime;
            GameObject.Find("User").transform.localPosition = Vector3.Lerp(startPosition, endPosition, Mathf.SmoothStep(0, duration, t));
            cameraMoved = true;
            yield return null;
        }
        mainCamera.transform.localPosition = endPosition;
    }

    //will zoom when pressed in chromosome, using chromosomePress() method
    IEnumerator chromosomeZoomIn()
    {
        float t = 0f;
        float duration = 1f;
        Vector3 startPosition = mainCamera.transform.localPosition;
        Vector3 endPosition = new Vector3(0, 0, 15);
        while (t < duration)
        {
            t += Time.deltaTime;
            GameObject.Find("User").transform.localPosition = Vector3.Lerp(startPosition, endPosition, Mathf.SmoothStep(0, duration, t));
            cameraMoved = true;
            yield return null;
        }
        mainCamera.transform.localPosition = endPosition;
        GameObject.Find("Chromosome").transform.localScale = new Vector3(0, 0, 0);
    }

    IEnumerator chromosomeZoomOut()
    {
        float t = 0f;
        float duration = 1f;
        Vector3 startPosition = mainCamera.transform.localPosition;
        Vector3 endPosition = new Vector3(0, 0, 0);
        while (t < duration)
        {
            t += Time.deltaTime;
            GameObject.Find("User").transform.localPosition = Vector3.Lerp(startPosition, endPosition, Mathf.SmoothStep(0, duration, t));
            cameraMoved = true;
            yield return null;
        }
        mainCamera.transform.localPosition = endPosition;
        GameObject.Find("Chromosome").transform.localScale = new Vector3(0, 0, 0);
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(2);
    }

    IEnumerator CameraZoomOut()
    {
        float t = 0f;
        float duration = 1f;
        Vector3 startPosition = mainCamera.transform.localPosition;
        Vector3 endPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 16f, transform.localPosition.z - 10.5f);
        while (t < duration)
        {
            t += Time.deltaTime;
            GameObject.Find("User").transform.localPosition = Vector3.Lerp(endPosition, startPosition, Mathf.SmoothStep(0, duration, t));
            yield return null;
        }
        mainCamera.transform.localPosition = endPosition;
    }

    public void guanineButton()
    {
        if (!chromosomeVisible)
        {
            GameObject.Find("GuanineCanvas").transform.localScale = new Vector3(1, 1, 1);
            GameObject.Find("Guanine").transform.localScale = new Vector3(0.53586f, 0.53586f, 0.53586f);
            GameObject.Find("MainCanvas").transform.localScale = new Vector3(0, 0, 0);
            guanineVisible = true;
        }
        else
        {
            GameObject.Find("GuanineCanvas").transform.localScale = new Vector3(0, 0, 0);
            guanineVisible = false;
        }
    }

    public void cameraDebugButton1()
    {
        if (!cameraMoved)
        {
            StartCoroutine(CameraZoomOut());
        }
        cameraMoved = true;
    }

    public void cameraDebugButton2()
    {
        if (cameraMoved)
        {
            StartCoroutine(CameraZoomIn());
        }
        cameraMoved = false;
    }

    public void chromosomePress()
    {
        StartCoroutine(chromosomeZoomIn());
    }
}
