using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizScript : MonoBehaviour
{

    public void OnClicked(Button Button)
    {
        string name = Button.name;
        Debug.Log("The name pressed is + " + name);
    }
}
