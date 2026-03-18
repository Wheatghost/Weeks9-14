using System.Collections;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.UIElements;

public class Spinner : MonoBehaviour
{
    public Transform duck;
    Coroutine doTheSpinRoutine;
    public bool spin = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void StartTheSpinRoutine()
    {
        spin = !spin;
            if (doTheSpinRoutine != null)
            {
                StopCoroutine(DoTheSpinRoutine());
            }
           doTheSpinRoutine = StartCoroutine (DoTheSpinRoutine());
    }
        IEnumerator DoTheSpinRoutine()
    {
        yield return doTheSpinRoutine = StartCoroutine(TheSpinRoutine());
    }
    IEnumerator TheSpinRoutine()
    {
        Vector3 newRotate = transform.eulerAngles;
        transform.eulerAngles = newRotate;
        float t = 0;
        while (spin == true)
        {
            newRotate.z += t;
            t += Time.deltaTime;
            duck.eulerAngles = newRotate*-1;
            yield return null;
        }
    }
}
