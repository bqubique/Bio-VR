using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public GameObject obj = GameObject.Find("Chromosome");
    public Animator animator;
    private Camera mainCamera;
    void Start()
    {
        GameObject.Find("First Canvas Group").transform.localScale = new Vector3(1, 1, 1);
        GameObject.Find("Second Canvas Group").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Third Canvas Group").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Fourth Canvas Group").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Fifth Canvas Group").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Adenine").transform.localScale = new Vector3(0, 0, 0);
        mainCamera = Camera.main;
    }

    void Update()
    {
        GameObject.Find("DNA").transform.Rotate(Vector3.up * 2 * Time.deltaTime);
    }
    public void cellDivisionButton()
    {
        animator.Play("Fade_Out");
        StartCoroutine(ChangeToScene(1));
    }

    public void zoomButton()
    {
        animator.Play("Fade_Out");
        StartCoroutine(ChangeToScene(2));
    }

    public void quizButton()
    {
        animator.Play("Fade_Out");
        StartCoroutine(ChangeToScene(3));
    }

    public void mainMenuButton()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneShown = currentScene.name;
        if (sceneShown == "WelcomeScreen")
        {
            return;
        }
        else
        {
            animator.Play("Fade_Out");
            StartCoroutine(ChangeToScene(0));
        }
    }

    public IEnumerator WaitASecond(string canvasName)
    {
        yield return new WaitForSeconds(1);
        GameObject.Find(canvasName).transform.localScale = new Vector3(0, 0, 0);
    }

    public IEnumerator ChangeToScene(int sceneNo)
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(sceneNo);
    }

    //ChromosomeZoom method is used for MainCamera zoom when Chromosome GameObject is pressed
    public void ChromosomeZoom()
    {
        GameObject.Find("Second Canvas Group").transform.localScale = new Vector3(1, 1, 1);
        StartCoroutine(CameraZoom(1172));
        StartCoroutine(WaitASecond("First Canvas Group"));
    }

    //DNAZoom method is used for MainCamera zoom when DNA GameObject is pressed
    public void DNAZoom()
    {
        GameObject.Find("Third Canvas Group").transform.localScale = new Vector3(1, 1, 1);
        StartCoroutine(CameraZoom(2216));
        StartCoroutine(WaitASecond("Second Canvas Group"));
    }

    //GeneZoom method is used for MainCamera zoom when Gene GameObject is pressed
    public void GeneZoom()
    {
        GameObject.Find("Fourth Canvas Group").transform.localScale = new Vector3(1, 1, 1);
        StartCoroutine(CameraZoom(3465));
        StartCoroutine(WaitASecond("Third Canvas Group"));
    }

    //IntroneExoneZoom method is used for MainCamera zoom when IntroneExone GameObject is pressed
    public void IntroneExoneZoom()
    {
        GameObject.Find("Fifth Canvas Group").transform.localScale = new Vector3(1, 1, 1);
        GameObject.Find("Adenine").transform.localScale = new Vector3(3.2f, 3.2f, 3.2f);
        StartCoroutine(CameraZoom(4865));
        StartCoroutine(WaitASecond("Fourth Canvas Group"));
    }

    IEnumerator CameraZoom(int zoomValue)
    {
        GameObject user = GameObject.Find("User");
        float t = 0f;
        float duration = 1f;
        Vector3 startPosition = user.transform.localPosition;
        Vector3 endPosition = new Vector3(0, 0, transform.localPosition.z + zoomValue);

        while (t < duration)
        {
            t += Time.deltaTime;
            user.transform.localPosition = Vector3.Lerp(startPosition, endPosition, Mathf.SmoothStep(0, duration, t));
            yield return null;
        }
        mainCamera.transform.localPosition = endPosition;
    }
}