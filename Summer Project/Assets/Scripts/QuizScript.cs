using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class QuizScript : MonoBehaviour
{
    Queue<string> questionQueue = new Queue<string>();
    private Text text;
    private int score = 0;
    private List<string> answerList = new List<string>();
    
    private bool started = false;

    void Start()
    {
        fillTheQueue();
    }

    private void fillTheQueue()
    {
        questionQueue.Enqueue("This is a demo quiz to measure your knowledge on biology basics.Press Start to proceed with the first question.");
        questionQueue.Enqueue("Yeps");
        score++;
        questionQueue.Enqueue("Yass");
        score++;
        questionQueue.Enqueue("Whatever");
        score++;
        questionQueue.Enqueue("Fine");
        score++;
        questionQueue.Enqueue("Afaik");
        score++;
    }

    public void DisplayQuestionToUser()
    {
        text = GameObject.Find("FirstTextField").GetComponent<Text>();
        text.text = questionQueue.Peek();
        questionQueue.Dequeue();
        GameObject.Find("ZoomButton").transform.localScale = new Vector3(0, 0, 0);
        started = true;
        if ((questionQueue.Count != 0) && (started == true))
        {
            string choice = EventSystem.current.currentSelectedGameObject.name;
            text.text = questionQueue.Peek();
            answerList.Add(choice);
            text.text += " you chose choice : " + choice;
            questionQueue.Dequeue();
        }
        text.text = "You reached the end of the quiz. Your score is :  " + score;
    }
}
