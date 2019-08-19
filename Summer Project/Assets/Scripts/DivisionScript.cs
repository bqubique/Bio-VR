using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DivisionScript : MonoBehaviour
{
    float prevSpeed;
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void PauseAnim()
    { 
        prevSpeed = animator.speed;
        animator.speed = 0;
    }

    public void ContinueAnim()
    {
        animator.speed = prevSpeed;
    }
}
