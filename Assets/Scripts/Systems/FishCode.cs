using UnityEngine;

public class FishCode : MonoBehaviour
{
    public GameObject fish;
    //Quality true = good fish, false = bad fish
    public bool quality;

    //Score code so that the fish can talk to it
    public ScoreCode score;
    //Timer code so that the fish can talk to it
    public Timer timer;
    //Spawner so that fish can talk to it
    public FishSpawner spawner;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Catch the fish
    public void Catch()
    {

    }

    //Toss the fish
    public void Toss()
    {
        Destroy(fish);
        if (quality == false)
        {
            timer.MoreTime();
        }
        else
        {
            timer.LessTime();
        }
        spawner.FishUpdate();
    }
    //Keep the fish
    public void Keep()
    {
        Destroy(fish);
        if (quality == false)
        {
            score.SubtractScore();
        }
        else
        {
            score.AddScore();
        }
        spawner.FishUpdate();
    }
}
