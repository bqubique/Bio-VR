using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizScript : MonoBehaviour
{
    Queue<string> questionQueue = new Queue<string>();
    private Text text;

    void Start()
    {
        fillTheQueue();
    }
    public void OnClicked(Button Button)
    {
        string name = Button.name;
        Debug.Log("The name pressed is + " + name);
    }

    private void fillTheQueue()
    {
        questionQueue.Enqueue("Yeps");
        questionQueue.Enqueue("Yass");
        questionQueue.Enqueue("Whatever");
        questionQueue.Enqueue("Fine");
        questionQueue.Enqueue("Afaik");
    }

    public void DisplayQuestionToUser()
    {
        text = GameObject.Find("FirstTextField").GetComponent<Text>();
        if(questionQueue.Count != 0)
        {
            text.text = questionQueue.Peek();
            questionQueue.Dequeue();
        }
    }
}
