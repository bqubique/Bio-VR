using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizScript : MonoBehaviour
{
    private Text text;
    public void OnClicked(Button Button)
    {
        string name = Button.name;
        Debug.Log("The name pressed is + " + name);
    }


    public void DisplayQuestionToUser()
    {
        text = GameObject.Find("FirstTextField").GetComponent<Text>();
        text.text = "Yeah Whatever...";
    }
}
