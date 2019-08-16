using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class QuizScript : MonoBehaviour
{
    public Animator animator;
    public Text timeText;
    public Text resultsText;

    private float timeLeft = 80.0f;
    private float points;

    void Start()
    {
        points = 0.0f;
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
    }

    void Update()
    {
        //The game will end when the timeLeft variable has hit 0
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timeText.text = timeLeft.ToString("0");
        }
        else if (timeLeft <= 0)
        {
            GameEnded(points);
        }

        string buttonName = EventSystem.current.currentSelectedGameObject.name;

        //Check for correct answers
        if (buttonName == "FirstQA" || buttonName == "SecondQA" || buttonName == "ThirdQD" || buttonName == "FourthQB" || buttonName == "FifthQC" || buttonName == "SixthQD" || buttonName == "SeventhQD" || buttonName == "EighthQC" || buttonName == "NinthQD" || buttonName == "TenthQB" || buttonName == "EleventhQB" || buttonName == "TwelfthQC" || buttonName == "ThirteenthQB" || buttonName == "FourteenthQA" || buttonName == "FifteenthQD")
        {
            points += 6.66f;
        }
    }

    public void FirstQuestion()
    {
        StartCoroutine(DisplayAfterOneSec("First Question", "Welcome Screen"));
    }

    public void SecondQuestion()
    {
        StartCoroutine(DisplayAfterOneSec("Second Question", "First Question"));
    }

    public void ThirdQuestion()
    {
        StartCoroutine(DisplayAfterOneSec("Third Question", "Second Question"));
    }

    public void FourthQuestion()
    {
        StartCoroutine(DisplayAfterOneSec("Fourth Question", "Third Question"));
    }

    public void FifthQuestion()
    {
        StartCoroutine(DisplayAfterOneSec("Fifth Question", "Fourth Question"));
    }

    public void SixthQuestion()
    {
        StartCoroutine(DisplayAfterOneSec("Sixth Question", "Fifth Question"));
    }

    public void SeventhQuestion()
    {
        StartCoroutine(DisplayAfterOneSec("Seventh Question", "Sixth Question"));
    }

    public void EighthQuestion()
    {
        StartCoroutine(DisplayAfterOneSec("Eighth Question", "Seventh Question"));
    }

    public void NinthQuestion()
    {
        StartCoroutine(DisplayAfterOneSec("Ninth Question", "Eighth Question"));
    }

    public void TenthQuestion()
    {
        StartCoroutine(DisplayAfterOneSec("Tenth Question", "Ninth Question"));
    }

    public void EleventhQuestion()
    {
        StartCoroutine(DisplayAfterOneSec("Eleventh Question", "Tenth Question"));
    }

    public void TwelfthQuestion()
    {
        StartCoroutine(DisplayAfterOneSec("Twelfth Question", "Eleventh Question"));
    }

    public void ThirteenthQuestion()
    {
        StartCoroutine(DisplayAfterOneSec("Thirteenth Question", "Twelfth Question"));
    }

    public void FourteenthQuestion()
    {
        StartCoroutine(DisplayAfterOneSec("Fourteenth Question", "Thirteenth Question"));
    }

    public void FifteenthQuestion()
    {
        StartCoroutine(DisplayAfterOneSec("Fifteenth Question", "Fourteenth Question"));
    }

    //DisplayAfterOneSecond is used for the Fade_Out animation to play and to display the next question to the user
    public System.Collections.IEnumerator DisplayAfterOneSec(string questionToDisplay, string questionToDisappear)
    {
        animator.Play("Fade_Out");
        yield return new WaitForSeconds(1);
        GameObject.Find(questionToDisappear).transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find(questionToDisplay).transform.localScale = new Vector3(0.19f, 0.19f, 0.19f);
        animator.Play("Fade_In");
    }

    //Every canvas is removed and the Results Screen canvas is displayed along with the points received
    private void GameEnded(float points)
    {
        Debug.Log("RESULT IS =======" + points);
        resultsText.text = "Your result is : \n" + points;
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
    }
}
