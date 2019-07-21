﻿using UnityEngine;

public class rotationScript : MonoBehaviour
{
    public Vector3 chromosomeStartPosition;
    public Vector3 adenineStartPosition;
    public Vector3 dnaStartPosition;
    public float speed = 1.2f;
    GameObject whatever;
    private bool chromosomeDisappeared = false;

    private Vector3 newPosition;
    void Start()
    {
        chromosomeStartPosition = GameObject.Find("Chromosome").transform.position;         //get object position, save into chromosomeStartPosition
        adenineStartPosition = GameObject.Find("Adenine").transform.position;               //get object position, save into guanineStartPosition
        dnaStartPosition = GameObject.Find("DNA").transform.position;               //get object position, save into dnaStartPosition
        GameObject.Find("User").transform.Translate(new Vector3(0f, 0f, 0f));
    }

    void Update()
    {
        GameObject.Find("Chromosome").transform.Rotate(Vector3.right *50 * Time.deltaTime);
        GameObject.Find("Chromosome").transform.position = new Vector3(0, chromosomeStartPosition.y + Mathf.Sin(Time.time * speed), 10);

        GameObject.Find("Adenine").transform.position = new Vector3(adenineStartPosition.x, adenineStartPosition.y + Mathf.Sin(Time.time * 1.2f), adenineStartPosition.z);
        GameObject.Find("Adenine").transform.Rotate(Vector3.up * Time.deltaTime * 2f);

    }
}