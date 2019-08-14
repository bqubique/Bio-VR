using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class QuizScript : MonoBehaviour
{
    public Animator animator;
    private int score = 0;
    private bool started = false;
    private List<string> buttonList;

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
        buttonList = new List<string>();
    }

    void Update()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        buttonList.Add(buttonName);
        foreach(string s in buttonList)
        {
            Debug.Log(s);
        }
    }

    public void FirstQuestion()
    {
        StartCoroutine(DisplayAfterOneSec("First Question","Welcome Screen"));
    }

    public void SecondQuestion()
    {
        StartCoroutine(DisplayAfterOneSec("Second Question","First Question"));
    }

    public void ThirdQuestion()
    {
        StartCoroutine(DisplayAfterOneSec("Third Question","Second Question"));
    }

    public void FourthQuestion()
    {
        StartCoroutine(DisplayAfterOneSec("Fourth Question","Third Question"));
    }

    public void FifthQuestion()
    {
        StartCoroutine(DisplayAfterOneSec("Fifth Question","Fourth Question"));
    }

    public void SixthQuestion()
    {
        StartCoroutine(DisplayAfterOneSec("Sixth Question","Fifth Question"));
    }

    public void SeventhQuestion()
    {
        StartCoroutine(DisplayAfterOneSec("Seventh Question","Sixth Question"));
    }

    public void EighthQuestion()
    {
        StartCoroutine(DisplayAfterOneSec("Eighth Question","Seventh Question"));
    }

    public void NinthQuestion()
    {
        StartCoroutine(DisplayAfterOneSec("Ninth Question", "Eighth Question"));
    }

    public void TenthQuestion()
    {
        StartCoroutine(DisplayAfterOneSec("Tenth Question","Ninth Question"));
    }
    public System.Collections.IEnumerator DisplayAfterOneSec(string questionToDisplay, string questionToDisappear)
    {
        animator.Play("Fade_Out");
        yield return new WaitForSeconds(1);
        GameObject.Find(questionToDisappear).transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find(questionToDisplay).transform.localScale = new Vector3(0.19f, 0.19f, 0.19f);
        animator.Play("Fade_In");
    }
}
