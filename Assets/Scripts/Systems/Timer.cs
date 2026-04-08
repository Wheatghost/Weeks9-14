using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    //timer variables
    public float time = 30;
    public bool delay;
    public float alter = 10;

    //Slider component
    public Slider timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (time >= 0)
        {
            time -= Time.deltaTime;
            timer.value = time;
        }
    }

    public void MoreTime()
    {
        time += alter;
    }

    public void LessTime()
    {
        time -= alter;
    }
}
