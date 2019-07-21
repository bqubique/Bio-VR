using System.Collections;
using UnityEngine;

public class rotationScript : MonoBehaviour
{
    public Vector3 chromosomeStartPosition;
    public Vector3 adenineStartPosition;
    public Vector3 dnaStartPosition;
    public float speed = 1.2f;

    void Start()
    {
        chromosomeStartPosition = GameObject.Find("Chromosome").transform.position;         //get object position, save into chromosomeStartPosition
        adenineStartPosition = GameObject.Find("Adenine").transform.position;               //get object position, save into guanineStartPosition
        dnaStartPosition = GameObject.Find("DNA").transform.position;               //get object position, save into dnaStartPosition
        GameObject.Find("User").transform.Translate(new Vector3(0f, 0f, 0f));
    }


    void Update()
    {
        GameObject.Find("Chromosome").transform.Rotate(Vector3.right * 50 * Time.deltaTime);
        GameObject.Find("Chromosome").transform.position = new Vector3(0, chromosomeStartPosition.y - 0.6f + Mathf.Sin(Time.time * speed), 10);
        if(GameObject.Find("Adenine").transform.localScale == new Vector3(0, 0, 0))
        {
            return;
        }
        else
        {
            StartCoroutine(StartAdenineRotation());
        }
    }

    public IEnumerator StartAdenineRotation()
    {
        yield return new WaitForSeconds(1);
        GameObject.Find("Adenine").transform.position = new Vector3(adenineStartPosition.x, adenineStartPosition.y - 0.6f + Mathf.Sin(Time.time * 1.2f), adenineStartPosition.z);
        GameObject.Find("Adenine").transform.Rotate(Vector3.up * Time.deltaTime * 2f);
    }
}
