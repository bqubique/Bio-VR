using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizScript : MonoBehaviour
{
    Queue<string> questionQueue = new Queue<string>();
    private Text text;
    private int score = 0;
    private Dictionary<string, string> multipleChoiceDictionary = new Dictionary<string, string>();
    private string nameOfbuttonPressed;

    void Start()
    {
        fillTheQueue();
    }
    public void OnClicked(Button Button)
    {
        nameOfbuttonPressed = Button.name;
        Debug.Log("The name pressed is + " + name);
    }

    private void fillTheQueue()
    {
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
        if (questionQueue.Count != 0)
        {

            text.text = questionQueue.Peek();
            text.text += " you chose choice : ";

            questionQueue.Dequeue();
        }
        else
        {
            text.text = "You reached the end of the quiz. Your score is :  " + score;
        }
    }
}
