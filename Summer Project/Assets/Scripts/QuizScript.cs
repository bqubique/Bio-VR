using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class QuizScript : MonoBehaviour
{
    public Animator animator;
    public Text timeText;
    public Text resultsText;

    private int questionNo = 0;
    private float timeLeft = 90.0f;
    private List<string> buttonList;
    private List<string> answerList;

    void Start()
    {
        GameObject.Find("Welcome Screen").transform.localScale = new Vector3(0.19f, 0.19f, 0.19f);
        GameObject.Find("Result Screen").transform.localScale = new Vector3(0, 0, 0);
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
        GameObject.Find("Eleventh Question").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Twelfth Question").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Thirteenth Question").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Fourteenth Question").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Fifteenth Question").transform.localScale = new Vector3(0, 0, 0);
        buttonList = new List<string>();
        answerList = new List<string>();
        fillAnswerList();
    }

    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timeText.text = timeLeft.ToString("0");
        }
        else if (timeLeft <= 0)
        {
            GameEnded(buttonList);
        }
        else if(questionNo == 15)
        {
            GameEnded(buttonList);
        }

        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        buttonList.Add(buttonName);
    }

    private void fillAnswerList()
    {
        answerList.Add("FirstQA");
        answerList.Add("SecondQA");
        answerList.Add("ThirdQD");
        answerList.Add("FourthQB");
        answerList.Add("FifthQC");
        answerList.Add("SixthQD");
        answerList.Add("SeventhQD");
        answerList.Add("EighthQC");
        answerList.Add("NinthQD");
        answerList.Add("TenthQB");
        answerList.Add("EleventhQB");
        answerList.Add("TwelfthQC");
        answerList.Add("ThirteenthQB");
        answerList.Add("FourteenthQA");
        answerList.Add("FifteenthQD");
    }

    public void FirstQuestion()
    {
        StartCoroutine(DisplayAfterOneSec("First Question", "Welcome Screen"));
        questionNo++;
    }

    public void SecondQuestion()
    {
        StartCoroutine(DisplayAfterOneSec("Second Question", "First Question"));
        questionNo++;
    }

    public void ThirdQuestion()
    {
        StartCoroutine(DisplayAfterOneSec("Third Question", "Second Question"));
        questionNo++;
    }

    public void FourthQuestion()
    {
        StartCoroutine(DisplayAfterOneSec("Fourth Question", "Third Question"));
        questionNo++;
    }

    public void FifthQuestion()
    {
        StartCoroutine(DisplayAfterOneSec("Fifth Question", "Fourth Question"));
        questionNo++;
    }

    public void SixthQuestion()
    {
        StartCoroutine(DisplayAfterOneSec("Sixth Question", "Fifth Question"));
        questionNo++;
    }

    public void SeventhQuestion()
    {
        StartCoroutine(DisplayAfterOneSec("Seventh Question", "Sixth Question"));
        questionNo++;
    }

    public void EighthQuestion()
    {
        StartCoroutine(DisplayAfterOneSec("Eighth Question", "Seventh Question"));
        questionNo++;
    }

    public void NinthQuestion()
    {
        StartCoroutine(DisplayAfterOneSec("Ninth Question", "Eighth Question"));
        questionNo++;
    }

    public void TenthQuestion()
    {
        StartCoroutine(DisplayAfterOneSec("Tenth Question", "Ninth Question"));
        questionNo++;
    }

    public void EleventhQuestion()
    {
        StartCoroutine(DisplayAfterOneSec("Eleventh Question", "Tenth Question"));
        questionNo++;
    }

    public void TwelfthQuestion()
    {
        StartCoroutine(DisplayAfterOneSec("Twelfth Question", "Eleventh Question"));
        questionNo++;
    }

    public void ThirteenthQuestion()
    {
        StartCoroutine(DisplayAfterOneSec("Thirteenth Question", "Twelfth Question"));
        questionNo++;
    }

    public void FourteenthQuestion()
    {
        StartCoroutine(DisplayAfterOneSec("Fourteenth Question", "Thirteenth Question"));
        questionNo++;
    }

    public void FifteenthQuestion()
    {
        StartCoroutine(DisplayAfterOneSec("Fifteenth Question", "Fourteenth Question"));
        questionNo++;
    }
    public System.Collections.IEnumerator DisplayAfterOneSec(string questionToDisplay, string questionToDisappear)
    {
        animator.Play("Fade_Out");
        yield return new WaitForSeconds(1);
        GameObject.Find(questionToDisappear).transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find(questionToDisplay).transform.localScale = new Vector3(0.19f, 0.19f, 0.19f);
        animator.Play("Fade_In");
    }

    private void GameEnded(List<string> listGiven)
    {
        GameObject.Find("Result Screen").transform.localScale = new Vector3(0.19f, 0.19f, 0.19f);
        GameObject.Find("Welcome Screen").transform.localScale = new Vector3(0, 0, 0);
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
        GameObject.Find("Eleventh Question").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Twelfth Question").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Thirteenth Question").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Fourteenth Question").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Fifteenth Question").transform.localScale = new Vector3(0, 0, 0);
        List<int> finalList = compareLists(listGiven);
        Debug.Log(finalList.ToString());

    }

    private List<int> compareLists(List<string> givenAnswers)
    {
        List<int> returnedList = new List<int>();
        for(int i=0; i<givenAnswers.Count; ++i)
        {
            if(givenAnswers[i] != answerList[i])
            {
                returnedList[i] = 0;
            }
            else
            {
                returnedList[i] = 1;
            }
        }
        return returnedList;
    }
}
