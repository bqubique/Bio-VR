using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DivisionScript : MonoBehaviour
{
    float prevSpeed;
    Animator animator;
    private bool stopped = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    
    public void ToggleAnimation()
    {
        if (stopped)
        {
            ContinueAnim();
        }
        else
            PauseAnim();
    }

    public void PauseAnim()
    {
        stopped = true;
        prevSpeed = animator.speed;
        animator.speed = 0;
    }

    public void ContinueAnim()
    {
        stopped = false;
        animator.speed = prevSpeed;
    }
}
