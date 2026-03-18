using System.Collections;
using UnityEngine;

public class Grower : MonoBehaviour
{
    public Transform tree;
    public Transform apple;
    Coroutine doTheGrowingCoroutine;
    Coroutine growTheTreeCoroutine;
    Coroutine growTheAppleCoroutine;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tree.localScale = Vector2.zero;
        apple.localScale = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartTreeGrowing()
    {
        apple.localScale = Vector2.zero;
        if (doTheGrowingCoroutine != null)
        {
            StopCoroutine(doTheGrowingCoroutine);
        }
        if (growTheTreeCoroutine != null)
        {
            StopCoroutine (growTheTreeCoroutine);
        }
        if (growTheAppleCoroutine != null)
        {
            StopCoroutine (growTheAppleCoroutine);
        }
        doTheGrowingCoroutine = StartCoroutine(DoTheGrowing());
    }

    IEnumerator DoTheGrowing()
    {
        yield return growTheTreeCoroutine = StartCoroutine(GrowTree());
        yield return growTheAppleCoroutine = StartCoroutine(GrowApple());
    }
    IEnumerator GrowTree()
    {
        Debug.Log("started growing tree");
        float t = 0;
        while (t < 1)
        {
            t += Time.deltaTime;
            tree.localScale = Vector2.one * t;
            yield return null;
        }
        Debug.Log("finished growing tree");
    }
    IEnumerator GrowApple()
    {
        Debug.Log("started growing apple");
        float t = 0;
        while (t < 1)
        {
            t += Time.deltaTime;
            apple.localScale = Vector2.one * t;
            yield return null;
        }
        Debug.Log("finished growing apple");
    }
}
