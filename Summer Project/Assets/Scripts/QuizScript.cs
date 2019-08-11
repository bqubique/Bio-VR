using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class QuizScript : MonoBehaviour
{
    public Animator animator;
    private int score = 0;
    private bool started = false;

    void Start()
    {
        GameObject.Find("Welcome Screen").transform.localScale = new Vector3(0.19f, 0.19f, 0.19f);
        GameObject.Find("First Question").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Second Question").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Third Question").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Fourth Question").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Fifth Question").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Sixth Question").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Seventh Question").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Eighth Question").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Ninth Question").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Tenth Question").transform.localScale = new Vector3(0, 0, 0);
    }

    public void AnimationPlay()
    {
        StartCoroutine(waitOneSec());
    }

    public System.Collections.IEnumerator waitOneSec()
    {
        animator.Play("Fade_Out");
        yield return new WaitForSeconds(1);
        animator.Play("Fade_In");
    }
}
