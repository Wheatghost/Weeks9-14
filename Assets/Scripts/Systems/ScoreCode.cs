using TMPro;
using UnityEngine;

public class ScoreCode : MonoBehaviour
{
    //Tracks the score
    public float score = 0;
    public TextMeshProUGUI total;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        total.text = ("Score: " + score.ToString());
    }

    public void AddScore()
    {
        score += 10;
    }

    public void SubtractScore()
    {
        score -= 10;
    }
}
